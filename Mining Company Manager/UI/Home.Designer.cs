namespace SmithyManager.UI {
	partial class FrmHome {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			label1 = new Label();
			btnGems = new Button();
			btnMinerals = new Button();
			btnCraftsmen = new Button();
			btnMiners = new Button();
			btnShops = new Button();
			btnMines = new Button();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			tmrCalc = new System.Windows.Forms.Timer(components);
			btnSummary = new Button();
			tmrHazzard = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// label1
			// 
			label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.WhiteSmoke;
			label1.Location = new Point(20, 23);
			label1.Margin = new Padding(7, 8, 7, 8);
			label1.Name = "label1";
			label1.Size = new Size(357, 83);
			label1.TabIndex = 0;
			label1.Text = "Smithy Manager";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnGems
			// 
			btnGems.BackColor = Color.SteelBlue;
			btnGems.FlatAppearance.BorderColor = Color.White;
			btnGems.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnGems.ForeColor = Color.Black;
			btnGems.Location = new Point(813, 123);
			btnGems.Margin = new Padding(0, 8, 7, 8);
			btnGems.Name = "btnGems";
			btnGems.Size = new Size(143, 83);
			btnGems.TabIndex = 6;
			btnGems.Text = "Gems";
			btnGems.UseVisualStyleBackColor = false;
			btnGems.Click += btnGems_Click;
			// 
			// btnMinerals
			// 
			btnMinerals.BackColor = Color.SteelBlue;
			btnMinerals.FlatAppearance.BorderColor = Color.White;
			btnMinerals.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnMinerals.ForeColor = Color.Black;
			btnMinerals.Location = new Point(634, 123);
			btnMinerals.Margin = new Padding(0, 8, 0, 8);
			btnMinerals.Name = "btnMinerals";
			btnMinerals.Size = new Size(179, 83);
			btnMinerals.TabIndex = 5;
			btnMinerals.Text = "Minerals";
			btnMinerals.UseVisualStyleBackColor = false;
			btnMinerals.Click += btnMinerals_Click;
			// 
			// btnCraftsmen
			// 
			btnCraftsmen.BackColor = Color.SteelBlue;
			btnCraftsmen.FlatAppearance.BorderColor = Color.White;
			btnCraftsmen.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnCraftsmen.ForeColor = Color.Black;
			btnCraftsmen.Location = new Point(456, 123);
			btnCraftsmen.Margin = new Padding(0, 8, 0, 8);
			btnCraftsmen.Name = "btnCraftsmen";
			btnCraftsmen.Size = new Size(179, 83);
			btnCraftsmen.TabIndex = 4;
			btnCraftsmen.Text = "Craftsmen";
			btnCraftsmen.UseVisualStyleBackColor = false;
			btnCraftsmen.Click += btnCraftsmen_Click;
			// 
			// btnMiners
			// 
			btnMiners.BackColor = Color.SteelBlue;
			btnMiners.FlatAppearance.BorderColor = Color.White;
			btnMiners.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnMiners.ForeColor = Color.Black;
			btnMiners.Location = new Point(306, 123);
			btnMiners.Margin = new Padding(0, 8, 0, 8);
			btnMiners.Name = "btnMiners";
			btnMiners.Size = new Size(150, 83);
			btnMiners.TabIndex = 3;
			btnMiners.Text = "Miners";
			btnMiners.UseVisualStyleBackColor = false;
			btnMiners.Click += btnMiners_Click;
			// 
			// btnShops
			// 
			btnShops.BackColor = Color.SteelBlue;
			btnShops.FlatAppearance.BorderColor = Color.White;
			btnShops.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnShops.ForeColor = Color.Black;
			btnShops.Location = new Point(163, 123);
			btnShops.Margin = new Padding(0, 8, 0, 8);
			btnShops.Name = "btnShops";
			btnShops.Size = new Size(143, 83);
			btnShops.TabIndex = 2;
			btnShops.Text = "Shops";
			btnShops.UseVisualStyleBackColor = false;
			btnShops.Click += btnShops_Click;
			// 
			// btnMines
			// 
			btnMines.BackColor = Color.SteelBlue;
			btnMines.FlatAppearance.BorderColor = Color.White;
			btnMines.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnMines.ForeColor = Color.Black;
			btnMines.Location = new Point(20, 123);
			btnMines.Margin = new Padding(7, 8, 0, 8);
			btnMines.Name = "btnMines";
			btnMines.Size = new Size(143, 83);
			btnMines.TabIndex = 1;
			btnMines.Text = "Mines";
			btnMines.UseVisualStyleBackColor = false;
			btnMines.Click += btnMines_Click;
			// 
			// label2
			// 
			label2.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.WhiteSmoke;
			label2.Location = new Point(41, 248);
			label2.Margin = new Padding(29, 33, 29, 33);
			label2.Name = "label2";
			label2.Size = new Size(436, 83);
			label2.TabIndex = 7;
			label2.Text = "Profit (per 5 seconds)";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			label3.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.WhiteSmoke;
			label3.Location = new Point(41, 348);
			label3.Margin = new Padding(29, 33, 29, 33);
			label3.Name = "label3";
			label3.Size = new Size(357, 83);
			label3.TabIndex = 9;
			label3.Text = "Total Money";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox1.Location = new Point(650, 270);
			textBox1.Margin = new Padding(29, 33, 29, 33);
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new Size(284, 46);
			textBox1.TabIndex = 8;
			textBox1.Text = "0";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox2.Location = new Point(650, 370);
			textBox2.Margin = new Padding(29, 33, 29, 33);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(284, 46);
			textBox2.TabIndex = 10;
			textBox2.Text = "0";
			// 
			// tmrCalc
			// 
			tmrCalc.Enabled = true;
			tmrCalc.Interval = 5000;
			tmrCalc.Tick += tmrCalc_Tick;
			// 
			// btnSummary
			// 
			btnSummary.BackColor = Color.SteelBlue;
			btnSummary.FlatAppearance.BorderColor = Color.White;
			btnSummary.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnSummary.ForeColor = Color.Black;
			btnSummary.Location = new Point(20, 745);
			btnSummary.Margin = new Padding(7, 8, 0, 8);
			btnSummary.Name = "btnSummary";
			btnSummary.Size = new Size(936, 83);
			btnSummary.TabIndex = 11;
			btnSummary.Text = "Summary";
			btnSummary.UseVisualStyleBackColor = false;
			btnSummary.Click += btnSummary_Click;
			// 
			// tmrHazzard
			// 
			tmrHazzard.Enabled = true;
			tmrHazzard.Interval = 8833;
			tmrHazzard.Tick += tmrHazzard_Tick;
			// 
			// FrmHome
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DimGray;
			ClientSize = new Size(977, 852);
			Controls.Add(btnSummary);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(btnGems);
			Controls.Add(btnMinerals);
			Controls.Add(btnCraftsmen);
			Controls.Add(btnMiners);
			Controls.Add(btnShops);
			Controls.Add(btnMines);
			Controls.Add(label1);
			Margin = new Padding(4, 5, 4, 5);
			Name = "FrmHome";
			Text = "HomeForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnGems;
		private Button btnMinerals;
		private Button btnCraftsmen;
		private Button btnMiners;
		private Button btnShops;
		private Button btnMines;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox textBox2;
		private System.Windows.Forms.Timer tmrCalc;
		private Button btnSummary;
		private System.Windows.Forms.Timer tmrHazzard;
	}
}