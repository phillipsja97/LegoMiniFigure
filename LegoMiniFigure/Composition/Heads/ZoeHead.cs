using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Heads
{
    class ZoeHead
    {
        public bool Helmeted { get; set; }
        public LegoColor EyeColor { get; set; }
        public string FacialExpression { get; set; }
        public LegoColor Color { get; set; }
        public void Talk()
        {
            Console.WriteLine($"Zoe says 'Tell my wife I love her very much' with {FacialExpression} emphatically.");
        }

        public void EatPie(string typeOfPie)
        {
            if (typeOfPie == "apple")
            {
                Console.WriteLine("Mmm.. Pie");
            }
            else
            {
                Console.WriteLine("This is not a pie");
            }
        }
    }

    enum LegoColor
    {
        Yellow,
        Red,
        Green,
        White,
        Gray,
        Blue,
        Black,
        Orange
    }
}
