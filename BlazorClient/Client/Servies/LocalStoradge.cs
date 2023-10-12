using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorClient.Client.Servies
{
    public class LocalStoradge
    {
        private readonly NavigationManager _navigationManager;
        private readonly IJSRuntime _runtime;

        public LocalStoradge(NavigationManager navigationManager, IJSRuntime runtime)
        {
            _navigationManager = navigationManager;
            _runtime = runtime;
        }

        public async Task ClearLocalStoradge()
        {
            await _runtime.InvokeVoidAsync("localStorage");
        }

        public async void LogOUT()
        {
            await ClearLocalStoradge();
        }

        public async Task<string> GetEmail()
        {
            var email = await _runtime.InvokeAsync<string>("localStorage.getItem", "email");
            return email;
        }
        public async Task<string> GetCourseId()
        {
            var email = await _runtime.InvokeAsync<string>("localStorage.getItem", "courseId");
            return email;
        }


        public async Task<string> GetLessonId()
        {
            var email = await _runtime.InvokeAsync<string>("localStorage.getItem", "lessonId");
            return email;
        }
    }

}
