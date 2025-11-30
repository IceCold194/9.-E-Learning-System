using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.E_Learning_System
{
    internal class OnlineCourse : Course
    {
        public string Platform { get; set; }

        public OnlineCourse(string title, string duration, string platform) : base(title, duration)
        {
            Platform = platform;
        }

        public override string DisplayDetails()
        {
            return base.DisplayDetails() + $"Platform: {Platform}";
        }
    }
}
