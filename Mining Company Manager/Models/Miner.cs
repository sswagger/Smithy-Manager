using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmithyManager.Models {
	public class Miner : Person {
		[Key]
		public int Id { get; set; }

		public int MineId { get; set; }
		[ForeignKey("MineId")]
		public Mine? Mine { get; set; }
	}
}
