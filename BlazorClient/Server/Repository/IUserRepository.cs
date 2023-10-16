using BlazorClient.Server.Dto;
using BlazorClient.Shared;
using LoginDto = BlazorClient.Server.Dto.LoginDto;
using Task = System.Threading.Tasks.Task;
using UserDto = BlazorClient.Server.Dto.UserDto;

namespace BlazorClient.Server.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetById(string email);
        Task<User> CreateUsers(UserDto userDto);
        Task UpdateUsers(User user);
        Task AddUserCourse(UserCourseDto userCourse);
        Task<List<Course>> GetUserCourse(string email);
        Task<User> Login(LoginDto loginDto);
    }
}