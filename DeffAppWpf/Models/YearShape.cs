using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeffAppWpf.Models
{
    class YearShape
    {
        public int Id { get; set; }
        public double StartMeasurementWaist { get; set; }
        public double StartMeasurementNeck { get; set; }
        public double StartWeight { get; set; }
        public double GoalWeight { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double StartBodyFat { get; set; }
        public IList<DayShape> DayShapes { get; set; }
    }
}
