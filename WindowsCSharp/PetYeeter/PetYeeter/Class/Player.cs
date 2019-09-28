using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter
{
    class Player
    {
        private int xp;
        public int Xp
        {
            get { return xp; }
            set { xp = value; }
        }

        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private int coins;
        public int Coins
        {
            get { return coins; }
            set { coins = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set {
                if (value == String.Empty || value == null)
                        throw new Exception();
                else name = value;
            }
        }


        public Player(string Name)
        {
            this.Name = Name;
            this.Xp = 0;
            this.Level = 1;
            this.Coins = 100;
        }


    }
}
