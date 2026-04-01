namespace SmithyManager.UI {
	partial class CU_4Input {
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
			label4 = new Label();
			txbInput3 = new TextBox();
			btnSave = new Button();
			btnCancel = new Button();
			label3 = new Label();
			label2 = new Label();
			txbInput2 = new TextBox();
			txbInput1 = new TextBox();
			label1 = new Label();
			label5 = new Label();
			cbxInput4 = new ComboBox();
			SuspendLayout();
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
			label4.Text = "Input 3";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txbInput3
			// 
			txbInput3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txbInput3.Location = new Point(155, 222);
			txbInput3.Margin = new Padding(20);
			txbInput3.Name = "txbInput3";
			txbInput3.Size = new Size(200, 33);
			txbInput3.TabIndex = 6;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.SteelBlue;
			btnSave.FlatAppearance.BorderColor = Color.White;
			btnSave.Font = new Font("Corbel", 15.75F, FontStyle.Bold);
			btnSave.ForeColor = Color.Black;
			btnSave.Location = new Point(260, 340);
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
			btnCancel.Location = new Point(155, 340);
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
			label3.Text = "Input 2";
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
			label2.Text = "Input 1";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txbInput2
			// 
			txbInput2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txbInput2.Location = new Point(155, 162);
			txbInput2.Margin = new Padding(20);
			txbInput2.Name = "txbInput2";
			txbInput2.Size = new Size(200, 33);
			txbInput2.TabIndex = 4;
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
			// label1
			// 
			label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(14, 14);
			label1.Margin = new Padding(5);
			label1.Name = "label1";
			label1.Size = new Size(250, 50);
			label1.TabIndex = 0;
			label1.Text = "4 Inputs";
			label1.TextAlign = ContentAlignment.MiddleLeft;
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
			label5.Text = "Input 4";
			label5.TextAlign = ContentAlignment.MiddleLeft;
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
			// CU_4Input
			// 
			AcceptButton = btnSave;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			CancelButton = btnCancel;
			ClientSize = new Size(384, 461);
			Controls.Add(cbxInput4);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(txbInput3);
			Controls.Add(btnSave);
			Controls.Add(btnCancel);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(txbInput2);
			Controls.Add(txbInput1);
			Controls.Add(label1);
			Name = "CU_4Input";
			StartPosition = FormStartPosition.CenterParent;
			Text = "4 Inputs";
			Load += CU_4Input_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
		private TextBox txbInput3;
		private Button btnSave;
		private Button btnCancel;
		private Label label3;
		private Label label2;
		private TextBox txbInput2;
		private TextBox txbInput1;
		private Label label1;
		private Label label5;
		private ComboBox cbxInput4;
	}
}