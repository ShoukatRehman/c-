namespace WindowsFormsApplication1
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_second = new System.Windows.Forms.TextBox();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_Choices = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_calul = new System.Windows.Forms.Button();
            this.lbl_Errors = new System.Windows.Forms.Label();
            this.lbl_lastoption = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input first value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input second value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer";
            // 
            // txt_first
            // 
            this.txt_first.Location = new System.Drawing.Point(323, 127);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(100, 20);
            this.txt_first.TabIndex = 1;
            // 
            // txt_second
            // 
            this.txt_second.Location = new System.Drawing.Point(323, 176);
            this.txt_second.Name = "txt_second";
            this.txt_second.Size = new System.Drawing.Size(100, 20);
            this.txt_second.TabIndex = 2;
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(323, 264);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.ReadOnly = true;
            this.txt_Answer.Size = new System.Drawing.Size(100, 20);
            this.txt_Answer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 100);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "CALCULATOR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_Choices
            // 
            this.cmb_Choices.FormattingEnabled = true;
            this.cmb_Choices.Items.AddRange(new object[] {
            "Add",
            "Sub"});
            this.cmb_Choices.Location = new System.Drawing.Point(323, 226);
            this.cmb_Choices.Name = "cmb_Choices";
            this.cmb_Choices.Size = new System.Drawing.Size(100, 21);
            this.cmb_Choices.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choice";
            // 
            // btn_calul
            // 
            this.btn_calul.Location = new System.Drawing.Point(474, 266);
            this.btn_calul.Name = "btn_calul";
            this.btn_calul.Size = new System.Drawing.Size(75, 23);
            this.btn_calul.TabIndex = 4;
            this.btn_calul.TabStop = false;
            this.btn_calul.Text = "calul";
            this.btn_calul.UseVisualStyleBackColor = true;
            this.btn_calul.Click += new System.EventHandler(this.btn_calul_Click);
            // 
            // lbl_Errors
            // 
            this.lbl_Errors.AutoSize = true;
            this.lbl_Errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_Errors.Location = new System.Drawing.Point(37, 321);
            this.lbl_Errors.Name = "lbl_Errors";
            this.lbl_Errors.Size = new System.Drawing.Size(0, 13);
            this.lbl_Errors.TabIndex = 13;
            // 
            // lbl_lastoption
            // 
            this.lbl_lastoption.AutoSize = true;
            this.lbl_lastoption.Location = new System.Drawing.Point(43, 321);
            this.lbl_lastoption.Name = "lbl_lastoption";
            this.lbl_lastoption.Size = new System.Drawing.Size(74, 13);
            this.lbl_lastoption.TabIndex = 14;
            this.lbl_lastoption.Text = "Last operation";
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(474, 324);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(75, 23);
            this.btn_History.TabIndex = 15;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 453);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.lbl_lastoption);
            this.Controls.Add(this.lbl_Errors);
            this.Controls.Add(this.btn_calul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Choices);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.txt_second);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.TextBox txt_second;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_Choices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_calul;
        private System.Windows.Forms.Label lbl_Errors;
        private System.Windows.Forms.Label lbl_lastoption;
        private System.Windows.Forms.Button btn_History;
    }
}

