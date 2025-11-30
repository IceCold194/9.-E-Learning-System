using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.E_Learning_System
{
    internal class Course
    {
        public string Title { get; set; }
        public string Duration { get; set; }

        public Course(string title, string duration) 
        {
            Title = title;
            Duration = duration;
        }

        public virtual string DisplayDetails()
        {
            return $"Course: {Title}\nDuration: {Duration}\n";
        }
    }
}
