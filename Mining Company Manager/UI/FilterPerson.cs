using Microsoft.IdentityModel.Tokens;

namespace SmithyManager.UI {
	public partial class FilterPerson : Form {
		//=== Attributes ===\\
		private string workTable = "";
		private string table = "";
		private string query = "";

		//=== Constructors ===\\
		public FilterPerson() {
			InitializeComponent();
		}
		
		//=== Event Handlers ===\\
		public void btnSave_Click(object sender, EventArgs e) {
			// build sql query based on what the user selected
			string startQuery = "SELECT * FROM " + this.table + " WHERE ";
			string whereFilter = "";

			if (!this.txbInput1.Text.IsNullOrEmpty()) {
				whereFilter += "Name LIKE \'%" + this.txbInput1.Text + "%\'";
			}
			if (this.cbxInput2.SelectedItem != null) {
				if (whereFilter != "") {
					whereFilter += " AND ";
				}
				whereFilter += "Pay BETWEEN " + (50 * this.cbxInput2.SelectedIndex) + " AND " + (50 * (this.cbxInput2.SelectedIndex + 1));
			}
			if (this.cbxInput3.SelectedItem != null) {
				if (whereFilter != "") {
					whereFilter += " AND ";
				}
				whereFilter += "Age BETWEEN " + (10 * (this.cbxInput3.SelectedIndex + 2)) + " AND " + (10 * (this.cbxInput3.SelectedIndex + 3));
			}
			if (this.cbxInput4.SelectedItem != null) {
				if (whereFilter != "") {
					whereFilter += " AND ";
				}
				whereFilter += this.workTable + "Id = " + this.cbxInput4.SelectedItem.ToString();
			}

			if (whereFilter != "") {
				this.query = startQuery + whereFilter + ";";
			}
			else {
				this.query = "SELECT * FROM " + this.table + ";";
			}
			
			// close window
			this.Close();
		}
		public void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		//=== Methods ===\\
		public string GetFilters(List<string> WorkIds, string Table, string WorkplaceTable) {
			// get the table that the person works
			this.workTable = WorkplaceTable;
			// get the current table
			this.table = Table;
			// replace text in the last textbox
			this.label5.Text = WorkplaceTable + "Id";

			// fill comboboxes
			this.cbxInput2.Items.Add("$0 - $50");
			this.cbxInput2.Items.Add("$50 - $100");
			this.cbxInput2.Items.Add("$100 - $150");
			this.cbxInput2.Items.Add("$150 - $200");
			this.cbxInput3.Items.Add("20 - 30");
			this.cbxInput3.Items.Add("30 - 40");
			this.cbxInput3.Items.Add("40 - 50");
			this.cbxInput3.Items.Add("50 - 60");
			this.cbxInput3.Items.Add("60 - 70");
			this.cbxInput3.Items.Add("70 - 80");
			this.cbxInput3.Items.Add("80 - 90");
			this.cbxInput3.Items.Add("90 - 100");
			this.cbxInput3.Items.Add("100 - 110");
			this.cbxInput3.Items.Add("110 - 120");

			// fill last combobox with the ids from the table that he works
			foreach (String item in WorkIds) {
				this.cbxInput4.Items.Add(item);
			}

			this.ShowDialog();
			return this.query;
		}
	}
}
