using System;
using MySql.Data.MySqlClient;
using HappyPigstyServer.Models;

namespace HappyPigstyServer.Utilities
{
	/// <summary>
	/// Description of DBHandler.
	/// </summary>
	public class DBHandler
	{
		private string host;
		private string database;
		private string user;
		private string password;
		
		MySqlConnection connection;
	    MySqlCommand command;
		
		public DBHandler(string host, string database, string user, string password)
		{
			this.host = host;
			this.database = database;
			this.user = user;
			this.password = password;
			
			string url = "server="+host+";" ;
			url += "database="+database+";" ;
			url += "uid="+user+";" ;
			url += "pwd="+password+";" ;
			connection = new MySqlConnection(url);
		}
		
		private Boolean connect()
		{
			try
			{
				connection.Open();
				return true;
			}
		 	catch(Exception e) 
		 	{ 
		 		Console.WriteLine("Connection Fail : "+ e); 
		 		return false;
		 	}
		}
		
		public bool insert(Weight weight){
			if(!connect()) 
				return false;
			
		   String query = "INSERT INTO weight VALUES ( @sensorid, @weight, CURRENT_TIMESTAMP)";
		   command = new MySqlCommand(query, connection);
		   command.Parameters.AddWithValue("@sensorid", weight.getSensorId());
		   command.Parameters.AddWithValue("@weight", weight.getWeight());
		   command.ExecuteNonQuery();
		   connection.Close();
		   return true;
		}
		
		public bool insert(Food food){
			if(!connect()) 
				return false;
			
		   String query = "INSERT INTO food VALUES ( @sensorid, @eat, CURRENT_TIMESTAMP)";
		   command = new MySqlCommand(query, connection);
		   command.Parameters.AddWithValue("@sensorid", food.getSensorId());
		   command.Parameters.AddWithValue("@eat", food.getFood());
		   command.ExecuteNonQuery();
		   connection.Close();
		   return true;
		}
		
		public bool insert(FoodTank foodTank){
			if(!connect()) 
				return false;
			
		   String query = "INSERT INTO foodtank VALUES ( @sensorid, @food, @foodFormular, CURRENT_TIMESTAMP)";
		   command = new MySqlCommand(query, connection);
		   command.Parameters.AddWithValue("@sensorid", foodTank.getSensorId());
		   command.Parameters.AddWithValue("@food", foodTank.getFood());
		   command.Parameters.AddWithValue("@foodFormular", foodTank.getFoodFormular());
		   command.ExecuteNonQuery();
		   connection.Close();
		   return true;
		}
	}
}
