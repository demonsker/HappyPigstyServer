using System;
using Newtonsoft.Json.Linq;
using HappyPigstyServer.Models;

namespace HappyPigstyServer.Utilities
{
	/// <summary>
	/// Description of Converter.
	/// </summary>
	public class Converter
	{
		public static string mapModel(String json)
		{
			JObject rss = JObject.Parse(json);
			string sensorId = (string)rss["sensorid"];
			if(sensorId == "01000101")
				return "Weight";
			else if(sensorId == "01000102")
				return "Food";
			else if(sensorId == "01000103")
				return "FoodTank";
			else
				return "Unknown";
		}
		public static Weight JsonToWeight(String json)
		{
			JObject rss = JObject.Parse(json);
			string sensorId = (string)rss["sensorid"];
			float weight = (float)rss["weight"];
			Weight obj = new Weight(sensorId, weight);
			return obj;
		}
		
		public static Food JsonToFood(String json)
		{
			JObject rss = JObject.Parse(json);
			string sensorId = (string)rss["sensorid"];
			float food = (float)rss["food"];
			Food obj = new Food(sensorId, food);
			return obj;
		}
		
		public static FoodTank JsonToFoodTank(String json)
		{
			JObject rss = JObject.Parse(json);
			string sensorId = (string)rss["sensorid"];
			float food = (float)rss["food"];
			int foodFormular = (int)rss["foodformular"];
			FoodTank obj = new FoodTank(sensorId, food, foodFormular);
			return obj;
		}
		
	}
}
