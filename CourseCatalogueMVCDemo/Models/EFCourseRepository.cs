﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogueMVCDemo.Models
{
    public class EFCourseRepository : ICourseRepository
    {
        private readonly AppDBContext appDBContext;

        public EFCourseRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IEnumerable<Course> AllCourses { 
            get 
            {
                return appDBContext.Courses.Include(c => c.Category);
            } 
        }


        public IEnumerable<Course> FreeCourseOfTheWeek => throw new NotImplementedException();

        public Course GetCourseById(int courseId)
        {
            return appDBContext.Courses.FirstOrDefault(c => c.CourseId == courseId);
        }
    }
}
