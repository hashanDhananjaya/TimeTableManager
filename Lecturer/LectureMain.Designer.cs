namespace CollegeCore.Lecturer
{
    partial class LectureMain
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
            this.icnBtnSession = new FontAwesome.Sharp.IconButton();
            this.icnBtnAddLec = new FontAwesome.Sharp.IconButton();
            this.panelLecturerChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.icnBtnSession);
            this.panel1.Controls.Add(this.icnBtnAddLec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(100, 10, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 42);
            this.panel1.TabIndex = 3;
            // 
            // icnBtnSession
            // 
            this.icnBtnSession.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.icnBtnSession.Dock = System.Windows.Forms.DockStyle.Left;
            this.icnBtnSession.FlatAppearance.BorderSize = 0;
            this.icnBtnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnSession.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnSession.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnSession.IconColor = System.Drawing.Color.Black;
            this.icnBtnSession.IconSize = 16;
            this.icnBtnSession.Location = new System.Drawing.Point(591, 0);
            this.icnBtnSession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icnBtnSession.Name = "icnBtnSession";
            this.icnBtnSession.Rotation = 0D;
            this.icnBtnSession.Size = new System.Drawing.Size(589, 42);
            this.icnBtnSession.TabIndex = 2;
            this.icnBtnSession.Text = "Add / Manage Session";
            this.icnBtnSession.UseVisualStyleBackColor = false;
            this.icnBtnSession.Click += new System.EventHandler(this.icnBtnAddSession_Click);
            // 
            // icnBtnAddLec
            // 
            this.icnBtnAddLec.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.icnBtnAddLec.Dock = System.Windows.Forms.DockStyle.Left;
            this.icnBtnAddLec.FlatAppearance.BorderSize = 0;
            this.icnBtnAddLec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnAddLec.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnAddLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnAddLec.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnAddLec.IconColor = System.Drawing.Color.Black;
            this.icnBtnAddLec.IconSize = 16;
            this.icnBtnAddLec.Location = new System.Drawing.Point(0, 0);
            this.icnBtnAddLec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icnBtnAddLec.Name = "icnBtnAddLec";
            this.icnBtnAddLec.Rotation = 0D;
            this.icnBtnAddLec.Size = new System.Drawing.Size(591, 42);
            this.icnBtnAddLec.TabIndex = 0;
            this.icnBtnAddLec.Text = "Add / Manage Lecturers";
            this.icnBtnAddLec.UseVisualStyleBackColor = false;
            this.icnBtnAddLec.Click += new System.EventHandler(this.icnBtnAddLec_Click);
            // 
            // panelLecturerChild
            // 
            this.panelLecturerChild.BackColor = System.Drawing.Color.White;
            this.panelLecturerChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLecturerChild.Location = new System.Drawing.Point(0, 42);
            this.panelLecturerChild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLecturerChild.Name = "panelLecturerChild";
            this.panelLecturerChild.Size = new System.Drawing.Size(1180, 641);
            this.panelLecturerChild.TabIndex = 4;
            // 
            // LectureMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 683);
            this.Controls.Add(this.panelLecturerChild);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LectureMain";
            this.Text = "Lecture Management";
            this.Load += new System.EventHandler(this.LectureMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icnBtnSession;
        private FontAwesome.Sharp.IconButton icnBtnAddLec;
        private System.Windows.Forms.Panel panelLecturerChild;
    }
}