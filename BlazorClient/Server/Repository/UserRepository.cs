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
        public UserRepository(AppDbContext context) => _context = context;

        public async Task<User> CreateUsers(UserDto userDto)
        {
            User user = new User();
            user.FullName = userDto.FullName;
            user.Email = userDto.Email;
            user.Password = userDto.Password;

            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public Task<User> Login(LoginDto loginDto)
        {
            var users = _context.User.FirstOrDefaultAsync(i =>
                i.Email == loginDto.Email && i.Password == loginDto.Password);
            return users;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.User.ToListAsync();

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
            var user = await _context.User
                .Include(e => e.Course)
                .FirstOrDefaultAsync(e => e.Email == email) ?? throw new BadHttpRequestException("User Not found");

            List<Course> courseDto = user.Course.Select(course => new Course()
            {
                Id = course.Id,
                Url = course.Url,
                Name = course.Name,
                Description = course.Description,
                Price = course.Price
            }).ToList();

            return courseDto;
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
