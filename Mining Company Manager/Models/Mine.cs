using System.ComponentModel.DataAnnotations;

namespace SmithyManager.Models {
	public class Mine {
		[Key]
		public int Id { get; set; }

		[Required]
		public required int Age { get; set; }

		[Required]
		public required int Equip { get; set; }
	}
}
