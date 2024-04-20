using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Fish
    {
        public Fish(string name, int health) 
        {
            Name = name;

            Heath = health;
        }

        public string Name { get; private set;}
        public int Heath { get; private set;}

    }
}
