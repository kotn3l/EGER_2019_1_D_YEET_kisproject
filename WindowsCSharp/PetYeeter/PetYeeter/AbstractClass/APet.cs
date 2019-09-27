using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter
{
    abstract class APet : IDrawable
    {
        
        private byte health;
        public byte Health
        {
            get { return health; }
            set { health = value; }
        }

        private int hunger;
        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }


        private bool dead;
        public bool Dead
        {
            get { return dead; }
            set { dead = value; }
        }

        private string texturePath;
        public string TexturePath { get { return texturePath; }
            set {
                if (File.Exists(value))
                    texturePath = value;
                else throw new FileNotFoundException("File not found", value);
            }
        }

        public void Damage()
        {

        }
        public void Heal()
        {

        }

        public  void Display(Graphics g)
        {

        }

        public APet(string TexturePath)
        {
            this.Dead = false;
            this.Health = 255;
            this.Hunger = 0;
            this.TexturePath = TexturePath;
        }

    }
}
