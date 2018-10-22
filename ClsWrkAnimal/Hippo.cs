using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
     class Hippo : Animal , ISwim
    {
        public Hippo(int id, string name, string location) : base(id, name, location)
        {

        }

       

        public string Swim()
        {
            return "Hippo usually spend time in the water";
        }


        public override string MakeNoise()
        {
            return "Make a chirpy noise";
        }

        public override string Eat()
        {
            return "Hippo eat vegetables";
        }

        public override string Sleep()
        {
            return "Hippo sleeps very firmly";
        }
    }
}
