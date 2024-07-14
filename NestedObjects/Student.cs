using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
	/// <summary>
	/// Represents an individual college studentS
	/// </summary>
	public class Student
	{
		/// <summary>
		/// Legal first name
		/// </summary>
		public string FirstName { get; set; }
		/// <summary>
		/// Legal last name
		/// </summary>
		public string LastName { get; set; }
		/// <summary>
		/// Gets first name and last name concatonated together
		/// </summary>
		public string FullName
		{
			get { return FirstName + " " + LastName; }
		}
		/// <summary>
		/// The students school email
		/// </summary>
		public string SchoolEmail { get; set; }
		/// <summary>
		/// Student's personal phone number
		/// </summary>
		public string PhoneNumber { get; set; }
	}
}
