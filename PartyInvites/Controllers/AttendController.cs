using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class AttendController : Controller
    {
        // GET: Attend
        public ActionResult Index()
        {
            StudentCompetitionDB studentCompetition = new StudentCompetitionDB();
            List<Attend> attends = (List<Attend>)studentCompetition.Attends.ToList();
            return View(attends);
        }

        public ActionResult Index1()
        {
            StudentCompetitionDB studentCompetition = new StudentCompetitionDB();
            List<Attend> attends = (List<Attend>)studentCompetition.Attends.ToList();
            return View(attends);
        }
    }
}