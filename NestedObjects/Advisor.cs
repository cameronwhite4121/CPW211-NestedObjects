using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
	/// <summary>
	/// Represents a college advisor
	/// </summary>
	public class Advisor
	{
		/// <summary>
		/// Advisors name in the format - First, Last name.
		/// </summary>
		public string FullName { get; set; }
		/// <summary>
		/// Advisors work email.
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Which building and room number
		/// </summary>
		public string OfficeLocation { get; set; }
		

	}
}
