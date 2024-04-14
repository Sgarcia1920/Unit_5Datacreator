namespace Unit_5Datacreator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btncreate = new Button();
			label1 = new Label();
			txtNames = new TextBox();
			label2 = new Label();
			label3 = new Label();
			txtpaternalsurname = new TextBox();
			label4 = new Label();
			txtmothersurname = new TextBox();
			label5 = new Label();
			txtdateofbirth = new TextBox();
			SuspendLayout();
			// 
			// btncreate
			// 
			btncreate.Font = new Font("Tahoma", 12F);
			btncreate.Location = new Point(155, 372);
			btncreate.Name = "btncreate";
			btncreate.Size = new Size(113, 43);
			btncreate.TabIndex = 0;
			btncreate.Text = "Create";
			btncreate.UseVisualStyleBackColor = true;
			btncreate.Click += btncreate_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(142, 51);
			label1.Name = "label1";
			label1.Size = new Size(174, 19);
			label1.TabIndex = 1;
			label1.Text = "Creates Data Randomly";
			// 
			// txtNames
			// 
			txtNames.Font = new Font("Tahoma", 12F);
			txtNames.Location = new Point(155, 108);
			txtNames.Name = "txtNames";
			txtNames.ReadOnly = true;
			txtNames.Size = new Size(228, 27);
			txtNames.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(92, 108);
			label2.Name = "label2";
			label2.Size = new Size(57, 19);
			label2.TabIndex = 3;
			label2.Text = "Names";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F);
			label3.Location = new Point(77, 168);
			label3.Name = "label3";
			label3.Size = new Size(72, 38);
			label3.TabIndex = 5;
			label3.Text = "Paternal \r\nSurname";
			// 
			// txtpaternalsurname
			// 
			txtpaternalsurname.Font = new Font("Tahoma", 12F);
			txtpaternalsurname.Location = new Point(155, 179);
			txtpaternalsurname.Name = "txtpaternalsurname";
			txtpaternalsurname.ReadOnly = true;
			txtpaternalsurname.Size = new Size(228, 27);
			txtpaternalsurname.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F);
			label4.Location = new Point(77, 243);
			label4.Name = "label4";
			label4.Size = new Size(72, 38);
			label4.TabIndex = 7;
			label4.Text = "Mother \r\nSurname";
			// 
			// txtmothersurname
			// 
			txtmothersurname.Font = new Font("Tahoma", 12F);
			txtmothersurname.Location = new Point(155, 254);
			txtmothersurname.Name = "txtmothersurname";
			txtmothersurname.ReadOnly = true;
			txtmothersurname.Size = new Size(228, 27);
			txtmothersurname.TabIndex = 6;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 12F);
			label5.Location = new Point(77, 303);
			label5.Name = "label5";
			label5.Size = new Size(60, 38);
			label5.TabIndex = 9;
			label5.Text = "Date of\r\nBirth";
			// 
			// txtdateofbirth
			// 
			txtdateofbirth.Font = new Font("Tahoma", 12F);
			txtdateofbirth.Location = new Point(155, 314);
			txtdateofbirth.Name = "txtdateofbirth";
			txtdateofbirth.ReadOnly = true;
			txtdateofbirth.Size = new Size(228, 27);
			txtdateofbirth.TabIndex = 8;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(498, 450);
			Controls.Add(label5);
			Controls.Add(txtdateofbirth);
			Controls.Add(label4);
			Controls.Add(txtmothersurname);
			Controls.Add(label3);
			Controls.Add(txtpaternalsurname);
			Controls.Add(label2);
			Controls.Add(txtNames);
			Controls.Add(label1);
			Controls.Add(btncreate);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btncreate;
		private Label label1;
		private TextBox txtNames;
		private Label label2;
		private Label label3;
		private TextBox txtpaternalsurname;
		private Label label4;
		private TextBox txtmothersurname;
		private Label label5;
		private TextBox txtdateofbirth;
	}
}
