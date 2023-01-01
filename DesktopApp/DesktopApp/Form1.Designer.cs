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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_FirstValue = new System.Windows.Forms.TextBox();
			this.txt_SecondValue = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_Answer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Divide = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter first value";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Second value";
			// 
			// txt_FirstValue
			// 
			this.txt_FirstValue.Location = new System.Drawing.Point(161, 59);
			this.txt_FirstValue.Name = "txt_FirstValue";
			this.txt_FirstValue.Size = new System.Drawing.Size(100, 20);
			this.txt_FirstValue.TabIndex = 2;
			// 
			// txt_SecondValue
			// 
			this.txt_SecondValue.Location = new System.Drawing.Point(161, 117);
			this.txt_SecondValue.Name = "txt_SecondValue";
			this.txt_SecondValue.Size = new System.Drawing.Size(100, 20);
			this.txt_SecondValue.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(173, 161);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Multiply";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt_Answer
			// 
			this.txt_Answer.Location = new System.Drawing.Point(161, 201);
			this.txt_Answer.Name = "txt_Answer";
			this.txt_Answer.Size = new System.Drawing.Size(100, 20);
			this.txt_Answer.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Answer";
			// 
			// btn_Divide
			// 
			this.btn_Divide.Location = new System.Drawing.Point(254, 161);
			this.btn_Divide.Name = "btn_Divide";
			this.btn_Divide.Size = new System.Drawing.Size(75, 23);
			this.btn_Divide.TabIndex = 7;
			this.btn_Divide.Text = "Divide";
			this.btn_Divide.UseVisualStyleBackColor = true;
			this.btn_Divide.Click += new System.EventHandler(this.btn_Divide_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 281);
			this.Controls.Add(this.btn_Divide);
			this.Controls.Add(this.txt_Answer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_SecondValue);
			this.Controls.Add(this.txt_FirstValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MyselfSoftware";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_FirstValue;
		private System.Windows.Forms.TextBox txt_SecondValue;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txt_Answer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Divide;
	}
}

