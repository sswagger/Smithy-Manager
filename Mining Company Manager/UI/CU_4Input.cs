namespace SmithyManager.UI {
	public partial class CU_4Input : Form {
		//=== Attributes ===\\
		private List<string> textVals = [];
		private List<string> ids = [];
		private List<string> userVals = new List<string> { };

		//=== Constructors ===\\
		public CU_4Input() {
			InitializeComponent();
		}

		//=== Event Handlers ===\\
		public void CU_4Input_Load(object sender, EventArgs e) {
			this.label1.Text = this.textVals[0];
			this.label2.Text = this.textVals[1];
			this.label3.Text = this.textVals[2];
			this.label4.Text = this.textVals[3];
			this.label5.Text = this.textVals[4];

			this.cbxInput4.Items.Clear();
			foreach (String item in this.ids) {
				this.cbxInput4.Items.Add(item);
			}
		}
		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}
		private void btnSave_Click(object sender, EventArgs e) {
			this.userVals.Add(this.txbInput1.Text);
			this.userVals.Add(this.txbInput2.Text);
			this.userVals.Add(this.txbInput3.Text);
			if (this.cbxInput4.SelectedItem != null) {
				this.userVals.Add(this.cbxInput4.SelectedItem.ToString());
			}
			this.Close();
		}

		//=== Methods ===\\
		public List<string> getVals(List<string> textVals, List<string> ids) {
			// open form
			this.textVals = textVals;
			this.ids = ids;
			this.ShowDialog();
			return this.userVals;
		}
	}
}
