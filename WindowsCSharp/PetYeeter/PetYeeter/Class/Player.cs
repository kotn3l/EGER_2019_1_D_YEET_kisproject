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
            set {
                if (value > 0)
                    xp = value;
                else throw new Exception();
            }
        }

        private int level;
        public int Level
        {
            get { return level; }
            set {
                if (value > 0)
                    level = value;
                else throw new Exception();
            }
        }

        private int coins;
        public int Coins
        {
            get { return coins; }
            set {
                if (value >= 0)
                    coins = value;
                else throw new Exception();
            }
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

        private List<AItem> ownedItems;
        public List<AItem> OwnedItems
        {
            get { return ownedItems; }
            set { ownedItems = value; }
        }



        public Player(string Name)
        {
            this.Name = Name;
            this.Xp = 0;
            this.Level = 1;
            this.Coins = 100;
        }

        public void LevelUp()
        {
            if (true)
                this.Level++;

        }

        public void Buy(AItem Item)
        {
            if (this.Coins - Item.Price >= 0)
            {
                OwnedItems.Add(Item);
            }
            else throw new NotEnoughCoinsException();
        }
    }
}
