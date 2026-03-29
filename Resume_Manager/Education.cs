using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_Manager
{
    public class Education
    {
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string Period { get; set; }

        public Education(string institution, string degree, string period)
        {
            Institution = institution;
            Degree = degree;
            Period = period;
        }

        public override string ToString()
        {
            return $"{Institution} - {Degree} ({Period})";
        }
    }
}
