using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class CompetitionInvite
    {
        public enum TechnicalInterest { IoT, MotionSensors, DataAnalytics, Programming }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        //[Required(ErrorMessage = "Please specify whether you'll attend")]
        //public bool? WillAttend { get; set; }
        public string Address { get; set; }
        public string SocialNetworkInterest { get; set; }
        public TechnicalInterest Interest { get; set; }
        public bool? AcceptInvitation { get; set; }
        public bool? SendRegrets { get; set; }
    }
}