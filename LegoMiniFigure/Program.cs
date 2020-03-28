using LegoMiniFigure.Composition.Heads;
using LegoMiniFigure.Composition.Legs;
using LegoMiniFigure.Composition.Torsos;
using LegoMinifigures;
using System;
using System.Collections.Generic;

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
                Helmeted = true,
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops,
            };

            var atorso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                NumberOfArms = 3,
                Shirted = true,
            };

            var dtorso = new DadBodTorso();

            var astronaut = new Astronaut("Space Person", "Janitor", head, atorso, legs);
            var astronaut2 = new Astronaut("Space Person", "Janitor", head, dtorso, legs);

            astronaut.DoYourJob();
            astronaut2.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today);
            casper.Friendly = true;

            var fatso = new Ghost("fatso", new DateTime(1924, 12, 1));
            fatso.Friendly = false;

            casper.Haunt("Whipstaff Manor");

            casper.Spook();

            atorso.Breathe();
            dtorso.Breathe();

            var colorfulThings = new List<IColorful> { dtorso, atorso, new BabyLegs() };

            foreach (var colorfulThing in colorfulThings)
            {
                Console.WriteLine(colorfulThing.Color);

                switch (colorfulThing)
                {
                    case IMoveable mover:
                        mover.Move(5);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
