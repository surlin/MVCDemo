using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseCatalogueMVCDemo.Models;
using CourseCatalogueMVCDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CourseCatalogueMVCDemo.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly ICategoryRepository categoryRepository;

        public CourseController(ICourseRepository courseRepository,
                                ICategoryRepository categoryRepository)
        {
            this.courseRepository = courseRepository;
            this.categoryRepository = categoryRepository;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult List()
        {
            //ViewBag.SelectedCategory = categoryRepository.AllCategories.ToList()[2].Name;

            ////Still passing All Courses
            //return View(courseRepository.AllCourses);

            CourseListVM courseListVM = new CourseListVM()
            {
                Courses = courseRepository.AllCourses,
                SeletedCategoryName = categoryRepository.AllCategories.ToList()[2].Name
            };
            return View(courseListVM);
        }
    }
}
