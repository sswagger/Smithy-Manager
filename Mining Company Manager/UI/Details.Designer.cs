namespace SmithyManager.UI {
	partial class FrmDetails {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			btnMines = new Button();
			btnShops = new Button();
			btnMiners = new Button();
			btnCraftsmen = new Button();
			btnMinerals = new Button();
			btnGems = new Button();
			label1 = new Label();
			btnCreate = new Button();
			btnDelete = new Button();
			btnUpdate = new Button();
			lsvDetails = new ListView();
			chxFilter = new CheckBox();
			SuspendLayout();
			// 
			// btnMines
			// 
			btnMines.BackColor = Color.SteelBlue;
			btnMines.FlatAppearance.BorderColor = Color.White;
			btnMines.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnMines.ForeColor = Color.Black;
			btnMines.Location = new Point(14, 69);
			btnMines.Margin = new Padding(5, 5, 0, 5);
			btnMines.Name = "btnMines";
			btnMines.Size = new Size(100, 50);
			btnMines.TabIndex = 1;
			btnMines.Text = "Mines";
			btnMines.UseVisualStyleBackColor = false;
			btnMines.Click += btnMines_Click;
			// 
			// btnShops
			// 
			btnShops.BackColor = Color.SteelBlue;
			btnShops.FlatAppearance.BorderColor = Color.White;
			btnShops.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnShops.ForeColor = Color.Black;
			btnShops.Location = new Point(114, 69);
			btnShops.Margin = new Padding(0, 5, 0, 5);
			btnShops.Name = "btnShops";
			btnShops.Size = new Size(100, 50);
			btnShops.TabIndex = 2;
			btnShops.Text = "Shops";
			btnShops.UseVisualStyleBackColor = false;
			btnShops.Click += btnShops_Click;
			// 
			// btnMiners
			// 
			btnMiners.BackColor = Color.SteelBlue;
			btnMiners.FlatAppearance.BorderColor = Color.White;
			btnMiners.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnMiners.ForeColor = Color.Black;
			btnMiners.Location = new Point(214, 69);
			btnMiners.Margin = new Padding(0, 5, 0, 5);
			btnMiners.Name = "btnMiners";
			btnMiners.Size = new Size(105, 50);
			btnMiners.TabIndex = 3;
			btnMiners.Text = "Miners";
			btnMiners.UseVisualStyleBackColor = false;
			btnMiners.Click += btnMiners_Click;
			// 
			// btnCraftsmen
			// 
			btnCraftsmen.BackColor = Color.SteelBlue;
			btnCraftsmen.FlatAppearance.BorderColor = Color.White;
			btnCraftsmen.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnCraftsmen.ForeColor = Color.Black;
			btnCraftsmen.Location = new Point(319, 69);
			btnCraftsmen.Margin = new Padding(0, 5, 0, 5);
			btnCraftsmen.Name = "btnCraftsmen";
			btnCraftsmen.Size = new Size(125, 50);
			btnCraftsmen.TabIndex = 4;
			btnCraftsmen.Text = "Craftsmen";
			btnCraftsmen.UseVisualStyleBackColor = false;
			btnCraftsmen.Click += btnCraftsmen_Click;
			// 
			// btnMinerals
			// 
			btnMinerals.BackColor = Color.SteelBlue;
			btnMinerals.FlatAppearance.BorderColor = Color.White;
			btnMinerals.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnMinerals.ForeColor = Color.Black;
			btnMinerals.Location = new Point(444, 69);
			btnMinerals.Margin = new Padding(0, 5, 0, 5);
			btnMinerals.Name = "btnMinerals";
			btnMinerals.Size = new Size(125, 50);
			btnMinerals.TabIndex = 5;
			btnMinerals.Text = "Minerals";
			btnMinerals.UseVisualStyleBackColor = false;
			btnMinerals.Click += btnMinerals_Click;
			// 
			// btnGems
			// 
			btnGems.BackColor = Color.SteelBlue;
			btnGems.FlatAppearance.BorderColor = Color.White;
			btnGems.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnGems.ForeColor = Color.Black;
			btnGems.Location = new Point(569, 69);
			btnGems.Margin = new Padding(0, 5, 5, 5);
			btnGems.Name = "btnGems";
			btnGems.Size = new Size(100, 50);
			btnGems.TabIndex = 6;
			btnGems.Text = "Gems";
			btnGems.UseVisualStyleBackColor = false;
			btnGems.Click += btnGems_Click;
			// 
			// label1
			// 
			label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.WhiteSmoke;
			label1.Location = new Point(14, 14);
			label1.Margin = new Padding(5);
			label1.Name = "label1";
			label1.Size = new Size(250, 50);
			label1.TabIndex = 0;
			label1.Text = "Smithy Manager";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// btnCreate
			// 
			btnCreate.BackColor = Color.SteelBlue;
			btnCreate.FlatAppearance.BorderColor = Color.White;
			btnCreate.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnCreate.ForeColor = Color.Black;
			btnCreate.Location = new Point(15, 431);
			btnCreate.Margin = new Padding(110, 5, 5, 5);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(100, 50);
			btnCreate.TabIndex = 8;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = false;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.SteelBlue;
			btnDelete.FlatAppearance.BorderColor = Color.White;
			btnDelete.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnDelete.ForeColor = Color.Black;
			btnDelete.Location = new Point(225, 431);
			btnDelete.Margin = new Padding(5, 5, 180, 5);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(100, 50);
			btnDelete.TabIndex = 10;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.SteelBlue;
			btnUpdate.FlatAppearance.BorderColor = Color.White;
			btnUpdate.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnUpdate.ForeColor = Color.Black;
			btnUpdate.Location = new Point(120, 431);
			btnUpdate.Margin = new Padding(5);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(100, 50);
			btnUpdate.TabIndex = 9;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// lsvDetails
			// 
			lsvDetails.FullRowSelect = true;
			lsvDetails.Location = new Point(15, 129);
			lsvDetails.Margin = new Padding(5);
			lsvDetails.MultiSelect = false;
			lsvDetails.Name = "lsvDetails";
			lsvDetails.Size = new Size(655, 297);
			lsvDetails.TabIndex = 7;
			lsvDetails.UseCompatibleStateImageBehavior = false;
			lsvDetails.View = View.Details;
			// 
			// chxFilter
			// 
			chxFilter.Font = new Font("Calibri", 15.75F);
			chxFilter.ForeColor = Color.WhiteSmoke;
			chxFilter.Location = new Point(520, 432);
			chxFilter.Margin = new Padding(5);
			chxFilter.Name = "chxFilter";
			chxFilter.Size = new Size(150, 50);
			chxFilter.TabIndex = 11;
			chxFilter.Text = "Filter";
			chxFilter.UseVisualStyleBackColor = true;
			chxFilter.CheckedChanged += chxFilter_CheckedChanged;
			// 
			// FrmDetails
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DimGray;
			ClientSize = new Size(684, 511);
			Controls.Add(chxFilter);
			Controls.Add(lsvDetails);
			Controls.Add(btnUpdate);
			Controls.Add(btnDelete);
			Controls.Add(btnCreate);
			Controls.Add(label1);
			Controls.Add(btnGems);
			Controls.Add(btnMinerals);
			Controls.Add(btnCraftsmen);
			Controls.Add(btnMiners);
			Controls.Add(btnShops);
			Controls.Add(btnMines);
			Name = "FrmDetails";
			Text = "DataForm";
			Load += FrmDetials_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnMines;
		private Button btnShops;
		private Button btnMiners;
		private Button btnCraftsmen;
		private Button btnMinerals;
		private Button btnGems;
		private Label label1;
		private Button btnCreate;
		private Button btnDelete;
		private Button btnUpdate;
		private ListView lsvDetails;
		private CheckBox chxFilter;
	}
}
