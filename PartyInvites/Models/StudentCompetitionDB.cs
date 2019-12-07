using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class StudentCompetitionDB
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Attend> Attends { get; set; }
        // public DbSet<FacultyStudent> FacultyStudent { get; set; }
    }
}
