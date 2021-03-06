namespace CollegeCore.Subject
{
    partial class AddSubject
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
            this.gvLecturers = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eveHour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.offSem = new System.Windows.Forms.ComboBox();
            this.offYear = new System.Windows.Forms.ComboBox();
            this.subCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subName = new System.Windows.Forms.TextBox();
            this.lecHour = new System.Windows.Forms.TextBox();
            this.tutHour = new System.Windows.Forms.TextBox();
            this.labHour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLecturers
            // 
            this.gvLecturers.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvLecturers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLecturers.Location = new System.Drawing.Point(472, 29);
            this.gvLecturers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvLecturers.Name = "gvLecturers";
            this.gvLecturers.RowHeadersWidth = 51;
            this.gvLecturers.Size = new System.Drawing.Size(654, 345);
            this.gvLecturers.TabIndex = 43;
            this.gvLecturers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gcSubject_CellClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(976, 569);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 59);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.delete_onClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(976, 497);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 52);
            this.button2.TabIndex = 41;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.update_onClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(976, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 51);
            this.button1.TabIndex = 40;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.save_onClick);
            // 
            // eveHour
            // 
            this.eveHour.Location = new System.Drawing.Point(279, 468);
            this.eveHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eveHour.Name = "eveHour";
            this.eveHour.Size = new System.Drawing.Size(132, 22);
            this.eveHour.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 471);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Number of Evaluation Hours*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Number of Lab Hours*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Number of Tutorial Hours*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Number of Lecture Hours*";
            // 
            // offSem
            // 
            this.offSem.FormattingEnabled = true;
            this.offSem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.offSem.Location = new System.Drawing.Point(279, 123);
            this.offSem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.offSem.Name = "offSem";
            this.offSem.Size = new System.Drawing.Size(132, 24);
            this.offSem.TabIndex = 1;
            // 
            // offYear
            // 
            this.offYear.FormattingEnabled = true;
            this.offYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.offYear.Location = new System.Drawing.Point(279, 68);
            this.offYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.offYear.Name = "offYear";
            this.offYear.Size = new System.Drawing.Size(132, 24);
            this.offYear.TabIndex = 0;
            // 
            // subCode
            // 
            this.subCode.Location = new System.Drawing.Point(279, 229);
            this.subCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subCode.Name = "subCode";
            this.subCode.Size = new System.Drawing.Size(132, 22);
            this.subCode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Subject Code*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Subject Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Offered Semester*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Offered year*";
            // 
            // subName
            // 
            this.subName.Location = new System.Drawing.Point(279, 178);
            this.subName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(132, 22);
            this.subName.TabIndex = 2;
            // 
            // lecHour
            // 
            this.lecHour.Location = new System.Drawing.Point(279, 288);
            this.lecHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lecHour.Name = "lecHour";
            this.lecHour.Size = new System.Drawing.Size(132, 22);
            this.lecHour.TabIndex = 4;
            // 
            // tutHour
            // 
            this.tutHour.Location = new System.Drawing.Point(279, 352);
            this.tutHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tutHour.Name = "tutHour";
            this.tutHour.Size = new System.Drawing.Size(132, 22);
            this.tutHour.TabIndex = 5;
            // 
            // labHour
            // 
            this.labHour.Location = new System.Drawing.Point(279, 410);
            this.labHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(132, 22);
            this.labHour.TabIndex = 6;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 653);
            this.Controls.Add(this.labHour);
            this.Controls.Add(this.tutHour);
            this.Controls.Add(this.lecHour);
            this.Controls.Add(this.subName);
            this.Controls.Add(this.gvLecturers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eveHour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.offSem);
            this.Controls.Add(this.offYear);
            this.Controls.Add(this.subCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            ((System.ComponentModel.ISupportInitialize)(this.gvLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLecturers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox eveHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox offSem;
        private System.Windows.Forms.ComboBox offYear;
        private System.Windows.Forms.TextBox subCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subName;
        private System.Windows.Forms.TextBox lecHour;
        private System.Windows.Forms.TextBox tutHour;
        private System.Windows.Forms.TextBox labHour;
    }
}