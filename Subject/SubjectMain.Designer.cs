namespace CollegeCore.Subject
{
    partial class SubjectMain
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
            this.panelSubjectChild = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icnBtnAddLec = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubjectChild
            // 
            this.panelSubjectChild.BackColor = System.Drawing.Color.White;
            this.panelSubjectChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubjectChild.Location = new System.Drawing.Point(0, 42);
            this.panelSubjectChild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubjectChild.Name = "panelSubjectChild";
            this.panelSubjectChild.Size = new System.Drawing.Size(1180, 641);
            this.panelSubjectChild.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.icnBtnAddLec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(100, 10, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 42);
            this.panel1.TabIndex = 5;
            // 
            // icnBtnAddLec
            // 
            this.icnBtnAddLec.BackColor = System.Drawing.Color.Gray;
            this.icnBtnAddLec.Dock = System.Windows.Forms.DockStyle.Left;
            this.icnBtnAddLec.FlatAppearance.BorderSize = 0;
            this.icnBtnAddLec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnAddLec.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnAddLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnAddLec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.icnBtnAddLec.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnAddLec.IconColor = System.Drawing.Color.Black;
            this.icnBtnAddLec.IconSize = 16;
            this.icnBtnAddLec.Location = new System.Drawing.Point(0, 0);
            this.icnBtnAddLec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icnBtnAddLec.Name = "icnBtnAddLec";
            this.icnBtnAddLec.Rotation = 0D;
            this.icnBtnAddLec.Size = new System.Drawing.Size(1151, 42);
            this.icnBtnAddLec.TabIndex = 0;
            this.icnBtnAddLec.Text = "Add Subjects";
            this.icnBtnAddLec.UseVisualStyleBackColor = false;
            this.icnBtnAddLec.Click += new System.EventHandler(this.add_Subject_click);
            // 
            // SubjectMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 683);
            this.Controls.Add(this.panelSubjectChild);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SubjectMain";
            this.Text = "SubjectMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSubjectChild;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icnBtnAddLec;
    }
}