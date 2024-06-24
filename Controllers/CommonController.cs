/**
  Author:    Nasser Mughrabi
File Contents:
    This class is a controller to handle common CRUD actions between different users
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.LMSModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.Controllers
{
    public class CommonController : Controller
    {

        protected Team21LMSContext db;

        public CommonController()
        {
            db = new Team21LMSContext();
        }


        /// <summary>
        /// Retreive a JSON array of all departments from the database.
        /// Each object in the array should have a field called "name" and "subject",
        /// where "name" is the department name and "subject" is the subject abbreviation.
        /// </summary>
        /// <returns>The JSON array</returns>
        public IActionResult GetDepartments()
        {
            var query = from dept in db.Departments
                        select new { name = dept.Name, subject = dept.Subject};

            return Json(query.ToArray());
        }



        /// <summary>
        /// Returns a JSON array representing the course catalog.
        /// Each object in the array should have the following fields:
        /// "subject": The subject abbreviation, (e.g. "CS")
        /// "dname": The department name, as in "Computer Science"
        /// "courses": An array of JSON objects representing the courses in the department.
        ///            Each field in this inner-array should have the following fields:
        ///            "number": The course number (e.g. 5530)
        ///            "cname": The course name (e.g. "Database Systems")
        /// </summary>
        /// <returns>The JSON array</returns>
        public IActionResult GetCatalog()
        {
            var query = from dept in db.Departments select new 
                        { 
                            subject = dept.Subject,
                            dname = dept.Name,
                            courses = (from course in db.Courses where course.Subject.Equals(dept.Subject) 
                            select new { number = course.Num, cname = course.Name})
                        };

            return Json(query.ToArray());
        }

        /// <summary>
        /// Returns a JSON array of all class offerings of a specific course.
        /// Each object in the array should have the following fields:
        /// "season": the season part of the semester, such as "Fall"
        /// "year": the year part of the semester
        /// "location": the location of the class
        /// "start": the start time in format "hh:mm:ss"
        /// "end": the end time in format "hh:mm:ss"
        /// "fname": the first name of the professor
        /// "lname": the last name of the professor
        /// </summary>
        /// <param name="subject">The subject abbreviation, as in "CS"</param>
        /// <param name="number">The course number, as in 5530</param>
        /// <returns>The JSON array</returns>
        public IActionResult GetClassOfferings(string subject, int number)
        {
            var query = from clas in db.Classes
                        join course in db.Courses on clas.CourseId equals course.CourseId
                        where course.Subject.Equals(subject) && course.Num.Equals((uint)number)
                        select new
                        {
                            season = clas.Season,
                            year = clas.Year,
                            location = clas.Location,
                            start = clas.Start,
                            end = clas.End,
                            fname = (from prof in db.Professors where prof.UId.Equals(clas.ProfId) select prof.FName),
                            lname = (from prof in db.Professors where prof.UId.Equals(clas.ProfId) select prof.LName)
                        };

            return Json(query.ToArray());
        }

        /// <summary>
        /// This method does NOT return JSON. It returns plain text (containing html).
        /// Use "return Content(...)" to return plain text.
        /// Returns the contents of an assignment.
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The name of the assignment category in the class</param>
        /// <param name="asgname">The name of the assignment in the category</param>
        /// <returns>The assignment contents</returns>
        public IActionResult GetAssignmentContents(string subject, int num, string season, int year, string category, string asgname)
        {
            var query = from assign in db.Assignments
                        join categ in db.AssignmentCategories on assign.CategoryId equals categ.CategoryId
                        join clas in db.Classes on categ.ClassId equals clas.ClassId
                        join course in db.Courses on clas.CourseId equals course.CourseId
                        where 
                        course.Subject.Equals(subject) 
                        && course.Num.Equals((uint)num) 
                        && clas.Season.Equals(season)
                        && clas.Year.Equals((uint)year) 
                        && categ.Name.Equals(category) 
                        && assign.Name.Equals(asgname)
                        select assign.Contents;
            
            if(!query.Any())
                return Json(new { success = false });

            return Content(query.FirstOrDefault());
        }


        /// <summary>
        /// This method does NOT return JSON. It returns plain text (containing html).
        /// Use "return Content(...)" to return plain text.
        /// Returns the contents of an assignment submission.
        /// Returns the empty string ("") if there is no submission.
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The name of the assignment category in the class</param>
        /// <param name="asgname">The name of the assignment in the category</param>
        /// <param name="uid">The uid of the student who submitted it</param>
        /// <returns>The submission text</returns>
        public IActionResult GetSubmissionText(string subject, int num, string season, int year, string category, string asgname, string uid)
        {
            var query = from sub in db.Submission
                        join assign in db.Assignments on sub.AssignmentId equals assign.AssignmentId
                        join categ in db.AssignmentCategories on assign.CategoryId equals categ.CategoryId
                        join clas in db.Classes on categ.ClassId equals clas.ClassId
                        join course in db.Courses on clas.CourseId equals course.CourseId
                        where 
                        course.Subject.Equals(subject) 
                        && course.Num.Equals((uint)num) 
                        && clas.Season.Equals(season)
                        && clas.Year.Equals((uint)year) 
                        && categ.Name.Equals(category) 
                        && assign.Name.Equals(asgname)
                        select sub.Contents;

            if(query.Any())
            {
                return Content(query.FirstOrDefault());
            }
            else
            {
                return Content("");
            }
        }


        /// <summary>
        /// Gets information about a user as a single JSON object.
        /// The object should have the following fields:
        /// "fname": the user's first name
        /// "lname": the user's last name
        /// "uid": the user's uid
        /// "department": (professors and students only) the name (such as "Computer Science") of the department for the user. 
        ///               If the user is a Professor, this is the department they work in.
        ///               If the user is a Student, this is the department they major in.    
        ///               If the user is an Administrator, this field is not present in the returned JSON
        /// </summary>
        /// <param name="uid">The ID of the user</param>
        /// <returns>
        /// The user JSON object 
        /// or an object containing {success: false} if the user doesn't exist
        /// </returns>
        public IActionResult GetUser(string uid)
        {
            var adminQuery = from admin in db.Administrators
                             where admin.UId.Equals(uid)
                             select new { fname = admin.FName, lname = admin.LName, uid = admin.UId };

            var profQuery = from prof in db.Professors
                            where prof.UId.Equals(uid)
                            select new { fname = prof.FName, lname = prof.LName, uid = prof.UId, department = prof.WorksIn };

            var studentQuery = from student in db.Students
                               where student.UId.Equals(uid)
                               select new { fname = student.FName, lname = student.LName, uid = student.UId, department = student.Major };


            if (adminQuery.Any())
            {
                return Json(adminQuery.ToArray()[0]);
            }
            else if (profQuery.Any())
            {
                return Json(profQuery.ToArray()[0]);
            }
            else if (studentQuery.Any())
            {
                return Json(studentQuery.ToArray()[0]);
            }
            else
            {
                return Json(new { success = false });
            }
        }
        /*******End code to modify********/
    }
}