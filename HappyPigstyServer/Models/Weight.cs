/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 19-Mar-18
 * Time: 23:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HappyPigstyServer.Models
{
	/// <summary>
	/// Description of Weight.
	/// </summary>
	public class Weight
	{
		private string sensorId;
		private float weight;
		
		public Weight(string sensorId, float weight)
		{
			this.sensorId = sensorId;
			this.weight = weight;
		}
		
		public void setSensorId(string sensorId)
		{
			this.sensorId = sensorId;
		}
		
		public string getSensorId()
		{
			return sensorId;
		}		
		
		public void setWeight(float weight)
		{
			this.weight = weight;
		}
		
		public float getWeight()
		{
			return weight;
		}
		
	}
}
