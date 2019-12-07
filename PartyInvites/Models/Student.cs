using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
  
        // decorate it with special attributes
        [Table("Student")]
        public class Student
        {
            public int Id { get; set; }
            public int StudentId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string TechnicalInterest { get; set; }
            public string SocialNetworkInterest { get; set; }





        }
    
}
