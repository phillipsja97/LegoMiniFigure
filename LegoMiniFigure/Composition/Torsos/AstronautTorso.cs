using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Torsos
{
    class AstronautTorso : TorsoBase
    {
        public int NumberOfArms { get; set; }
        public override bool ChiseledAbs { get; set; }
        

        public override void Flex() // override is the keyword that corresponds with abstract from the base class.
        {
            if (ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if (HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome to the gun show");
            }
            else
            {
                Console.WriteLine("Weird flex, but ok");
            }
        }

        public override void Breathe() // You can also override the "virtual" keyword from the base to change the default behavior.
        {
            base.Breathe();
            Console.WriteLine("Exhale, Inhale."); // changed from inhale, exhale.
        }
    }
}
