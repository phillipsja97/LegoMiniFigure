using System;

namespace LegoMiniFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Person", "Janitor");

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
