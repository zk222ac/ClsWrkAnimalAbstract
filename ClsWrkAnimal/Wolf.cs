using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Wolf : ICanine
    {
        public string Eat()
        {
            return "Wolf eat flesh animals";
        }

        public string Sleep()
        {
            return "wolf sleep in the dag time";
        }
    }
}
