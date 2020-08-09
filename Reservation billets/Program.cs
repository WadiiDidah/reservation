using System;
using System.Threading;

namespace Reservation_billets
{
    class Program
    {
        static void Main(string[] args)
        {
            Voyageur v1 = new Voyageur();
            v1.nom = "Rachid";
            v1.age = 19;
            v1.cin = "K11215441";
            WL(v1.nom);
            Voyageur v2 = new Voyageur("Wadii",19,"B5454487873") ;
            WL(v2.nom);
            Wagon w1 = new Wagon();
            Train t1 = new Train("Nice");
            w1.places[0] = v1;
            w1.places[1] = v2;
            w1.places[12] = new Voyageur("Mustapha", 27, "L545454");











            Console.ReadKey();

        }

        public static void WL( string text)
        {
            Console.WriteLine(text);
        }
    }
}
