

namespace CollegeCore.WorkingDaysHours
{
    partial class WorkingHours
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
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.daysListBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridWorkHours = new System.Windows.Forms.DataGridView();
            this.ButtonSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWorkHours)).BeginInit();
            this.SuspendLayout();
            // 
            // startTimePicker
            // 
            this.startTimePicker.AllowDrop = true;
            this.startTimePicker.CustomFormat = "HH:mm";
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(233, 86);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(132, 45);
            this.startTimePicker.TabIndex = 0;
            this.startTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Time";
            // 
            // endTimePicker
            // 
            this.endTimePicker.AllowDrop = true;
            this.endTimePicker.CustomFormat = "HH:mm";
            this.endTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.endTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(233, 149);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(132, 45);
            this.endTimePicker.TabIndex = 3;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.EndTimePicker_ValueChanged);
            // 
            // daysListBox
            // 
            this.daysListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daysListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysListBox.FormattingEnabled = true;
            this.daysListBox.Location = new System.Drawing.Point(233, 7);
            this.daysListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daysListBox.Name = "daysListBox";
            this.daysListBox.Size = new System.Drawing.Size(469, 37);
            this.daysListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day of the Week";
            // 
            // DataGridWorkHours
            // 
            this.DataGridWorkHours.AllowUserToAddRows = false;
            this.DataGridWorkHours.AllowUserToDeleteRows = false;
            this.DataGridWorkHours.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridWorkHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridWorkHours.Location = new System.Drawing.Point(23, 303);
            this.DataGridWorkHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridWorkHours.Name = "DataGridWorkHours";
            this.DataGridWorkHours.ReadOnly = true;
            this.DataGridWorkHours.RowHeadersWidth = 51;
            this.DataGridWorkHours.Size = new System.Drawing.Size(796, 197);
            this.DataGridWorkHours.TabIndex = 6;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.Gray;
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ButtonSave.IconColor = System.Drawing.Color.Cyan;
            this.ButtonSave.IconSize = 20;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(917, 472);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Rotation = 0D;
            this.ButtonSave.Size = new System.Drawing.Size(189, 64);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // WorkingHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 653);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.DataGridWorkHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.daysListBox);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTimePicker);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WorkingHours";
            this.Text = "WorkingHours";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWorkHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.ComboBox daysListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridWorkHours;
        private FontAwesome.Sharp.IconButton ButtonSave;

    }
}