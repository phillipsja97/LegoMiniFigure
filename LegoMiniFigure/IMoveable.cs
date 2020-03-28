using System;
using System.Collections.Generic;
using System.Text;
using LegoMiniFigure.Composition.Heads;

namespace LegoMinifigures
{
    interface IMoveable
    {
        void Move(int howFar);
    }

    interface ILegoPiece : IMoveable, IColorful
    {

    }
}