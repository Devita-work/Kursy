using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Lesson : IComparable
    {
        public int Hour;
        public int Minutes;
        public string NameLesson;
        public int CompareTo(object obj)
        {
            Lesson p = obj as Lesson;
            if (p != null)
                return this.NameLesson.CompareTo(p.NameLesson);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

    

}
