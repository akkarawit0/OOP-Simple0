namespace OOP_Simple0
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Yeay = new System.Windows.Forms.TextBox();
            this.textBox_Hight = new System.Windows.Forms.TextBox();
            this.textBox_Grade = new System.Windows.Forms.TextBox();
            this.textBox_Major = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.e)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(238, 55);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(125, 27);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(238, 88);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(125, 27);
            this.textBox_ID.TabIndex = 2;
            // 
            // textBox_Yeay
            // 
            this.textBox_Yeay.Location = new System.Drawing.Point(238, 121);
            this.textBox_Yeay.Name = "textBox_Yeay";
            this.textBox_Yeay.Size = new System.Drawing.Size(125, 27);
            this.textBox_Yeay.TabIndex = 2;
            // 
            // textBox_Hight
            // 
            this.textBox_Hight.Location = new System.Drawing.Point(238, 154);
            this.textBox_Hight.Name = "textBox_Hight";
            this.textBox_Hight.Size = new System.Drawing.Size(125, 27);
            this.textBox_Hight.TabIndex = 2;
            // 
            // textBox_Grade
            // 
            this.textBox_Grade.Location = new System.Drawing.Point(238, 187);
            this.textBox_Grade.Name = "textBox_Grade";
            this.textBox_Grade.Size = new System.Drawing.Size(125, 27);
            this.textBox_Grade.TabIndex = 2;
            // 
            // textBox_Major
            // 
            this.textBox_Major.Location = new System.Drawing.Point(238, 220);
            this.textBox_Major.Name = "textBox_Major";
            this.textBox_Major.Size = new System.Drawing.Size(125, 27);
            this.textBox_Major.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "รหัสนักศึกษา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ส่วนสูง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "เกรด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "สาขา";
            // 
            // e
            // 
            this.e.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.e.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Student_ID,
            this.Year,
            this.Hight,
            this.Grade,
            this.Major});
            this.e.Location = new System.Drawing.Point(441, 55);
            this.e.Name = "e";
            this.e.RowHeadersWidth = 51;
            this.e.RowTemplate.Height = 29;
            this.e.Size = new System.Drawing.Size(328, 188);
            this.e.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.HeaderText = "ชื่อ";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "รหัสนักศึกษา";
            this.Student_ID.MinimumWidth = 6;
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "ปีเกิด";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 125;
            // 
            // Hight
            // 
            this.Hight.HeaderText = "ส่วนสูง";
            this.Hight.MinimumWidth = 6;
            this.Hight.Name = "Hight";
            this.Hight.Width = 125;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "เกรด";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 125;
            // 
            // Major
            // 
            this.Major.HeaderText = "สาขา";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.e);
            this.Controls.Add(this.textBox_Major);
            this.Controls.Add(this.textBox_Grade);
            this.Controls.Add(this.textBox_Hight);
            this.Controls.Add(this.textBox_Yeay);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox_Name;
        private TextBox textBox_ID;
        private TextBox textBox_Yeay;
        private TextBox textBox_Hight;
        private TextBox textBox_Grade;
        private TextBox textBox_Major;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView e;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Student_ID;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Hight;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Major;
        private Button button2;
    }
}