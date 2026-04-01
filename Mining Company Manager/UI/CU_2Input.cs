namespace SmithyManager.UI {
	public partial class CU_2Input : Form {
		//=== Attributes ===\\
		private List<string> textVals = [];
		private List<string> userVals = new List<string> { };

		//=== Constructors ===\\
		public CU_2Input() {
			InitializeComponent();
		}

		//=== Event Handlers ===\\
		private void CU_2Input_Load(object sender, EventArgs e) {
			this.label1.Text = this.textVals[0];
			this.label2.Text = this.textVals[1];
			this.label3.Text = this.textVals[2];
		}
		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}
		private void btnSave_Click(object sender, EventArgs e) {
			this.userVals.Add(this.txbInput1.Text);
			this.userVals.Add(this.txbInput2.Text);
			this.Close();
		}

		//=== Methods ===\\
		public List<string> getVals(List<String> textVals) {
			this.textVals = textVals;
			this.ShowDialog();
			return this.userVals;
		}
	}
}
