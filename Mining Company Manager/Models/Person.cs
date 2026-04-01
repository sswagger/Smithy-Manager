using System.ComponentModel.DataAnnotations;

namespace SmithyManager.Models {
	public abstract class Person {
		[StringLength(20)]
		public string? Name { get; set; }

		[Required]
		public required int Pay { get; set; }

		public int? Age { get; set; }
	}
}
