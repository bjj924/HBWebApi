using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HBWebApi.Entities.Models.DTO
{
    [Table("Customer")]
	public class Customer
	{
		[Key]
		public int PersonID { get; set; } = 0;
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public int Age { get; set; } = 0;
		public string Occupation { get; set; } = string.Empty;
		public string MartialStatus { get; set; } = string.Empty;
	}
}