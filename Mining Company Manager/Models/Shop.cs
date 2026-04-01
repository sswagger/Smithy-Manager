using System.ComponentModel.DataAnnotations;

namespace SmithyManager.Models {
	public class Shop {
		[Key]
		public int Id { get; set; }

		[Required]
		public required int Size { get; set; }

		public string? Name { get; set; }
	}
}
