/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 20-Mar-18
 * Time: 01:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HappyPigstyServer.Models
{
	/// <summary>
	/// Description of FoodTank.
	/// </summary>
	public class FoodTank
	{
		private string sensorId;
		private float food;
		private int foodFormular;
		
		public FoodTank(string sensorId, float food, int foodFormular)
		{
			this.sensorId = sensorId;
			this.food = food;
			this.foodFormular = foodFormular;
		}
		
		public void setSensorId(string sensorId)
		{
			this.sensorId = sensorId;
		}
		
		public string getSensorId()
		{
			return sensorId;
		}		
		
		public void setFood(float food)
		{
			this.food = food;
		}
		
		public float getFood()
		{
			return food;
		}
		
		public void setFoodFormular(int foodFormular)
		{
			this.foodFormular = foodFormular;
		}
		
		public int getFoodFormular()
		{
			return foodFormular;
		}
		
	}
}
