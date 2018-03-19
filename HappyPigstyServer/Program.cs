using System;
using HappyPigstyServer.Controllers;

namespace HappyPigstyServer
{
    class Program
    {
    	
    	static void Main(string[] args)
        {
    		MainController main = new MainController();
    		main.start();
        }
        
    }
}
