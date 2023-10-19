using BlazorClient.Server.Data;
using BlazorClient.Server.Dto;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;
using LoginDto = BlazorClient.Server.Dto.LoginDto;
using Task = System.Threading.Tasks.Task;
using UserDto = BlazorClient.Server.Dto.UserDto;


namespace BlazorClient.Server.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly AddData.AddData _add;
        public UserRepository(AppDbContext context, AddData.AddData add)
        {
            _context = context;
            _add = add;
        }

        public async Task<User> CreateUsers(UserDto userDto)
        {
            List<User> userDtos = await _add.GetLogin();

            User user = userDtos.FirstOrDefault(u => u.Email == userDto.Email);
            if (user != null)
            {
                // User already exists, return the found user
                return user;
            }
            User newUser = new User
            {
                FullName = userDto.FullName,
                Email = userDto.Email,
                Password = userDto.Password
            };
            //    List<User> userDtos = await _add.RegistesssrDto(user);
            userDtos.Add(new()
            {
                FullName = "adasdasd",
                Email = "dasdasdsa",
                Password = "dasdasdsads",
            });


            return newUser;
        }



        public async Task<User> Login(LoginDto loginDto)
        {
            List<User> user = await _add.GetLogin();

            var users =  user.FirstOrDefault(i =>
                i.Email == loginDto.Email && i.Password == loginDto.Password);
            return users;
        }



        public async Task<List<User>> GetAllUsers()
        {

            List<User> users = await _add.GetLogin();

            return users.ToList();
        }

        public async Task<User> GetById(string email)
        {
            var users = await _context.User
                .FirstOrDefaultAsync(e => e.Email == email);
            return users;

        }

        public async Task<User> GetUserByEmail(string email) => await _context.User.FirstOrDefaultAsync(e => e.Email == email) ?? throw new BadHttpRequestException("User not found");


        public async Task<List<Course>> GetUserCourse(string email)
        {
            List<User> users = await _add.GetLogin();

            var user =  users
                .FirstOrDefault(e => e.Email == email) ?? throw new BadHttpRequestException("User Not found");
            List<Course> courses = await _add.GetCourseAsyncList();
            int numId = 0;
             foreach (var VARIABLE in user.Course)
             {
                 numId = VARIABLE.Id;
             }

             var list = courses.FirstOrDefault(i => i.Id == numId);


            
            return new List<Course>() { list };
        }


        public async Task UpdateUsers(User user)
        {
            var sss = await _context.User.FirstOrDefaultAsync(i => i.Id == user.Id);
            if (sss != null)
            {
                sss.Email = user.Email;
                sss.FullName = user.FullName;
                sss.Password = user.Password;

                _context.Entry(sss).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddUserCourse(UserCourseDto userCourse)
        {
            var users = await _context.User.Include(u => u.Course)
                .FirstOrDefaultAsync(i => i.Email == userCourse.Email);
            var coursr = users?.Course;
            var cour = await _context.Course.FirstOrDefaultAsync(u => u.Id == userCourse.CourseId);
            coursr?.Add(cour);
            if (users != null)
            {
                users.Course = coursr;
                _context.Entry(users).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();
        }
    }

}
