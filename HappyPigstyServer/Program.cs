using System;
using Utilities;

namespace HappyPigstyServer
{
    class Program
    {
        static void Main(string[] args)
        {
            NETPIE netPie = new NETPIE("HappyPigsty", 
                                       "zw0HnvDcL9VY4qA", 
                                       "BDiOw4Twn98leHH6ATHDkV7fD");
            netPie.initialize();
            netPie.getMicrogear().onMessage += Receiving;
            netPie.connect("Server", "/topic");
        }

        public static void Receiving(string topic, string message)
        {
            Console.WriteLine("Receiving message : " + message);
        }
    }
}
