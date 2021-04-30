using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Freelancer.Entities
{
	public class CustomerManager
	{
		public List<Customer> customers = new List<Customer>();
		LogManager logManager = new LogManager();

		public void Add(Customer customer)
		{
			try
			{
				logManager.LogInfo("Cusomer Added: " + customer.ToString());
				customers.Add(customer);
				using (StreamWriter sw = File.AppendText("data.txt"))
				{
					string line = getCustomerLine(customer.getValues());
					sw.WriteLine(line);
				}
			}
			catch(Exception e)
			{
				logManager.LogInfo(e.ToString());
				logManager.LogMessageBox(e.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
			
		}

		public void Add(List<Customer> customersList)
		{
			try
			{
				foreach (var customer in customersList)
				{
					logManager.LogInfo("Cusomer Added: " + customer.ToString());
				}
				customers.AddRange(customers);
			}
			catch(Exception e)
			{
				logManager.LogInfo(e.ToString());
				logManager.LogMessageBox(e.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

			}

		}

		public void Delete(int id)
		{
			try
			{
				Customer customer = customers.Find(c => c.Id == id);
				if (customer == null || id == -1)
				{
					logManager.LogMessageBox("Please choose a customer to delete!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
					return;
				}
				logManager.LogInfo("Cusomer Deleted: " + customer.ToString());
				customers.Remove(customer);
				int lineIndex = FindLineIndex(id);
				List<string> lines = File.ReadAllLines("data.txt").ToList();
				lines.RemoveAt(lineIndex);
				File.WriteAllLines("data.txt", lines.ToArray());
			}
			catch (Exception e)
			{
				logManager.LogError(e.ToString());
				logManager.LogMessageBox(e.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

			}
		}

		public void Update(int id, Customer newCustomer)
		{
			try
			{
				Customer customer = customers[customers.IndexOf(customers.Find(c => c.Id == id))];
				customer.Name = newCustomer.Name;
				customer.Price = newCustomer.Price;
				customer.StartDate = newCustomer.StartDate;
				customer.EndDate = newCustomer.EndDate;
				customer.Description = newCustomer.Description;
				customer.Finished = newCustomer.Finished;
				int lineIndex = FindLineIndex(id);
				string newText = getCustomerLine(customer.getValues());
				string[] lines = File.ReadAllLines("data.txt");
				lines[lineIndex] = newText;
				File.WriteAllLines("data.txt", lines);
				logManager.LogInfo("Cusomer Update: " + newCustomer.ToString());
			}
			catch(Exception e)
			{
				logManager.LogError(e.ToString());
				logManager.LogMessageBox(e.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

			}

		}

		public Customer Find(int id)
		{
			try
			{
				Customer customer = customers.Find(c => c.Id == id);
				return customer;
			}
			catch
			{
				logManager.LogMessageBox("No Customer Found", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
			return null;
		}

		public int FindLineIndex(int id)
		{
			try
			{
				string[] lines = File.ReadAllLines("data.txt");
				
				for (int i = 0; i < lines.Length; i++)
				{
					string[] _line = lines[i].Split('|');
					if (Convert.ToInt32(_line[0]) == id)
					{
						return i;
					}
				}
			}
			catch(Exception e)
			{
				logManager.LogError(e.ToString());
				logManager.LogMessageBox(e.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
			return -1;
		}

		public int getCurrentId()
		{
			int currentId = 0;
			if (customers.Count > 0)
			{
				currentId = customers[customers.Count - 1].Id+1;
			}
			else
			{
				currentId = 1;
			}
			return currentId;
		}

		private string getCustomerLine(dynamic[] values)
		{
			string line = "";
			for (int i = 0; i < values.Length; i++)
			{
				line += values[i].ToString();
				if (i != values.Length - 1)
				{
					line += "|";
				}
			}
			return line;
		}
	}
}
