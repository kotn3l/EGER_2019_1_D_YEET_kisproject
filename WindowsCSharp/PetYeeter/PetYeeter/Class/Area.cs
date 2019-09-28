using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter
{
    class Area
    {
        public byte Width
        {
            get;
            private set;
        }

        public byte Height
        {
            get;
            private set;
        }
        private List<APet> petss;
        public List<APet> Petss
        {
            get { return new List<APet>(petss); }
        }

        public void Draw(Graphics g)
        {
            foreach (APet pet in Petss)
            {
                pet.Display(g);
            }
        }
        public void AddCat(Pets Kind, Point Position)
        {
            Kind.AddPet(new Cat(Position));
        }
        public void AddDog(Pets Kind, Point Position)
        {
            Kind.AddPet(new Dog(Position));
        }
    }
}
