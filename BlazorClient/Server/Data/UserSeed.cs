using BlazorClient.Shared;

namespace BlazorClient.Server.Data
{
    public class UserSeed
    {
        private static List<User> _users = new List<User>();
        public static List<User> Users
        {
            get => _users;
            set => _users = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static void SeedAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.User.Any())
                {
                    context.User.AddRange(new List<User>
                    {
                        new User
                        {
                            Id = 1,
                            Email = "adsadas@gmail.com",
                            Password = "sadasdasd",
                            FullName = "dsadasdasd",
                        }
                    });
                    context.SaveChanges();
                }
            }
         
        }
    }

}
