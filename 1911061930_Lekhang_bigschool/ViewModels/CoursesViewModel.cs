using _1911061930_Lekhang_bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911061930_Lekhang_bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}