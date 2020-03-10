﻿using LegoMiniFigure.Composition.Heads;
using LegoMiniFigure.Composition.Legs;
using LegoMiniFigure.Composition.Torsos;
using System;

namespace LegoMiniFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ZoeHead
            {
                FacialExpression = "smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true,
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops,
            };

            var torso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                NumberOfArms = 3,
                Shirted = true,
            };
            var astronaut = new Astronaut("Space Person", "Janitor", head, torso, legs);

            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today);
            casper.Friendly = true;

            var fatso = new Ghost("fatso", new DateTime(1924, 12, 1));
            fatso.Friendly = false;

            casper.Haunt("Whipstaff Manor");

            casper.Spook();



            Console.ReadLine();
        }
    }
}
