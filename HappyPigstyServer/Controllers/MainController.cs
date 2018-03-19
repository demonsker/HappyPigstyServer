using System;
using HappyPigstyServer.Utilities;
using HappyPigstyServer.Models;

namespace HappyPigstyServer.Controllers
{
	/// <summary>
	/// Description of MainController.
	/// </summary>
	public class MainController
	{
		NETPIE netPie;
    	static DBHandler dbHandler;
		
		public void start()
		{
			netPie = new NETPIE("HappyPigsty", "zw0HnvDcL9VY4qA", "BDiOw4Twn98leHH6ATHDkV7fD");
            netPie.initialize();
            netPie.getMicrogear().onMessage += Receiving;
            netPie.connect("Server");
            
            dbHandler = new DBHandler("127.0.0.1", "happy_pigsty", "root", "12345678");
		}
		
		public static void Receiving(string topic, string message)
        {            
			messageFilter(message);
        } 

		public static void messageFilter(string message)
		{
			Weight weight;
			Food food;
			FoodTank foodTank;
			
			string model = Converter.mapModel(message);
			if(model == "Weight")
			{
				weight = Converter.JsonToWeight(message);
				dbHandler.insert(weight);
				Console.Write("-> sensorid : " + weight.getSensorId());
				Console.WriteLine(" weight : " + weight.getWeight());
			}
			else if(model == "Food")
			{
				food = Converter.JsonToFood(message);
				dbHandler.insert(food);
				Console.Write("-> sensorid : " + food.getSensorId());
				Console.WriteLine(" food : " + food.getFood());
			}
			
			else if(model == "FoodTank")
			{
				foodTank = Converter.JsonToFoodTank(message);
				dbHandler.insert(foodTank);
				Console.Write("-> sensorid : " + foodTank.getSensorId());
				Console.Write(" food : " + foodTank.getFood());
				Console.WriteLine(" foodformular : " + foodTank.getFoodFormular());
			}
			
			
		}
	}
}
