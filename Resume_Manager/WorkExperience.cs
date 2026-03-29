using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_Manager
{
    public class WorkExperience
    {
        public string Position { get; set; }
        public string Company { get; set; }
        public string Period { get; set; }
        public string Description { get; set; }

        public WorkExperience(string position, string company, string period, string description)
        {
            Position = position;
            Company = company;
            Period = period;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Position} в {Company} ({Period})\n{Description}";
        }
    }
}
