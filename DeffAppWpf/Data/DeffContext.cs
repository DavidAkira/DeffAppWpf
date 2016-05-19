using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeffAppWpf.Models;

namespace DeffAppWpf.Data
{
    class DeffContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<YearShape> YearShapes { get; set; }
        public DbSet<DayShape> DayShapes { get; set; }

    }
}
