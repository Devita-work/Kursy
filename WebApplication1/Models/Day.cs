using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Day: ICloneable
    {
        public string NameDay;
        public Lesson[] Lessons;

        public object Clone()
        {
            return new Day
            {
                NameDay = this.NameDay,
                Lessons = this.Lessons.ToArray()
            };
        }
    }
}