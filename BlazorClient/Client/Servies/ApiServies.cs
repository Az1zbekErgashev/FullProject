using BlazorClient.Client.Dto;
using BlazorClient.Shared;
using System.Net.Http.Json;

namespace BlazorClient.Client.Servies
{
    public class ApiServices
    {
        private readonly HttpClient _httpClient;

        public ApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Course>> GetCourseList()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Course>>("api/Course/all");
            return result;
        }

        public async Task<Course?> GetByIdCourse(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<Course>("/api/Course/one?id=" + id);
            return result;
        }

        public async Task<Education?> GetByEducation(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<Education>("/api/education/one?id=" + id);
            return result;
        }

        public async Task<List<Feedback>?> GetByFeedback(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Feedback>>("/api/feedback/one?id=" + id);
            return result;
        }

        public async Task<List<Result>> GetByResult(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Result>>("/api/result/one?id=" + id);
            return result;
        }

        public async Task<List<Course>> GetByUserCourse(string email)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Course>>("/api/user/user/course?email=" + email);
            return result;
        }

        public async System.Threading.Tasks.Task AddCourse(UserCourse course)
        {
            await _httpClient.PostAsJsonAsync("/api/user/course", course);
        }

        public async System.Threading.Tasks.Task<HttpResponseMessage> Register(UserDto userDto)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/user/one", userDto);
            return res;

        }

        public async System.Threading.Tasks.Task<HttpResponseMessage> Login(LoginDto loginDto)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/user/login", loginDto);
            return res;
        }

        public async System.Threading.Tasks.Task<HttpResponseMessage> GetContact(Contact contactq)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/contact/one", contactq);
            return res;
        }
        public async Task<List<Teacher>> GetTeachers()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Teacher>>("/api/teacher/one");
            return result;
        }

        public async Task<List<Lessons>> GetLessons(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Lessons>>("/api/lesson/one?id=" + id);
            return result;
        }

        public async Task<List<BlazorClient.Shared.Task>> GetTask()
        {
            var result = await _httpClient.GetFromJsonAsync<List<BlazorClient.Shared.Task>>("/api/task/one");
            return result;
        }

        public async Task<BlazorClient.Shared.Task> GetByIdTask(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<BlazorClient.Shared.Task>("/api/task/two?id=" + id);
            return result;
        }
        public async Task<List<Tests>> GetTests(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Tests>>("/api/test/one?id=" + id);
            return result;
        }



    }
}
