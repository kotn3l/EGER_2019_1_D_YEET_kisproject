using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter
{
    interface IDrawable
    {
        string TexturePath { get; }

        void Display(Graphics g);
    }
}
