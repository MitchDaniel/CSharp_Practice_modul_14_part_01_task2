using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Song
    {
        public string Name { get; set; }

        public TimeOnly Duration { get; set; }

        public string Style { set; get; }   

        public Song(string name, TimeOnly duraion, string  style) 
        {
            Name = name;
            Duration = duraion;
            Style = style;
        }
    }
}
//1. Название песни
//2. Длительность песни
//3. Стиль песни