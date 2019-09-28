using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter
{
    abstract class AItem : IDrawable
    {
        private string texturePath;
        public string TexturePath
        {
            get { return texturePath; }
            set
            {
                if (File.Exists(value))
                    texturePath = value;
                else throw new FileNotFoundException("File not found", value);
            }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        public void Display(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
