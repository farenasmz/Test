using System.ComponentModel.DataAnnotations;

namespace Infraestructure.Models
{
	public class Product
	{
		[Key]
		public int ProductID { get; set; }		
		public string Description { get; set; }
	}
}
