using System;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;
namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(CompetitionInvite competitionInvite)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(competitionInvite);
                return View("Thanks", competitionInvite);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.AcceptInvitation == true));
        }
    }
}