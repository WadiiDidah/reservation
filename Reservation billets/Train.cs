using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_billets
{
    class Train
    {
        public List<Wagon> wagons = new List<Wagon>();
        public string nom;
        
        public Train(string nom)
        {
            this.nom = nom;
        }

    }
}
