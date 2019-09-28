using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter
{
    class Dog : APet
    {
        public Dog(Point Position) : base(config.Default.dogtex, Position)
        {
        }
    }
}
