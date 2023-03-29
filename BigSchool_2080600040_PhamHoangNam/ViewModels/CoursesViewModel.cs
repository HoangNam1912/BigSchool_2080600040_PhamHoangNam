using BigSchool_2080600040_PhamHoangNam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool_2080600040_PhamHoangNam.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }

    }
}