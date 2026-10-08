using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"{Brand} bicycle is moving at {Speed} km/h.");
        }
    }
}
