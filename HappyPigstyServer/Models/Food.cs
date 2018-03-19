/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 20-Mar-18
 * Time: 01:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HappyPigstyServer.Models
{
	/// <summary>
	/// Description of Food.
	/// </summary>
	public class Food
	{
		private string sensorId;
		private float food;
		
		public Food(string sensorId, float food)
		{
			this.sensorId = sensorId;
			this.food = food;
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
	}
}
