using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace PersonalFinanceManager.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string? email { get; set; }

		[Required]
		public string? password { get; set; }

		[Required]
		public string? name { get; set; }
	}
}