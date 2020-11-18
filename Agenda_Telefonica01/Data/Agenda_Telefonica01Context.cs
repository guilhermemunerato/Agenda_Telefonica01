using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agenda_Telefonica01.Models;

namespace Agenda_Telefonica01.Data
{
    public class Agenda_Telefonica01Context : DbContext
    {
        public Agenda_Telefonica01Context (DbContextOptions<Agenda_Telefonica01Context> options)
            : base(options)
        {
        }

        public DbSet<Agenda> Agenda { get; set; }
    }
}
