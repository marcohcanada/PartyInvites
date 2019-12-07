using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{

    
        [Table("Attend")]
        public class Attend
        {
            public int Id { get; set; }
            public int Student { get; set; }
            public string AcceptRegret { get; set; }

        }
    
}
