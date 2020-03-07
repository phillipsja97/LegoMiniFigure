using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure
{
    class Ghost
    {

        public bool Friendly { get; set; }
        public bool Visible { get; set; }
        public string Name { get; set; }
        public string HauntingLocation { get; private set; }
        public DateTime DeathDay { get; set; }

        public Ghost(string name, DateTime death)
        {
            Name = name;
            DeathDay = death;
        }

        public void Haunt(string location)
        {
            HauntingLocation = location;
            Console.WriteLine($"{Name} has moved into the {HauntingLocation}");
        }

        public void Spook()
        {
            if (string.IsNullOrEmpty(HauntingLocation)) return;

            Console.WriteLine($"{Name} does a spook at {HauntingLocation}");

        }
    }
}
