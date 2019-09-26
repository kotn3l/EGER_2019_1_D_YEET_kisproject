using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter
{
    class APet
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

        private string texturePath;
        public string TexturePath
        {
            get { return texturePath; }
            set { texturePath = value; }
        }

        private bool dead;
        public bool Dead
        {
            get { return dead; }
            set { dead = value; }
        }

        public void Damage()
        {

        }
        public void Heal()
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
