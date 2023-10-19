using System.Runtime.CompilerServices;
using BlazorClient.Client.Dto;
using BlazorClient.Shared;
using Task = BlazorClient.Shared.Task;
namespace BlazorClient.Server.AddData
{

    public class AddData
    { 
        public async Task<List<Course>> GetCourseAsyncList()
        {
            List<Course> outList = new();
            outList.Add(new()
            {
                Description = "База знаний Альпари: уроки, семинары и видео. Пройдите Обучение Бесплатно. 18+ Аналитические сервисы. Демо счет. Учись бесплатно. Офисы в Узбекистане и СНГ. Услуги: Курсы и обучение, Видеоматериалы, Лекции и семинары, Статьи и обзоры.",
                Id = 2,
                Name = "Математика",
                Price = 400000,
                Url = "https://shefit-m.ru/wp-content/uploads/2020/02/001120780.jpg",
            });
            outList.Add(new()
            {
                Description = "База знаний Альпари: уроки, семинары и видео. Пройдите Обучение Бесплатно. 18+ Аналитические сервисы. Демо счет. Учись бесплатно. Офисы в Узбекистане и СНГ. Услуги: Курсы и обучение, Видеоматериалы, Лекции и семинары, Статьи и обзоры.",
                Id = 1,
                Name = "Трейдинг",
                Price = 200000,
                Url = "https://img.freepik.com/free-vector/gradient-stock-market-concept_23-2149166910.jpg?size=626&ext=jpg&ga=GA1.1.1413502914.1697414400&semt=sph",
            });
            return outList;
        }

        public async Task<List<Education>> GetEducationsAsyncList()
        {
            List<Education> outList = new();
            outList.Add(new()
            {
                CourseEnd = "Lorem lorem lore",
                Id = 1,
                Description =
                    "База знаний Альпари: уроки, семинары и видео. Пройдите Обучение Бесплатно. 18+ Аналитические сервисы. Демо счет. Учись бесплатно. Офисы в Узбекистане и СНГ. Услуги: Курсы и обучение, Видеоматериалы, Лекции и семинары, Статьи и обзоры.",
                Tranding = "Математика",
                course = new Course(){Id = 2},
                courseComp1 = "lorem lorem lorem",
                courseComp2 = "lorem lorem lorem",
                courseComp3 = "lorem lorem lorem",
                courseComp4 = "lorem lorem lorem",
            });
            outList.Add(new()
            {
                CourseEnd = "Lorem lorem lorem",
                Id = 2,
                Description =
                    "База знаний Альпари: уроки, семинары и видео. Пройдите Обучение Бесплатно. 18+ Аналитические сервисы. Демо счет. Учись бесплатно. Офисы в Узбекистане и СНГ. Услуги: Курсы и обучение, Видеоматериалы, Лекции и семинары, Статьи и обзоры.",
                Tranding = "Математика",
                course = new Course() { Id = 1 },
                courseComp1 = "lorem lorem lorem",
                courseComp2 = "lorem lorem lorem",
                courseComp3 = "lorem lorem lorem",
                courseComp4 = "lorem lorem lorem",
            });
            return outList;
        }

        public async Task<List<Feedback>> GetFeedback()
        {
            List<Feedback> outList = new();
            outList.Add(new()
            {
                Course = new Course() { Id = 1 },
                Id = 1,
                Date = "11:03:2004",
                Name = "Alex",
                User = new User() { Id = 1 },
            });
            outList.Add(new()
            {
                Course = new Course() { Id = 1 },
                Id = 2,
                Date = "11:03:2004",
                Name = "John",
                User = new User() { Id = 2 },
            });
            outList.Add(new()
            {
                Course = new Course() { Id = 1 },
                Id = 3,
                Date = "11:03:2004",
                Name = "Simba",
                User = new User() { Id = 3 },
            });
            outList.Add(new()
            {
                Course = new Course() { Id = 1 },
                Id = 4,
                Date = "11:03:2004",
                Name = "Timon",
                User = new User() { Id = 4 },
            });
            outList.Add(new()
            {
                Course = new Course() { Id = 2 },
                Id = 5,
                Date = "11:03:2004",
                Name = "Timon",
                User = new User() { Id = 1 },
            }); outList.Add(new()
            {
                Course = new Course() { Id = 2 },
                Id = 6,
                Date = "11:03:2004",
                Name = "Timon",
                User = new User() { Id = 2 },
            }); outList.Add(new()
            {
                Course = new Course() { Id = 2 },
                Id = 7,
                Date = "11:03:2004",
                Name = "Timon",
                User = new User() { Id = 3 },
            }); outList.Add(new()
            {
                Course = new Course() { Id = 2 },
                Id = 8,
                Date = "11:03:2004",
                Name = "Timon",
                User = new User() { Id = 4 },
            });

            return outList;
        }

        public async Task<List<Result>> GetResult()
        {
            List<Result> outList = new();
            outList.Add(new()
            {
                Education = new Education() { Id = 1 },
                ID = 1,
                Url = "https://allbook.by/wp-content/uploads/2022/01/cover1__w820-8-1.jpg",
                Name = "Alex",
                User = new User() { Id = 1 },
                Description = "Вы Lorem Lorem Lorem",
            });
            outList.Add(new()
            {
                Education = new Education() { Id = 1 },
                ID = 2,
                Url = "https://allbook.by/wp-content/uploads/2022/01/cover1__w820-8-1.jpg",
                Name = "Timon",
                User = new User() { Id = 2 },
                Description = "Вы Lorem Lorem Lorem",
            });
            outList.Add(new()
            {
                Education = new Education() { Id = 1 },
                ID = 3,
                Url = "https://allbook.by/wp-content/uploads/2022/01/cover1__w820-8-1.jpg",
                Name = "Simba",
                User = new User() { Id = 3 },
                Description = "Вы Lorem Lorem Lorem",
            });
            return outList;
        }
        public async Task<List<Tests>> GetTest()
        {
            List<Tests> outList = new();
            outList.Add(new()
            {
                Id = 1,
                correct = "3",
                incorrect1 = "2",
                incorrect2 = "4",
                incorrect3 = "5",
                Course = new Course() { Id = 1 },
                Queshioquestion = "5-2 = ? Сколько?"
            });
            outList.Add(new()
            {
                Id = 2,
                correct = "4",
                incorrect1 = "2",
                incorrect2 = "3",
                incorrect3 = "5",
                Course = new Course() { Id = 1 },
                Queshioquestion = "5-1 = ? Сколько?"
            });
            outList.Add(new()
            {
                Id = 3,
                correct = "4",
                incorrect1 = "2",
                incorrect2 = "3",
                incorrect3 = "5",
                Course = new Course() { Id = 2 },
                Queshioquestion = "5-1 = ? Сколько?"
            });
            outList.Add(new()
            {
                Id = 4,
                correct = "1",
                incorrect1 = "2",
                incorrect2 = "3",
                incorrect3 = "5",
                Course = new Course() { Id = 2 },
                Queshioquestion = "5-4 = ? Сколько?"
            });
            return outList;
        }

        public async Task<List<User>> RegistesssrDto(User user)
        {
            List<User> outList = new();
            outList.Add(new()
            {
                Id = user.Id,
                Course = user.Course,
                Email = user.Email,
                FullName = user.FullName,
                Password = user.Password,
            });
            return outList;
        }
        public async Task<List<User>>GetLogin()
        {
            List<User> outList = new();
            outList.Add(new()
            {
                Id = 1,
                Email = "aziz@gmail.com",
                Course = new List<Course>() { new Course() { Id = 1 } },
                FullName = "Aziz",
                Password = "Azizbek1"
            });
            outList.Add(new()
            {
                Id = 2,
                Email = "azizbek@gmail.com",
                Course = new List<Course>() { new Course() { Id = 1 } },
                FullName = "Aziz",
                Password = "Azizbek2"
            });
            outList.Add(new()
            {
                Id = 3,
                Email = "aziz06@gmail.com",
                Course = new List<Course>() { new Course() { Id = 2 } },
                FullName = "Aziz",
                Password = "Azizbek3"
            });
            outList.Add(new()
            {
                Id = 4,
                Email = "aziz0611@gmail.com",
                Course = new List<Course>() { new Course() { Id = 2} },
                FullName = "Aziz",
                Password = "Azizbek4"
            });
            return outList;
        }

        public async Task<List<HomeWork>> GetHomeWork()
        {
            List<HomeWork> outList = new();
            outList.Add(new()
            {
                Id = 1,
                Name = "Lorem lorem lore",
                Task = new Task(){Id = 1},
                Title = "Lorem lorem lorem",
                Img = "lorem lorem lorem",

            });
            outList.Add(new()
            {
                Id = 2,
                Name = "Lorem lorem lore",
                Task = new Task() { Id = 2 },
                Title = "Lorem lorem lorem",
                Img = "lorem lorem lorem",

            });
            return outList;
        }

        public async Task<List<Lessons>> GetLesson()
        {
            List<Lessons> outList = new();
            outList.Add(new()
            {
                Course = new Course(){Id = 1},
                Description = "Lorem lorem lorem",
                Id = 1,
                Title = "lorem lorem lorem",
                Video_url = "lorem lorem lorem",
            });
            outList.Add(new()
            {
                Course = new Course() { Id = 2 },
                Description = "Lorem lorem lorem",
                Id = 2,
                Title = "lorem lorem lorem",
                Video_url = "lorem lorem lorem",
            });

            return outList;
        }

        public async Task<List<Teacher>> GetTeacher()
        {
            List<Teacher> outList = new();
            outList.Add(new()
            {
                Id = 1,
                Description = "Lorem lorem lorem",
                Name = "Alex",
                Url = "https://t3.ftcdn.net/jpg/02/43/12/34/360_F_243123463_zTooub557xEWABDLk0jJklDyLSGl2jrr.jpg"
            });
            outList.Add(new()
            {
                Id = 2,
                Description = "Lorem lorem lorem",
                Name = "Sana",
                Url = "https://t4.ftcdn.net/jpg/03/83/25/83/360_F_383258331_D8imaEMl8Q3lf7EKU2Pi78Cn0R7KkW9o.jpg"
            });
            return outList;
        }

        public async Task<List<Task>> GetTask()
        {
            List<Task> outList = new();
            outList.Add(new()
            {
                Id = 1,
                Lessons = new Lessons(){Id = 1},
                Data = "11:02:2002",
                Description = "lorem lorem lorem",
                Title = "lorem lorem lorem",

            });
            outList.Add(new()
            {
                Id = 2,
                Lessons = new Lessons() { Id = 2 },
                Data = "11:02:2002",
                Description = "lorem lorem lorem",
                Title = "lorem lorem lorem",

            });
            return outList;
        }
    }
}
