using _1911061930_Lekhang_bigschool.DTOs;
using _1911061930_Lekhang_bigschool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911061930_Lekhang_bigschool.Controllers
{
    public class AttendancesController : ApiController
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
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourserId == attendanceDto.CourseId))
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
        [HttpDelete]
        public IHttpActionResult DeleteAttendance(int id)
        {
            var userId = User.Identity.GetUserId();

            var attendance = _dbContext.Attendances
                .SingleOrDefault(a => a.AttendeeId == userId && a.CourserId == id);

            if (attendance == null)
                return NotFound();
            _dbContext.Attendances.Remove(attendance);
            _dbContext.SaveChanges();
            return Ok(id);
        }
    }
}
