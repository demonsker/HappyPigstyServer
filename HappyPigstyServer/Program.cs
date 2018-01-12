using System;
using System.Threading;
using io.netpie.microgear;

namespace HappyPigstyServer
{
    class Program
    {
        private static String AppID = "HappyPigsty";
        private static String Key = "zw0HnvDcL9VY4qA";
        private static String Secret = "BDiOw4Twn98leHH6ATHDkV7fD";
        private static Microgear microgear;

        static void Main(string[] args)
        {
            initialize();
        }

        static void initialize()
        {
            microgear = new Microgear();
            microgear.onConnect += Connect;
            microgear.onMessage += Message;
            microgear.onAbsent += Absent;
            microgear.onPresent += Present;
            microgear.onError += Error;
            microgear.onInfo += Info;
            microgear.Connect(AppID, Key, Secret);
            microgear.SetAlias("Server");
            microgear.Subscribe("/topic");
        }

        public static void Connect()
        {
            Console.WriteLine("Now I'm connecting with NETPIE");
        }

        public static void Message(string topic, string message)
        {
            Console.WriteLine(topic + " " + message);
        }

        public static void Present(string token)
        {
            Console.WriteLine(token);
        }

        public static void Absent(string token)
        {
            Console.WriteLine(token);
        }

        public static void Error(string error)
        {
            Console.WriteLine(error);
        }

        public static void Info(string info)
        {
            Console.WriteLine(info);
        }


    }
}
