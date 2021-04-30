using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelancer.Entities
{
	public class Customer
	{
		public Customer(int id,string name, float price, DateTime startDate, DateTime endDate, string description, bool finished)
		{
			Id = id;
			Name = name;
			Price = price;
			StartDate = startDate;
			EndDate = endDate;
			Description = description;
			Finished = finished;
		}

		public Customer() { }

		public int Id { get; set; }
		public string Name { get; set; }
		public float Price { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Description { get; set; }
		public bool Finished { get; set; }

		public override string ToString()
		{
			string result = $"[Id: {Id}] [Name: {Name}] [Price: {Price}] [StartDate: {StartDate}] [EndDate: {EndDate}] [Description: {Description}] [Finished: {Finished}]";
			return result;
		}

		public dynamic[] getValues()
		{
			dynamic[] values = { Id, Name, Price, StartDate, EndDate, Description, Finished };
			return values;
		}

		public Dictionary<String, dynamic> ToDict()
		{
			Dictionary<String, dynamic> result = new Dictionary<string, dynamic>();
			result.Add("Id",Id);
			result.Add("Name",Name);
			result.Add("Prie",Price);
			result.Add("StartDate",StartDate);
			result.Add("EndDate",EndDate);
			result.Add("Description",Description);
			result.Add("Finished",Finished);
			return result;
		}
	}

}
