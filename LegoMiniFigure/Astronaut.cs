using LegoMiniFigure.Composition.Heads;
using LegoMiniFigure.Composition.Legs;
using LegoMiniFigure.Composition.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure
{
    enum Location
    {
        Earth,
        Space,
        SpaceStation
    }
    class Astronaut
    {
        public Location Location { get; set; }
        public bool SuitedUp => true; // makes it so its always true and can't be altered in program.cs / EXPRESSION BODY PROPERTY
        public string Name { get; } // READ ONLY TYPE PROPERTY. can only get, can't set outside constructor. 
        public string Job { get; private set; } //  same as above but can be set outside of constructor in this file only. / PUBLIC PROPERTY, PRIVATE SETTER
        public int OxygenLevel { get; set; }

        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public ZoeHead Head { get; set; }

        public Astronaut(string name, string job, ZoeHead head, AstronautTorso torso, AstronautLegs legs)
        {
            Name = name;
            Job = job;
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
            Legs.Walk(15);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(10);
        }
    }
}
