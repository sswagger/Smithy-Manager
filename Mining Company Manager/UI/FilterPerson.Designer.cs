namespace SmithyManager.UI {
	partial class FilterPerson {
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
			cbxInput4 = new ComboBox();
			label5 = new Label();
			label4 = new Label();
			btnSave = new Button();
			btnCancel = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			cbxInput3 = new ComboBox();
			cbxInput2 = new ComboBox();
			txbInput1 = new TextBox();
			SuspendLayout();
			// 
			// cbxInput4
			// 
			cbxInput4.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxInput4.Font = new Font("Calibri", 15.75F);
			cbxInput4.FormattingEnabled = true;
			cbxInput4.Location = new Point(155, 278);
			cbxInput4.Name = "cbxInput4";
			cbxInput4.Size = new Size(200, 34);
			cbxInput4.TabIndex = 8;
			// 
			// label5
			// 
			label5.Font = new Font("Calibri", 24F);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(14, 269);
			label5.Margin = new Padding(5);
			label5.Name = "label5";
			label5.Size = new Size(116, 50);
			label5.TabIndex = 7;
			label5.Text = "PlaceId";
			label5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			label4.Font = new Font("Calibri", 24F);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(14, 209);
			label4.Margin = new Padding(5);
			label4.Name = "label4";
			label4.Size = new Size(116, 50);
			label4.TabIndex = 5;
			label4.Text = "Age";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.SteelBlue;
			btnSave.FlatAppearance.BorderColor = Color.White;
			btnSave.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnSave.ForeColor = Color.Black;
			btnSave.Location = new Point(265, 320);
			btnSave.Margin = new Padding(5);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(100, 50);
			btnSave.TabIndex = 10;
			btnSave.Text = "&Save";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.SteelBlue;
			btnCancel.FlatAppearance.BorderColor = Color.White;
			btnCancel.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnCancel.ForeColor = Color.Black;
			btnCancel.Location = new Point(155, 320);
			btnCancel.Margin = new Padding(5);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(100, 50);
			btnCancel.TabIndex = 9;
			btnCancel.Text = "&Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// label3
			// 
			label3.Font = new Font("Calibri", 24F);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(14, 149);
			label3.Margin = new Padding(5);
			label3.Name = "label3";
			label3.Size = new Size(116, 50);
			label3.TabIndex = 3;
			label3.Text = "Pay";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			label2.Font = new Font("Calibri", 24F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(14, 89);
			label2.Margin = new Padding(5);
			label2.Name = "label2";
			label2.Size = new Size(116, 50);
			label2.TabIndex = 1;
			label2.Text = "Name";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(14, 14);
			label1.Margin = new Padding(5);
			label1.Name = "label1";
			label1.Size = new Size(250, 50);
			label1.TabIndex = 0;
			label1.Text = "Person Filter";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// cbxInput3
			// 
			cbxInput3.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxInput3.Font = new Font("Calibri", 15.75F);
			cbxInput3.FormattingEnabled = true;
			cbxInput3.Location = new Point(155, 222);
			cbxInput3.Name = "cbxInput3";
			cbxInput3.Size = new Size(200, 34);
			cbxInput3.TabIndex = 6;
			// 
			// cbxInput2
			// 
			cbxInput2.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxInput2.Font = new Font("Calibri", 15.75F);
			cbxInput2.FormattingEnabled = true;
			cbxInput2.Location = new Point(155, 162);
			cbxInput2.Name = "cbxInput2";
			cbxInput2.Size = new Size(200, 34);
			cbxInput2.TabIndex = 4;
			// 
			// txbInput1
			// 
			txbInput1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txbInput1.Location = new Point(155, 102);
			txbInput1.Margin = new Padding(20);
			txbInput1.Name = "txbInput1";
			txbInput1.Size = new Size(200, 33);
			txbInput1.TabIndex = 2;
			// 
			// FilterPerson
			// 
			AcceptButton = btnSave;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(384, 461);
			Controls.Add(txbInput1);
			Controls.Add(cbxInput2);
			Controls.Add(cbxInput3);
			Controls.Add(cbxInput4);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(btnSave);
			Controls.Add(btnCancel);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FilterPerson";
			Text = "Filter";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbxInput4;
		private Label label5;
		private Label label4;
		private Button btnSave;
		private Button btnCancel;
		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox cbxInput3;
		private ComboBox cbxInput2;
		private TextBox txbInput1;
	}
}