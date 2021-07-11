using _1911061930_Lekhang_bigschool.DTOs;
using _1911061930_Lekhang_bigschool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1911061930_Lekhang_bigschool.Controllers
{
    [Authorize]
    public class AttendancesController : Controller
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && attendanceDto.courseId))
                return BadRequest("The Attendance Already Exists!");     
            var attendance = new Attendance
            {
                CourserId = attendanceDto.CourseId,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
            
        }
    }
}