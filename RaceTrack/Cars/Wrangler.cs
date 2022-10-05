using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    internal class Wrangler : RaceCar
    {
       
            public Wrangler()
            {
                Name = "Jeep";
                TopSpeed = 90;
            }

            public override void StartEngine()
            {
                Console.WriteLine($"The {Name} starts like a dream!");
            }

            public override void Brake()
            {
                Console.WriteLine($"The {Name} stops by climbng a rock!");
                base.Brake();
            }
        
    }
}
