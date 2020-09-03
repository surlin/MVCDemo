using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseCatalogueMVCDemo.Models;

namespace CourseCatalogueMVCDemo.ViewModels
{
    public class CourseListVM
    {
        public IEnumerable<Course> Courses { get; set; }
        public string SeletedCategoryName { get; set; }
    }
}
