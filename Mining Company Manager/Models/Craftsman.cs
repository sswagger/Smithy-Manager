using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmithyManager.Models {
	public class Craftsman : Person {
		[Key]
		public int Id { get; set; }

		public int ShopId { get; set; }
		[ForeignKey("ShopId")]
		public Shop? Shop { get; set; }
	}
}
