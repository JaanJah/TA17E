using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Mammal
    {
        public Mammal()
        {
            NumberOfEyes = 2;
            IsCarnivore = true;
            Breathe();
        }

        public int NumberOfEyes { get; set; }
        public bool IsCarnivore { get; set; }
        public void Breathe()
        {
            Console.WriteLine("I am breathing!");
        }
    }
}
