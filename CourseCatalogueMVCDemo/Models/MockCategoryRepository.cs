using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogueMVCDemo.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
            {
                new Category
                {
                    CategoryId = 101,
                    Name= "Web Technology",
                    Description = "All Server side and client side Web Technology course."
                },
                new Category
                {
                    CategoryId = 102,
                    Name= "Data science",
                    Description = "All Data Science related course."
                },
                new Category
                {
                    CategoryId = 103,
                    Name= "Mobile Application Development",
                    Description = "Various courses related to Mobile Application Development."
                }
            };
    }
}
