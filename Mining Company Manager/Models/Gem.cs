using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmithyManager.Models {
	public class Gem {
		[Key]
		public int Id { get; set; }

		[Required]
		public required GemType Type { get; set; }

		[Required]
		public required int Amount { get; set; }

		[Required]
		public required int Cost { get; set; }

		public int MinerId { get; set; }
		[ForeignKey("MinerId")]
		public Miner? Miner { get; set; }

		public int ShopId { get; set; }
		[ForeignKey("ShopId")]
		public Shop? Shop { get; set; }
	}
}
