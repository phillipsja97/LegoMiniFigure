using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Legs
{
    class AstronautLegs
    {
        public bool HasPants { get; set; }  
        public ShoeType Shoes { get; set; }

        Random _rng = new Random();

        public void Walk(int steps)
        {
            Console.WriteLine($"The astronaut legs moonwalked {steps} steps.");
        }

        public int Jump()
        {
            var heightOfJump = _rng.Next();
            return heightOfJump;
        }

    }
        enum ShoeType
        {
            None,
            Boots,
            FlipFlops,

        }
}
