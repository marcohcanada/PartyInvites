using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult DisplayAllStudents()
        {
            StudentCompetitionDB competitionDBContext = new StudentCompetitionDB();
            List<Student> allStudents = (List<Student>)competitionDBContext.Students.ToList();
            return View(allStudents);
        }
        public ActionResult DisplaySingleStudentDetails(int id)
        {
            StudentCompetitionDB competitionDBContext = new StudentCompetitionDB();
            Student student = competitionDBContext.Students.Single(x => x.Id == id);
            return View(student);
        }
        public ActionResult DisplayStudentNamesWithLinks(int id)
        {
            StudentCompetitionDB competitionDBContext = new StudentCompetitionDB();
            List<Student> studentsWithAttends = competitionDBContext.Students.Where(x => x.StudentId == id).ToList();
            return View(studentsWithAttends);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}