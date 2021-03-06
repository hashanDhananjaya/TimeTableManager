namespace CollegeCore.Lecturer
{
    partial class AddLecturers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvLecturers = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rankTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvlTxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buildingtxt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.centerTxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.facultyTxt = new System.Windows.Forms.ComboBox();
            this.titleTxt = new System.Windows.Forms.ComboBox();
            this.deptmntTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gvLecturers);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rankTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lvlTxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buildingtxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.centerTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.facultyTxt);
            this.panel1.Controls.Add(this.titleTxt);
            this.panel1.Controls.Add(this.deptmntTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.empIdTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 658);
            this.panel1.TabIndex = 0;
            // 
            // gvLecturers
            // 
            this.gvLecturers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLecturers.Location = new System.Drawing.Point(520, 27);
            this.gvLecturers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvLecturers.Name = "gvLecturers";
            this.gvLecturers.RowHeadersWidth = 51;
            this.gvLecturers.Size = new System.Drawing.Size(611, 326);
            this.gvLecturers.TabIndex = 22;
            this.gvLecturers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gcLecture_CellClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(970, 570);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 47);
            this.button3.TabIndex = 21;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.delete_onclick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(970, 491);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.onclick_update);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(970, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.save_onclick);
            // 
            // rankTxt
            // 
            this.rankTxt.Location = new System.Drawing.Point(220, 446);
            this.rankTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rankTxt.Name = "rankTxt";
            this.rankTxt.Size = new System.Drawing.Size(132, 22);
            this.rankTxt.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 454);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rank*";
            // 
            // lvlTxt
            // 
            this.lvlTxt.FormattingEnabled = true;
            this.lvlTxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.lvlTxt.Location = new System.Drawing.Point(220, 386);
            this.lvlTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvlTxt.Name = "lvlTxt";
            this.lvlTxt.Size = new System.Drawing.Size(132, 24);
            this.lvlTxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Level*";
            // 
            // buildingtxt
            // 
            this.buildingtxt.FormattingEnabled = true;
            this.buildingtxt.Items.AddRange(new object[] {
            "New Building",
            "Engineering",
            "Business",
            "Computing"});
            this.buildingtxt.Location = new System.Drawing.Point(220, 329);
            this.buildingtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buildingtxt.Name = "buildingtxt";
            this.buildingtxt.Size = new System.Drawing.Size(132, 24);
            this.buildingtxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Building*";
            // 
            // centerTxt
            // 
            this.centerTxt.FormattingEnabled = true;
            this.centerTxt.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.centerTxt.Location = new System.Drawing.Point(220, 270);
            this.centerTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.centerTxt.Name = "centerTxt";
            this.centerTxt.Size = new System.Drawing.Size(132, 24);
            this.centerTxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Center*";
            // 
            // facultyTxt
            // 
            this.facultyTxt.FormattingEnabled = true;
            this.facultyTxt.Items.AddRange(new object[] {
            "Faculty of Computing",
            "Faculty of Business",
            "Faculty of Engineering"});
            this.facultyTxt.Location = new System.Drawing.Point(220, 155);
            this.facultyTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.facultyTxt.Name = "facultyTxt";
            this.facultyTxt.Size = new System.Drawing.Size(132, 24);
            this.facultyTxt.TabIndex = 9;
            // 
            // titleTxt
            // 
            this.titleTxt.FormattingEnabled = true;
            this.titleTxt.Items.AddRange(new object[] {
            "Mr.",
            "Miss.",
            "Ms.",
            "Mrs.",
            "Dr.",
            "Prof.",
            "Rev."});
            this.titleTxt.Location = new System.Drawing.Point(220, 50);
            this.titleTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(68, 24);
            this.titleTxt.TabIndex = 8;
            // 
            // deptmntTxt
            // 
            this.deptmntTxt.Location = new System.Drawing.Point(220, 212);
            this.deptmntTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deptmntTxt.Name = "deptmntTxt";
            this.deptmntTxt.Size = new System.Drawing.Size(132, 22);
            this.deptmntTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Faculty*";
            // 
            // empIdTxt
            // 
            this.empIdTxt.Location = new System.Drawing.Point(220, 101);
            this.empIdTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empIdTxt.Name = "empIdTxt";
            this.empIdTxt.Size = new System.Drawing.Size(132, 22);
            this.empIdTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID*";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(313, 50);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(199, 22);
            this.nameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name*";
            // 
            // AddLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 653);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddLecturers";
            this.Text = "AddLecturers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLecturers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox deptmntTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox titleTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rankTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox lvlTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox buildingtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox centerTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox facultyTxt;
        private System.Windows.Forms.DataGridView gvLecturers;
        private System.Windows.Forms.Button button3;
    }
}