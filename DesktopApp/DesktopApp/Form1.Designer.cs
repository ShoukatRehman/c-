namespace DesktopApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_FirstValue = new System.Windows.Forms.TextBox();
			this.txt_SecondValue = new System.Windows.Forms.TextBox();
			this.txt_Answer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmb_Choice = new System.Windows.Forms.ComboBox();
			this.btn_calculate = new System.Windows.Forms.Button();
			this.lbl_Errors = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(312, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter first value";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(312, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Second value";
			// 
			// txt_FirstValue
			// 
			this.txt_FirstValue.Location = new System.Drawing.Point(443, 138);
			this.txt_FirstValue.Name = "txt_FirstValue";
			this.txt_FirstValue.Size = new System.Drawing.Size(121, 20);
			this.txt_FirstValue.TabIndex = 1;
			// 
			// txt_SecondValue
			// 
			this.txt_SecondValue.Location = new System.Drawing.Point(443, 183);
			this.txt_SecondValue.Name = "txt_SecondValue";
			this.txt_SecondValue.Size = new System.Drawing.Size(121, 20);
			this.txt_SecondValue.TabIndex = 2;
			// 
			// txt_Answer
			// 
			this.txt_Answer.Location = new System.Drawing.Point(443, 270);
			this.txt_Answer.Name = "txt_Answer";
			this.txt_Answer.ReadOnly = true;
			this.txt_Answer.Size = new System.Drawing.Size(121, 20);
			this.txt_Answer.TabIndex = 6;
			this.txt_Answer.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(312, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Answer";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(766, 87);
			this.panel1.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(311, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "CALCULATOR";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 415);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(766, 84);
			this.panel2.TabIndex = 8;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 93);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(228, 237);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(312, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Choice";
			// 
			// cmb_Choice
			// 
			this.cmb_Choice.FormattingEnabled = true;
			this.cmb_Choice.Items.AddRange(new object[] {
            "Multiply",
            "Divide",
            "Addition",
            "Subtraction"});
			this.cmb_Choice.Location = new System.Drawing.Point(443, 224);
			this.cmb_Choice.Name = "cmb_Choice";
			this.cmb_Choice.Size = new System.Drawing.Size(121, 21);
			this.cmb_Choice.TabIndex = 3;
			// 
			// btn_calculate
			// 
			this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_calculate.Image = ((System.Drawing.Image)(resources.GetObject("btn_calculate.Image")));
			this.btn_calculate.Location = new System.Drawing.Point(510, 329);
			this.btn_calculate.Name = "btn_calculate";
			this.btn_calculate.Size = new System.Drawing.Size(152, 60);
			this.btn_calculate.TabIndex = 4;
			this.btn_calculate.Text = "Calculate";
			this.btn_calculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_calculate.UseVisualStyleBackColor = true;
			this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
			// 
			// lbl_Errors
			// 
			this.lbl_Errors.AutoSize = true;
			this.lbl_Errors.ForeColor = System.Drawing.Color.Red;
			this.lbl_Errors.Location = new System.Drawing.Point(26, 376);
			this.lbl_Errors.Name = "lbl_Errors";
			this.lbl_Errors.Size = new System.Drawing.Size(0, 13);
			this.lbl_Errors.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 499);
			this.Controls.Add(this.lbl_Errors);
			this.Controls.Add(this.btn_calculate);
			this.Controls.Add(this.cmb_Choice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txt_Answer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_SecondValue);
			this.Controls.Add(this.txt_FirstValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CALCULATOR";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_FirstValue;
		private System.Windows.Forms.TextBox txt_SecondValue;
		private System.Windows.Forms.TextBox txt_Answer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmb_Choice;
		private System.Windows.Forms.Button btn_calculate;
		private System.Windows.Forms.Label lbl_Errors;
	}
}

