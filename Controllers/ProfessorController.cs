/**
  Author:    Nasser Mughrabi
File Contents:
    This class is a controller to handle professor CRUD actions
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
    [Authorize(Roles = "Professor")]
    public class ProfessorController : CommonController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Students(string subject, string num, string season, string year)
        {
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            ViewData["season"] = season;
            ViewData["year"] = year;
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

        public IActionResult Categories(string subject, string num, string season, string year)
        {
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            ViewData["season"] = season;
            ViewData["year"] = year;
            return View();
        }

        public IActionResult CatAssignments(string subject, string num, string season, string year, string cat)
        {
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            ViewData["season"] = season;
            ViewData["year"] = year;
            ViewData["cat"] = cat;
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

        public IActionResult Submissions(string subject, string num, string season, string year, string cat, string aname)
        {
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            ViewData["season"] = season;
            ViewData["year"] = year;
            ViewData["cat"] = cat;
            ViewData["aname"] = aname;
            return View();
        }

        public IActionResult Grade(string subject, string num, string season, string year, string cat, string aname, string uid)
        {
            ViewData["subject"] = subject;
            ViewData["num"] = num;
            ViewData["season"] = season;
            ViewData["year"] = year;
            ViewData["cat"] = cat;
            ViewData["aname"] = aname;
            ViewData["uid"] = uid;
            return View();
        }

        /*******Begin code to modify********/


        /// <summary>
        /// Returns a JSON array of all the students in a class.
        /// Each object in the array should have the following fields:
        /// "fname" - first name
        /// "lname" - last name
        /// "uid" - user ID
        /// "dob" - date of birth
        /// "grade" - the student's grade in this class
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <returns>The JSON array</returns>
        public IActionResult GetStudentsInClass(string subject, int num, string season, int year)
        {
            var query = from e in db.Enrolled
                        join s in db.Students on e.UId equals s.UId
                        join c in db.Classes on e.ClassId equals c.ClassId
                        join crs in db.Courses on c.CourseId equals crs.CourseId
                        where crs.Subject == subject && crs.Num == num && c.Season == season && c.Year == year
                        select new
                        {
                            fname = s.FName,
                            lname = s.LName,
                            uid = s.UId,
                            dob = s.Dob,
                            grade = e.Grade
                        };

            return Json(query.ToArray());
        }



        /// <summary>
        /// Returns a JSON array with all the assignments in an assignment category for a class.
        /// If the "category" parameter is null, return all assignments in the class.
        /// Each object in the array should have the following fields:
        /// "aname" - The assignment name
        /// "cname" - The assignment category name.
        /// "due" - The due DateTime
        /// "submissions" - The number of submissions to the assignment
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The name of the assignment category in the class, 
        /// or null to return assignments from all categories</param>
        /// <returns>The JSON array</returns>
        public IActionResult GetAssignmentsInCategory(string subject, int num, string season, int year, string category)
        {
            if (category == null)
            {
                var query = from crs in db.Courses
                            join c in db.Classes on crs.CourseId equals c.CourseId
                            join cat in db.AssignmentCategories on c.ClassId equals cat.ClassId
                            join a in db.Assignments on cat.CategoryId equals a.CategoryId
                            where crs.Subject == subject && crs.Num == num && c.Season == season && c.Year == year
                            select new
                            {
                                aname = a.Name,
                                cname = cat.Name,
                                due = a.Due,
                                submissions = a.Submission.Count()
                            };
                return Json(query.ToArray());
            }
            else
            {
                var query = from crs in db.Courses
                            join c in db.Classes on crs.CourseId equals c.CourseId
                            join cat in db.AssignmentCategories on c.ClassId equals cat.ClassId
                            join a in db.Assignments on cat.CategoryId equals a.CategoryId
                            where crs.Subject == subject && crs.Num == num && c.Season == season && c.Year == year && cat.Name == category
                            select new
                            {
                                aname = a.Name,
                                cname = cat.Name,
                                due = a.Due,
                                submissions = a.Submission.Count()
                            };

                return Json(query.ToArray());
            }
        }


        /// <summary>
        /// Returns a JSON array of the assignment categories for a certain class.
        /// Each object in the array should have the folling fields:
        /// "name" - The category name
        /// "weight" - The category weight
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The name of the assignment category in the class</param>
        /// <returns>The JSON array</returns>
        public IActionResult GetAssignmentCategories(string subject, int num, string season, int year)
        {
            var query = from crs in db.Courses
                        join c in db.Classes on crs.CourseId equals c.CourseId
                        join cat in db.AssignmentCategories on c.ClassId equals cat.ClassId
                        where crs.Subject == subject && crs.Num == num && c.Season == season && c.Year == year
                        select new
                        {
                            name = cat.Name,
                            weight = cat.Weight,
                        };
            return Json(query.ToArray());
        }

        /// <summary>
        /// Creates a new assignment category for the specified class.
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The new category name</param>
        /// <param name="catweight">The new category weight</param>
        /// <returns>A JSON object containing {success = true/false},
        ///	false if an assignment category with the same name already exists in the same class.</returns>
        public IActionResult CreateAssignmentCategory(string subject, int num, string season, int year, string category, int catweight)
        {
            if (subject == null || season == null || category == null)
            {
                System.Diagnostics.Debug.WriteLine("cannot have null parameters");
                return Json(new { success = false });
            }

            var classIDQuery 
                      = from crs in db.Courses
                        join c in db.Classes on crs.CourseId equals c.CourseId
                        where crs.Subject == subject && crs.Num == num && c.Season == season && c.Year == year
                        select c.ClassId;
            uint classID;
            if (classIDQuery.Any()) 
            {
                classID = classIDQuery.FirstOrDefault();
            }
            else
            {
                return Json(new { success = false });
            }


            AssignmentCategories cat = new AssignmentCategories();
            cat.ClassId = classID;
            cat.Name = category;
            cat.Weight = (uint)catweight;

            if (!db.AssignmentCategories.Contains(cat))
            {
                try
                {
                    db.AssignmentCategories.Add(cat);
                    db.SaveChanges();
                    return Json(new { success = true });
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("adding error");
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    return Json(new { success = false });
                }
            }
            System.Diagnostics.Debug.WriteLine("Assignment category already exist");
            return Json(new { success = false });
        }

        /// <summary>
        /// Gets a JSON array of all the submissions to a certain assignment.
        /// Each object in the array should have the following fields:
        /// "fname" - first name
        /// "lname" - last name
        /// "uid" - user ID
        /// "time" - DateTime of the submission
        /// "score" - The score given to the submission
        /// 
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The name of the assignment category in the class</param>
        /// <param name="asgname">The name of the assignment</param>
        /// <returns>The JSON array</returns>
        public IActionResult GetSubmissionsToAssignment(string subject, int num, string season, int year, string category, string asgname)
        {
            var query = from crs in db.Courses
                        join c in db.Classes on crs.CourseId equals c.CourseId
                        join cat in db.AssignmentCategories on c.ClassId equals cat.ClassId
                        join a in db.Assignments on cat.CategoryId equals a.CategoryId
                        join sub in db.Submission on a.AssignmentId equals sub.AssignmentId
                        join s in db.Students on sub.StudentId equals s.UId
                        where crs.Subject == subject && crs.Num == num && c.Season == season && c.Year == year && cat.Name == category && a.Name == asgname
                        select new
                        {
                            fname = s.FName,
                            lname = s.LName,
                            uid = s.UId,
                            time = sub.Time,
                            score = sub.Score
                        };

            return Json(query.ToArray());
        }

        /// <summary>
        /// Returns a JSON array of the classes taught by the specified professor
        /// Each object in the array should have the following fields:
        /// "subject" - The subject abbreviation of the class (such as "CS")
        /// "number" - The course number (such as 5530)
        /// "name" - The course name
        /// "season" - The season part of the semester in which the class is taught
        /// "year" - The year part of the semester in which the class is taught
        /// </summary>
        /// <param name="uid">The professor's uid</param>
        /// <returns>The JSON array</returns>
        public IActionResult GetMyClasses(string uid)
        {
            var query = from c in db.Classes
                        join crs in db.Courses on c.CourseId equals crs.CourseId
                        where c.ProfId == uid
                        select new
                        {
                            subject = crs.Subject,
                            number = crs.Num,
                            name = crs.Name,
                            season = c.Season,
                            year = c.Year,
                        };

            return Json(query.ToArray());
        }

        /// <summary>
        /// Creates a new assignment for the given class and category.
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The name of the assignment category in the class</param>
        /// <param name="asgname">The new assignment name</param>
        /// <param name="asgpoints">The max point value for the new assignment</param>
        /// <param name="asgdue">The due DateTime for the new assignment</param>
        /// <param name="asgcontents">The contents of the new assignment</param>
        /// <returns>A JSON object containing success = true/false,
        /// false if an assignment with the same name already exists in the same assignment category.</returns>
        public IActionResult CreateAssignment(string subject, int num, string season, int year, string category, string asgname, int asgpoints, DateTime asgdue, string asgcontents)
        {
            if (subject == null || season == null || category == null || asgname == null)
            {
                System.Diagnostics.Debug.WriteLine("cannot have null parameters");
                return Json(new { success = false });
            }
            if (asgcontents == null)
            {
                asgcontents = "";
            }

            var categoryClassIDQuery = from crs in db.Courses
                        join c in db.Classes on crs.CourseId equals c.CourseId
                        join cat in db.AssignmentCategories on c.ClassId equals cat.ClassId
                        where crs.Subject == subject && crs.Num == num && c.Season == season && c.Year == year && cat.Name == category
                        select new
                        {
                            cat.CategoryId,
                            c.ClassId
                        };
            uint catID;
            uint classID;
            if (categoryClassIDQuery.Any()) {  
                catID = categoryClassIDQuery.FirstOrDefault().CategoryId;
                classID = categoryClassIDQuery.FirstOrDefault().ClassId;
            }
            else 
                return Json(new { success = false });

            Assignments ass = new Assignments();
            ass.CategoryId = catID;
            ass.Contents = asgcontents;
            ass.Name = asgname;
            ass.Due = asgdue;
            ass.MaxPoints = (uint)asgpoints;

            if (!db.Assignments.Contains(ass))
            {
                try
                {
                    db.Assignments.Add(ass); // insert assignment to the database
                    db.SaveChanges();
                    var studentsEnrolledQuery = from e in db.Enrolled
                                                join s in db.Students on e.UId equals s.UId
                                                where e.ClassId == classID
                                                select s.UId;

                    foreach (string uid in studentsEnrolledQuery)
                    {
                        System.Diagnostics.Debug.WriteLine("uid and classid: " + uid + ", " + classID);

                        recomputeGrade(classID, uid);
                    }


                    return Json(new { success = true });
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("error creating assignment");
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                    System.Diagnostics.Debug.WriteLine(e.Message);

                    return Json(new { success = false });
                }
            }

            System.Diagnostics.Debug.WriteLine("assignment with the same name already exist");

            return Json(new { success = false });
        }


        /// <summary>
        /// Set the score of an assignment submission
        /// </summary>
        /// <param name="subject">The course subject abbreviation</param>
        /// <param name="num">The course number</param>
        /// <param name="season">The season part of the semester for the class the assignment belongs to</param>
        /// <param name="year">The year part of the semester for the class the assignment belongs to</param>
        /// <param name="category">The name of the assignment category in the class</param>
        /// <param name="asgname">The name of the assignment</param>
        /// <param name="uid">The uid of the student who's submission is being graded</param>
        /// <param name="score">The new score for the submission</param>
        /// <returns>A JSON object containing success = true/false</returns>
        public IActionResult GradeSubmission(string subject, int num, string season, int year, string category, string asgname, string uid, int score)
        {
            if (subject == null || season == null || category == null || asgname == null || uid == null)
            {
                System.Diagnostics.Debug.WriteLine("cannot have null parameters");
                return Json(new { success = false });
            }

            var query = from crs in db.Courses
                        join c in db.Classes on crs.CourseId equals c.CourseId
                        join cat in db.AssignmentCategories on c.ClassId equals cat.ClassId
                        join a in db.Assignments on cat.CategoryId equals a.CategoryId
                        join sub in db.Submission on a.AssignmentId equals sub.AssignmentId
                        where crs.Subject == subject && crs.Num == num && c.Season == season && c.Year == year && cat.Name == category && a.Name == asgname && sub.StudentId == uid
                        select new
                        {
                            classID = c.ClassId,
                            submission = sub
                        };

            if (query.Any())
            {
                try
                {
                    Submission sub = query.FirstOrDefault().submission;
                    sub.Score = (uint)score;
                    db.SaveChanges();
                    recomputeGrade(query.FirstOrDefault().classID, uid); // recompute
                    return Json(new { success = true });
                }
                catch (Exception e)
                {
                    return Json(new { success = false });
                }
            }
            return Json(new { success = false });
        }


        private void recomputeGrade(uint classID, string studentID)
        {
            // If a student does not have a submission for an assignment, the score for that assignment is treated as 0.
            // If an AssignmentCategory does not have any assignments, it is not included in the calculation.
            var studentsSumInCategory = from s in db.Students
                                        join e in db.Enrolled on s.UId equals e.UId
                                        join c in db.Classes on e.ClassId equals c.ClassId
                                        join cat in db.AssignmentCategories on c.ClassId equals cat.ClassId
                                        join a in db.Assignments on cat.CategoryId equals a.CategoryId
                                        where c.ClassId == classID && s.UId == studentID 
                                        join sub in db.Submission
                                        on a.AssignmentId equals sub.AssignmentId
                                        into joined
                                        from j in joined.DefaultIfEmpty()
                                        select new
                                        {
                                            score = j == null ? null : (int?)j.Score,
                                            weight = cat.Weight,
                                            maxpoints = a.MaxPoints,

                                            catid = cat.CategoryId,
                                            catname = cat.Name,

                                        };

            var query = from c in db.Classes
                        join cat in db.AssignmentCategories on c.ClassId equals cat.ClassId
                        where c.ClassId == classID && cat.Assignments.Any()
                        select cat;

            double totalScores = 0.0;
            double totalWeights = 0.0;
            foreach (var categ in query)
            {
                totalWeights += (int)categ.Weight;
                double categTotalScores = 0, categTotalMax = 0;
                foreach (var data in studentsSumInCategory)
                {
                    if(categ.CategoryId == data.catid)
                    {
                        categTotalScores += data.score == null ? 0 : (double)data.score;
                        categTotalMax += (int)data.maxpoints;
                       
                    }
                }
                totalScores += categTotalScores / categTotalMax * categ.Weight;
            }

            double totalPercentage = totalScores * 100 / totalWeights;
            string letterGrade = "";

            if (totalPercentage > 93)
                letterGrade = "A";
            else if (totalPercentage >= 90)
                letterGrade = "A-";
            else if (totalPercentage >= 87)
                letterGrade = "B+";
            else if (totalPercentage >= 83)
                letterGrade = "B";
            else if (totalPercentage >= 80)
                letterGrade = "B-";
            else if (totalPercentage >= 77)
                letterGrade = "C+";
            else if (totalPercentage >= 73)
                letterGrade = "C";
            else if (totalPercentage >= 70)
                letterGrade = "C-";
            else if (totalPercentage >= 67)
                letterGrade = "D+";
            else if (totalPercentage >= 63)
                letterGrade = "D";
            else if (totalPercentage >= 60)
                letterGrade = "D-";
            else
                letterGrade = "E";

            var studentEnrolls = from e in db.Enrolled
                        where e.UId == studentID && e.ClassId == classID
                        select e;

            Enrolled eToUpdate = studentEnrolls.FirstOrDefault();
            eToUpdate.Grade = letterGrade;
            db.SaveChanges();
        }
        /*******End code to modify********/

    }
}