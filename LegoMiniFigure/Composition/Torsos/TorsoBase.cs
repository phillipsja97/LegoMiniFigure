using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Torsos
{
    abstract class TorsoBase
    {
        public virtual bool ChiseledAbs { get; set; }
        public HandType HandType { get; set; }
        public bool Shirted { get; set; }

        public abstract void Flex(); // This basically states that any other class that inherits the TorsoBase class, has to have a Flex method.
                                     // if you don't have an abstract keyword in the method signature, then the method has be defined in the base class.

        public virtual void Breathe() // Anything that inherits will have this default method, but it can be changed in another class. (SEE astroTorso)
        {
            Console.WriteLine("Inhale, Exhale...");
        }


       


    }
}
