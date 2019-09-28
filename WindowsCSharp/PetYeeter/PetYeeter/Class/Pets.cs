using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter

    class Pets
    {
        private List<APet> petsC;
        public List<APet> PetsC
        {
            get { return new List<APet>(petsC); }
        }

        public void AddPet(APet pet)
        {
            this.petsC.Add(pet);
        }
    }
}
