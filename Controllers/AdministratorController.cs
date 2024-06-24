/**
  Author:    Nasser Mughrabi
File Contents:
    This class is a controller to handle admin CRUD actions
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.LMSModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : CommonController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Department(string subject)
        {
            ViewData["subject"] = subject;
            return View();
        }

        public IActionResult Course(string subject, string num)
        {
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            return View();
        }

        /*******Begin code to modify********/

        /// <summary>
        /// Returns a JSON array of all the courses in the given department.
        /// Each object in the array should have the following fields:
        /// "number" - The course number (as in 5530)
        /// "name" - The course name (as in "Database Systems")
        /// </summary>
        /// <param name="subject">The department subject abbreviation (as in "CS")</param>
        /// <returns>The JSON result</returns>
        public IActionResult GetCourses(string subject)
        {
            var query = from t in db.Courses
                        where t.Subject == subject
                        select new
                        {
                            number = t.Num,
                            name = t.Name
                        };

            return Json(query.ToArray());
        }


        /// <summary>
        /// Returns a JSON array of all the professors working in a given department.
        /// Each object in the array should have the following fields:
        /// "lname" - The professor's last name
        /// "fname" - The professor's first name
        /// "uid" - The professor's uid
        /// </summary>
        /// <param name="subject">The department subject abbreviation</param>
        /// <returns>The JSON result</returns>
        public IActionResult GetProfessors(string subject)
        {
            var query = from p in db.Professors
                        where p.WorksIn == subject
                        select new {
                            lname = p.FName,
                            fname = p.LName,
                            uid = p.UId
                        };
            return Json(query.ToArray());
        }



        /// <summary>
        /// Creates a course.
        /// A course is uniquely identified by its number + the subject to which it belongs
        /// </summary>
        /// <param name="subject">The subject abbreviation for the department in which the course will be added</param>
        /// <param name="number">The course number</param>
        /// <param name="name">The course name</param>
        /// <returns>A JSON object containing {success = true/false},
        /// false if the Course already exists.</returns>
        public IActionResult CreateCourse(string subject, int number, string name)
        {
            if (subject == null || name == null)
            {
                System.Diagnostics.Debug.WriteLine("cannot have null parameters");
                return Json(new { success = false });
            }

            Courses course = new Courses();
            course.Name = name;
            course.Subject = subject;
            course.Num = (uint)number;

            if (!db.Courses.Contains(course))
            {
                try
                {
                    db.Courses.Add(course);
                    db.SaveChanges();
                    return Json(new { success = true });
                }
                catch (Exception e)
                {
                    return Json(new { success = false });
                }
            }
            return Json(new { success = false });
        }



        /// <summary>
        /// Creates a class offering of a given course.
        /// </summary>
        /// <param name="subject">The department subject abbreviation</param>
        /// <param name="number">The course number</param>
        /// <param name="season">The season part of the semester</param>
        /// <param name="year">The year part of the semester</param>
        /// <param name="start">The start time</param>
        /// <param name="end">The end time</param>
        /// <param name="location">The location</param>
        /// <param name="instructor">The uid of the professor</param>
        /// <returns>A JSON object containing {success = true/false}. 
        /// false if another class occupies the same location during any time within the start-end range in the same semester, 
        /// or    if there is already a Class offering of the same Course in the same Semester.</returns>
        public IActionResult CreateClass(string subject, int number, string season, int year, DateTime start, DateTime end, string location, string instructor)
        {
            if (instructor == null || location == null || subject == null || season == null)
            {
                System.Diagnostics.Debug.WriteLine("cannot have null parameters");
                return Json(new { success = false });
            }

            uint? courseID = (from c in db.Courses
                            where c.Num == number && c.Subject == subject
                            select c.CourseId).FirstOrDefault();
            if (courseID == null) // check if course id can be found
            {
                return Json(new { success = false });
            }

            bool containsInstructor = (from p in db.Professors
                                       where p.UId == instructor
                                       select p.UId).Any();

            if (!containsInstructor) // check if instructor exists
            {
                System.Diagnostics.Debug.WriteLine("Instructor does not exist: " + instructor);
                return Json(new { success = false });
            }

            Classes newClass = new Classes();
            newClass.Season = season;
            newClass.Year = (uint)year;
            newClass.Location = location;
            newClass.Start = start.TimeOfDay;
            newClass.End = end.TimeOfDay;
            newClass.ProfId = instructor;
            newClass.CourseId = (uint)courseID;

            if (!db.Classes.Contains(newClass)) // check if any class offering exists
            {
                try
                {
                    var scheduleConflict = (from c in db.Classes
                                            where
                                                c.Season == newClass.Season && c.Year == newClass.Year 
                                                && c.Location == location && 
                                                ((c.Start <= newClass.Start && newClass.Start <= c.End) ||
                                                (c.Start <= newClass.End && newClass.End <= c.End) ||
                                                (c.Start <= newClass.Start && newClass.End <= c.End) ||
                                                (c.End <= newClass.End && newClass.Start <= c.Start))
                                            select c.ClassId).Any();

                    if (scheduleConflict) // check if any schedule conflict
                    {
                        System.Diagnostics.Debug.WriteLine("schedule conflict... start: " + start.ToString() + " end: " + end.ToString());
                        return Json(new { success = false });
                    }

                    db.Classes.Add(newClass);
                    db.SaveChanges();
                    return Json(new { success = true });
                }
                catch (Exception e) 
                {
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    return Json(new { success = false });
                }
            }
            System.Diagnostics.Debug.WriteLine("class already created for this semester and school year");
            return Json(new { success = false });
        }


        /*******End code to modify********/
    }
}