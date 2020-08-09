using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_billets
{
    class Wagon
    {
        public Voyageur[] places;
        //int[] tableau = new int[7];
        


        public Wagon(int nombrePlaces=30)
        {
            places = new Voyageur[nombrePlaces];
        }


    }
}
