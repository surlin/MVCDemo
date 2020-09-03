using System.Collections.Generic;

namespace CourseCatalogueMVCDemo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Course> Courses { get; set; }
    }
}