using SmithyManager.Data;

namespace SmithyManager.UI {
	public partial class FrmSummary : Form {
		//=== Attributes ===\\
		private readonly MinesDB mineDB = new();
		private readonly ShopsDB shopDB = new();
		private readonly MinersDB minerDB = new();
		private readonly CraftsmenDB craftsmanDB = new();
		private readonly MineralsDB mineralDB = new();
		private readonly GemsDB gemDB = new();

		//=== Constructors ===\\
		public FrmSummary() {
			InitializeComponent();
		}

		//=== Event Handlers ===\\
		private void FrmSummary_Load(object sender, EventArgs e) {
			FillBoxes();
		}
		private void btnSave_Click(object sender, EventArgs e) {
			this.Close();
		}
		private void btnRefresh_Click(object sender, EventArgs e) {
			FillBoxes();
		}

		//=== Methods ===\\
		private void FillBoxes() {
			// fill textboxes
			this.txbInput1.Text = mineDB.GetMines().Count.ToString();
			this.txbInput2.Text = shopDB.GetShops().Count.ToString();
			this.txbInput3.Text = minerDB.GetMiners().Count.ToString();
			this.txbInput4.Text = craftsmanDB.GetCraftsmen().Count.ToString();
			this.txbInput5.Text = mineralDB.GetMinerals().Count.ToString();
			this.txbInput6.Text = gemDB.GetGems().Count.ToString();
		}
	}
}
