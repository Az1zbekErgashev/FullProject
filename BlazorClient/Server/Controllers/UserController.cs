using BlazorClient.Server.Dto;
using BlazorClient.Server.Repository;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using EmailDto = BlazorClient.Client.Dto.EmailDto;

namespace BlazorClient.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    private readonly IUserRepository _userrepository;
    public UserController(IUserRepository userrepository, IFeedbackRepository feedbackRepository, IResultRepository resultRepository)
    {
        _userrepository = userrepository;
    }

    [HttpGet("allusers")]
    public async Task<IActionResult> GetUsers()
    {
        var all = await _userrepository.GetAllUsers();
        return Ok(all);
    }

    [HttpPost("one")]
    public async Task<IActionResult> AddUser(Dto.UserDto userDto)
    {

        var users = await _userrepository.GetById(userDto.Email);
        if (users == null)
        {
            var createdUser = await _userrepository.CreateUsers(userDto);
            return Ok(createdUser);
        }
        return BadRequest("User already exists");
    }


    [HttpPost("course")]
    public async Task<IActionResult> AdduserCourse(UserCourseDto userCourse)
    {
        await _userrepository.AddUserCourse(userCourse);
        return Ok();
    }


    [HttpPost("login")]
    public async Task<IActionResult> Login(Dto.LoginDto loginDto)
    {

        var checkUser = await _userrepository.Login(loginDto);
        if (checkUser == null)
        {
            return BadRequest("Incorrect Email or Password");
        }
        return Ok(checkUser);
    }

    [HttpPost("email")]
    public async Task<IActionResult> UpdateUser(EmailDto emailDto)
    {
        var async = await _userrepository.GetById(emailDto.Email);

        if (async == null)
        {
            return BadRequest("User Not Registered");
        }
        Random random = new Random();
        int otp = random.Next(10000000, 99999999);

        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse("ergasevaziz0611@gmail.com"));
        email.To.Add(MailboxAddress.Parse(emailDto.Email));
        email.Subject = "Your verification code";
        email.Body = new TextPart(TextFormat.Html) { Text = "Your verification code is " + otp };

        var smpt = new SmtpClient();
        await smpt.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
        await smpt.AuthenticateAsync("ergasevaziz0611@gmail.com", "jrmljzzmtlbsynkk");
        await smpt.SendAsync(email);
        await smpt.DisconnectAsync(true);

        async.Password = otp.ToString();

        await _userrepository.UpdateUsers(async);

        return Ok();

    }

    [HttpGet("user/course")]
    public async Task<ActionResult> UserCourse(string email)
    {
        var all = await _userrepository.GetUserCourse(email);
        return Ok(all);
    }
}
