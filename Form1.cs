using Freelancer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Freelancer
{
	public enum PanelState
	{
		ListView,
		Add,
		Update
	}

	public partial class Form1 : Form
	{
		CustomerManager customerManager = new CustomerManager();
		LogManager logManager = new LogManager();
		ValidationManager validationManager = new ValidationManager();
		PanelState panelState = PanelState.ListView;
		int selectedCustomerId = -1;
		public Form1()
		{
			InitializeComponent();
			listView.Visible = true;
			panel.Visible = false;

			if (!File.Exists("data.txt"))
			{
				File.Create("data.txt").Close();
			}
			getData();
		}

		private void getData()
		{
			string[] lines = File.ReadAllLines("data.txt");

			foreach (string _line in lines)
			{
				string[] line = _line.Split('|');
				Customer customer = new Customer();
				customer.Id = Convert.ToInt32(line[0]);
				customer.Name = Convert.ToString(line[1]);
				customer.Price = float.Parse(line[2]);
				customer.StartDate = Convert.ToDateTime(line[3]);
				customer.EndDate = Convert.ToDateTime(line[4]);
				customer.Description = Convert.ToString(line[5]);
				customer.Finished = Convert.ToBoolean(line[6]);
				customerManager.customers.Add(customer);
			}
			updateListView();
		}

		//Add
		private void button1_Click(object sender, EventArgs e)
		{
			changePanel(PanelState.Add);
		}

		//Update
		private void button2_Click(object sender, EventArgs e)
		{
			if (selectedCustomerId == -1)
			{
				logManager.LogMessageBox("Please choose a customer to update!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				return;
			}
			changePanel(PanelState.Update);
		}

		//Delete
		private void button3_Click(object sender, EventArgs e)
		{
			if (selectedCustomerId == -1)
			{
				logManager.LogMessageBox("Please choose a customer to delete!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				return;
			}
			customerManager.Delete(selectedCustomerId);
			updateListView();
		}

		public void updateListView()
		{
			listView.Items.Clear();
			List<Customer> customers = customerManager.customers;
			foreach (var customer in customers)
			{
				ListViewItem lv = new ListViewItem();
				dynamic[] values = customer.getValues();
				
				lv.Text = values[0].ToString();
				for (int i = 1; i < values.Length; i++)
				{

					string addText = "";
					try
					{
						if (values[i] == true)
						{
							addText = "✓";
						}
						else
						{
							addText = "X";
						}
					}
					catch
					{
						addText = Convert.ToString(values[i]);
					}

					lv.SubItems.Add(addText);
				}
				listView.Items.Add(lv);
			}
		}


		private void changePanel(PanelState state)
		{
			panelState = state;
			if (panelState == PanelState.ListView)
			{
				clearForm();
				panel.Visible = false;
				listView.Visible = true;
			}
			else if (panelState == PanelState.Add)
			{
				panel.Visible = true;
				header.Text = "Customer Add";
				listView.Visible = false;
			}
			else if (panelState == PanelState.Update)
			{
				panel.Visible = true;
				header.Text = "Customer Update";
				listView.Visible = false;
				Customer customer = customerManager.Find(selectedCustomerId);
				if (customer != null)
				{
					name_box.Text = customer.Name;
					price_box.Value = (decimal)customer.Price;
					startdate_box.Value = customer.StartDate;
					enddate_box.Value = customer.EndDate;
					description_box.Text = customer.Description;
					finished_box.Checked = customer.Finished;
				}

			}
		}

		private void clearForm()
		{
			name_box.Clear();
			price_box.Value = 0;
			startdate_box.Value = DateTime.Now;
			enddate_box.Value = DateTime.Now;
			description_box.Clear();
			finished_box.Checked = false;
		}

		private void back_Click(object sender, EventArgs e)
		{
			listView.Visible = true;
			panel.Visible = false;
		}

		private void save_Click(object sender, EventArgs e)
		{
			string name_value = name_box.Text;
			float price_value = (float)price_box.Value;
			DateTime start_date_value = startdate_box.Value;
			DateTime end_date_value = enddate_box.Value;
			string description_value = description_box.Text;
			bool finished_value = finished_box.Checked;
			string result = validationManager.ValidateForm(name_value, start_date_value, end_date_value, description_value);
			if (result != null)
			{
				logManager.LogMessageBox(result, "Invalid Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
				
			Customer customer = new Customer(customerManager.getCurrentId(),name_value, price_value, start_date_value, end_date_value, description_value, finished_value);
			if (panelState == PanelState.Add) 
			{ 
				customerManager.Add(customer);
			}
			else if (panelState == PanelState.Update)
			{
				customerManager.Update(selectedCustomerId, customer);
			}
			updateListView();
			changePanel(PanelState.ListView);
		}


		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				var selectedItems = listView.SelectedItems;
				for (int i = 0; i < selectedItems.Count; i++)
				{
					selectedCustomerId = Convert.ToInt32(selectedItems[i].SubItems[0].Text);
				}
			}
			catch
			{
				selectedCustomerId = -1;
			}
			
		}

		private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listView.SelectedItems.Count > 0)
			{
				if (selectedCustomerId == -1)
				{
					logManager.LogMessageBox("Please choose a customer to update!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
					return;
				}
				changePanel(PanelState.Update);
			}
			
		}
	}
}















/*INIT
header.Parent = panel;
name_title.Parent = panel;
name_box.Parent = panel;
price_title.Parent = panel;
price_box.Parent = panel;
startdate_title.Parent = panel;
startdate_box.Parent = panel;
enddate_title.Parent = panel;
enddate_box.Parent = panel;
description_title.Parent = panel;
description_box.Parent = panel;
save.Parent = panel;
back_button.Parent = panel;
finished_box.Parent = panel;
*/







/*ADD
Customer customer = new Customer("Latif", 10, DateTime.Now, DateTime.Now, "Bruh", false);
customerManager.Add(customer);

dynamic[] values = customer.getValues();
ListViewItem lv = new ListViewItem();
lv.Text = values[0].ToString();
lv.Checked = false;
values = values.Skip(1).ToArray();
foreach (var value in values)
{
	lv.SubItems.Add(Convert.ToString(value));
}
listView.Items.Add(lv);
*/
