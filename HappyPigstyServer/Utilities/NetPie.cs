using System;
using io.netpie.microgear;
using System.Threading;

namespace Utilities
{
    class NETPIE
    {
        private String AppID;
        private String Key;
        private String Secret;
        private static Microgear microgear;

        public NETPIE(String _AppID, String _Key, String _Secret)
        {
            AppID = _AppID;
            Key = _Key;
            Secret = _Secret;
        }

        public void initialize()
        {
            microgear = new Microgear();
            microgear.onConnect += Connect;
            microgear.onAbsent += Absent;
            microgear.onPresent += Present;
            microgear.onError += Error;
            microgear.onInfo += Info;
        }

        public Microgear getMicrogear()
        {
            return microgear;
        }

        public void connect(String Alias, String Subscribe)
        {
            Console.WriteLine("Connecting to NETPIE....");
            microgear.Connect(AppID, Key, Secret);
            microgear.SetAlias(Alias);
            microgear.Subscribe(Subscribe);
        }

        public static void Connect()
        {
            Console.WriteLine("Connected!");
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
