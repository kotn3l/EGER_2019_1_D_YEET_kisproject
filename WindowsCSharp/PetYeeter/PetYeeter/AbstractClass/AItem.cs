using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter.AbstractClass
{
    abstract class AItem
    {
        private string texturePath;
        public string TexturePath
        {
            get { return texturePath; }
            set { texturePath = value; }
        }
    }
}
