using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"{Brand} is moving at {Speed} km/h.");
        }
    }
}
