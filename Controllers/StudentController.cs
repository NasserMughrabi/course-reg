﻿/**
  Author:    Nasser Mughrabi
File Contents:
    This class is a controller to handle student CRUD actions
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.LMSModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : CommonController
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            return View();
        }

        public IActionResult Class(string subject, string num, string season, string year)
        {
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            ViewData["season"] = season;
            ViewData["year"] = year;
            return View();
        }

        public IActionResult Assignment(string subject, string num, string season, string year, string cat, string aname)
        {
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            ViewData["season"] = season;
            ViewData["year"] = year;
            ViewData["cat"] = cat;
            ViewData["aname"] = aname;
            return View();
        }


        public IActionResult ClassListings(string subject, string num)
        {
            System.Diagnostics.Debug.WriteLine(subject + num);
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            return View();
        }


        /*******Begin code to modify********/

        /// <summary>
        /// Returns a JSON array of the classes the given student is enrolled in.
        /// Each object in the array should have the following fields:
        /// "subject" - The subject abbreviation of the class (such as "CS")
        /// "number" - The course number (such as 5530)
        /// "name" - The course name
        /// "season" - The season part of the semester
        /// "year" - The year part of the semester
        /// "grade" - The grade earned in the class, or "--" if one hasn't been assigned
        /// </summary>
        /// <param name="uid">The uid of the student</param>
        /// <returns>The JSON array</returns>
        public IActionResult GetMyClasses(string uid)
        {
            var query = from enroll in db.Enrolled
                        join clas in db.Classes on enroll.ClassId equals clas.ClassId
                        join course in db.Courses on clas.CourseId equals course.CourseId
                        where enroll.UId.Equals(uid) 
                        select new
                        {
                            subject = course.Subject,
                            number = course.Num,
                            name = course.Name,
                            season = clas.Season,
                            year = clas.Year,
                            grade = enroll.Grade
                        };

            return Json(query.ToArray());
        }

        /// <summary>
        /// Returns a JSON array of all the assignments in the given class that the given student is enrolled in.
        /// Each object in the array should have the following fields:
        /// "aname" - The assignment name
        /// "cname" - The category name that the assignment belongs to
        /// "due" - The due Date/Time
        /// "score" - The score earned by the student, or null if the student has not submitted to this assignment.
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="uid"></param>
        /// <returns>The JSON array</returns>
        public IActionResult GetAssignmentsInClass(string subject, int num, string season, int year, string uid)
        {
            var query = from assign in db.Assignments
                        join categ in db.AssignmentCategories on assign.CategoryId equals categ.CategoryId
                        join clas in db.Classes on categ.ClassId equals clas.ClassId
                        join course in db.Courses on clas.CourseId equals course.CourseId
                        join enroll in db.Enrolled on clas.ClassId equals enroll.ClassId
                        where course.Subject.Equals(subject) && course.Num.Equals((uint)num) && clas.Season.Equals(season)
                        && clas.Year.Equals((uint)year) && enroll.UId.Equals(uid)
                        join sub in db.Submission
                        on new { A = assign.AssignmentId, B = uid } equals new { A = sub.AssignmentId, B = sub.StudentId }
                        into joined
                        from j in joined.DefaultIfEmpty()
                        select new
                        {
                            aname = assign.Name,
                            cname = categ.Name,
                            due = assign.Due,
                            score = j.Contents.Length == 0 ? null : j.Score.ToString()
                        };
            
            return Json(query.ToArray());
        }



        /// <summary>
        /// Adds a submission to the given assignment for the given student
        /// The submission should use the current time as its DateTime
        /// You can get the current time with DateTime.Now
        /// The score of the submission should start as 0 until a Professor grades it
        /// If a Student submits to an assignment again, it should replace the submission contents
        /// and the submission time (the score should remain the same).
        /// Does *not* automatically reject late submissions.
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The name of the assignment category in the class</param>
        /// <param name="asgname">The new assignment name</param>
        /// <param name="uid">The student submitting the assignment</param>
        /// <param name="contents">The text contents of the student's submission</param>
        /// <returns>A JSON object containing {success = true/false}.</returns>
        public IActionResult SubmitAssignmentText(string subject, int num, string season, int year,
          string category, string asgname, string uid, string contents)
        {
            if (subject == null || season == null || category == null || asgname == null || uid == null)
            {
                return Json(new { success = false });
            }

            if(contents == null)
            {
                contents = "";
            }

            var query = from assign in db.Assignments
                        join categ in db.AssignmentCategories on assign.CategoryId equals categ.CategoryId
                        join clas in db.Classes on categ.ClassId equals clas.ClassId
                        join course in db.Courses on clas.CourseId equals course.CourseId
                        where course.Subject.Equals(subject) && course.Num.Equals((uint)num)
                        && clas.Season.Equals(season) && clas.Year.Equals((uint)year)
                        && categ.Name.Equals(category) && assign.Name.Equals(asgname)
                        select assign.AssignmentId;
            uint assignID = query.FirstOrDefault();

            if(!query.Any())
            {
                return Json(new { success = false });
            }

            var submissionQuery = from s in db.Submission 
                                  where s.AssignmentId.Equals(assignID) && s.StudentId.Equals(uid)
                                  select s;

            if (submissionQuery.Any())
            {
                try
                {
                    Submission prevSub = submissionQuery.FirstOrDefault();
                    prevSub.Time = DateTime.Now;
                    prevSub.Contents = contents;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    return Json(new { success = false });
                }
            }
            else
            {
                try
                {
                    Submission newSub = new Submission();
                    newSub.Score = 0;
                    newSub.AssignmentId = assignID;
                    newSub.StudentId = uid;
                    newSub.Time = DateTime.Now;
                    newSub.Contents = contents;
                    db.Submission.Add(newSub);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return Json(new { success = false });
                }
            }

            return Json(new { success = true });
        }


        /// <summary>
        /// Enrolls a student in a class.
        /// </summary>
        /// <param name="subject">The department subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester</param>
        /// <param name="year">The year part of the semester</param>
        /// <param name="uid">The uid of the student</param>
        /// <returns>A JSON object containing {success = {true/false},
        /// false if the student is already enrolled in the Class.</returns>
        public IActionResult Enroll(string subject, int num, string season, int year, string uid)
        {
            if(subject == null || season == null || uid == null)
            {
                return Json(new { success = false });
            }

            var query = from clas in db.Classes
                        join course in db.Courses on clas.CourseId equals course.CourseId
                        where course.Subject.Equals(subject) && course.Num.Equals((uint)num)
                        && clas.Season.Equals(season) && clas.Year.Equals((uint)year)
                        select clas.ClassId;
            uint classID = query.FirstOrDefault();

            if(query.Any())
            {
                Enrolled newClass = new Enrolled();
                newClass.ClassId = classID;
                newClass.UId = uid;
                newClass.Grade = "--";

                if (db.Enrolled.Contains(newClass))
                {
                    return Json(new { success = false });
                }
                else
                {
                    try
                    {
                        db.Enrolled.Add(newClass);
                        db.SaveChanges();
                        return Json(new { success = true });
                    }
                    catch (Exception e)
                    {
                        return Json(new { success = false });
                    }
                }
            }
            else
            {
                return Json(new { success = false });
            }
        }

        /// <summary>
        /// Calculates a student's GPA
        /// A student's GPA is determined by the grade-point representation of the average grade in all their classes.
        /// Assume all classes are 4 credit hours.
        /// If a student does not have a grade in a class ("--"), that class is not counted in the average.
        /// If a student does not have any grades, they have a GPA of 0.0.
        /// Otherwise, the point-value of a letter grade is determined by the table on this page:
        /// https://advising.utah.edu/academic-standards/gpa-calculator-new.php
        /// </summary>
        /// <param name="uid">The uid of the student</param>
        /// <returns>A JSON object containing a single field called "gpa" with the number value</returns>
        public IActionResult GetGPA(string uid)
        {
            var grades = from enroll in db.Enrolled where enroll.UId.Equals(uid)
                        select enroll.Grade;
            // if empty
            if (!grades.Any()){
                return Json(new { gpa = 0.0 });
            }

            double totalGrades = 0.0;
            foreach (var grade in grades)
            {
                if (grade != "--")
                    totalGrades += toGPA(grade);
            }

            double GPA = totalGrades / grades.Count();
            return Json(new { gpa = GPA });
        }

        // convert from letter scale to GPA out of 4.0
        private double toGPA(string grade)
        {
            if (grade == "A")
                return 4.0;
            else if (grade == "A-")
                return 3.7;
            else if (grade == "B+")
                return 3.3;
            else if(grade == "B")
                return 3.0;
            else if(grade == "B-")
                return 2.7;
            else if (grade == "C+")
                return 2.3;
            else if (grade == "C")
                return 2.0;
            else if (grade == "C-")
                return 1.7;
            else if (grade == "D+")
                return 1.3;
            else if (grade == "D")
                return 1.0;
            else if (grade == "D-")
                return 0.7;
            else
                return 0.0;
        }

        /*******End code to modify********/

    }
}