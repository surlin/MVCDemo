using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogueMVCDemo.Models
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly ICategoryRepository categoryRepository;

        public MockCourseRepository(ICategoryRepository repo)
        {
            categoryRepository = repo;
        }
        public IEnumerable<Course> FreeCourseOfTheWeek { get; }
        public IEnumerable<Course> AllCourses => new List<Course>
        {
            new Course{
                CourseId =1, Title= "ASP.Net Core",Description = "To be, or not to be: that is the question.",
                Fee =1350, isWeekendClassAvailale= true, ImageUrl= "https://www.logolynx.com/search?q=asp#&gid=1&pid=8",
                Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course{
                CourseId =2, Title= "Mean Stack",Description = "To die: to sleep",
                Fee =2000, isWeekendClassAvailale= true, ImageUrl= "https://www.logolynx.com/search?q=mean+stack#&gid=1&pid=5",
                Category = categoryRepository.AllCategories.ToList()[1]
            },
            new Course{
                CourseId =11, Title= "Data Analysis using Python",Description = "for who would bear the whips and scorns of time",
                Fee =1200, isWeekendClassAvailale= true, ImageUrl= "https://www.logolynx.com/search?q=mean+stack#&gid=1&pid=1",
                Category = categoryRepository.AllCategories.ToList()[1]
            },
            new Course{
                CourseId =12, Title= "Data Analysis using R",Description = "the oppressor's wrong, the proud man's contumely",
                Fee =1300, isWeekendClassAvailale= true, ImageUrl= "https://www.logolynx.com/search?q=mean+stack#&gid=1&pid=1",
                Category = categoryRepository.AllCategories.ToList()[1]
            },
            new Course{
                CourseId =21, Title= "Android Application Development",Description = "but that the dread of something after death",
                Fee =1550, isWeekendClassAvailale= true, ImageUrl= "https://www.logolynx.com/search?q=mean+stack#&gid=1&pid=1",
                Category = categoryRepository.AllCategories.ToList()[2]
            },
            new Course{
                CourseId =22, Title= "IOS Application Development",Description = "the undiscover'd country from whose bourn no traveller returns",
                Fee =1750, isWeekendClassAvailale= true, ImageUrl= "https://www.logolynx.com/search?q=mean+stack#&gid=1&pid=1",
                Category = categoryRepository.AllCategories.ToList()[2]
            }
        };

        public Course GetCourseById(int courseId)
        {
            return AllCourses.FirstOrDefault(c => c.CourseId == courseId);
        }
    }
}
