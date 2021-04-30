using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer
{
	public class ValidationManager
	{
		// |
		public string ValidateForm(string name, DateTime startdate, DateTime endDate, string description)
		{
			string result = "";
			if (name == null || name == "")
			{
				result = "Name field can't be empty!";
			}
			else if (name.Contains("|"))
			{
				result = "Name field can't contain '|'";
			}
			else if (startdate.Date > endDate.Date)
			{
				result = "Start date can't be after the end date!";
			}
			else if (description.Contains("|"))
			{
				result = "Description field can't contain '|'";
			}
			if (result != "")
			{
				return result;
			}
			return null;
		}
	}
}
