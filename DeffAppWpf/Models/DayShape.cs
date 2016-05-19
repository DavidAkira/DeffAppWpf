using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeffAppWpf.Models
{
    class DayShape
    {
        public int Id { get; set; }
        public double DayWeight { get; set; }
        public DateTime TodaysDate { get; set; }
        public double MeasurementWaist { get; set; }
        public string AppData { get; set; }
        public double DayBodyFat { get; set; }
    }
}
