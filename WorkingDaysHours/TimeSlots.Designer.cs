namespace CollegeCore.WorkingDaysHours
{
    partial class TimeSlots
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonOneHour = new System.Windows.Forms.RadioButton();
            this.radioButtonThirtyMinutes = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonWorkTime = new System.Windows.Forms.RadioButton();
            this.radioButtonLunchBreak = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.daysListBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonAdd = new FontAwesome.Sharp.IconButton();
            this.ButtonRemove = new FontAwesome.Sharp.IconButton();
            this.DataGridTimeSlot = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTimeSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "HH:mm";
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(193, 62);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(109, 30);
            this.startTimePicker.TabIndex = 1;
            this.startTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonOneHour);
            this.panel1.Controls.Add(this.radioButtonThirtyMinutes);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(193, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 85);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonOneHour
            // 
            this.radioButtonOneHour.AutoSize = true;
            this.radioButtonOneHour.Location = new System.Drawing.Point(4, 32);
            this.radioButtonOneHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonOneHour.Name = "radioButtonOneHour";
            this.radioButtonOneHour.Size = new System.Drawing.Size(91, 29);
            this.radioButtonOneHour.TabIndex = 0;
            this.radioButtonOneHour.Text = "1 Hour";
            this.radioButtonOneHour.UseVisualStyleBackColor = true;
            // 
            // radioButtonThirtyMinutes
            // 
            this.radioButtonThirtyMinutes.AutoSize = true;
            this.radioButtonThirtyMinutes.Checked = true;
            this.radioButtonThirtyMinutes.Location = new System.Drawing.Point(4, 4);
            this.radioButtonThirtyMinutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonThirtyMinutes.Name = "radioButtonThirtyMinutes";
            this.radioButtonThirtyMinutes.Size = new System.Drawing.Size(129, 29);
            this.radioButtonThirtyMinutes.TabIndex = 0;
            this.radioButtonThirtyMinutes.TabStop = true;
            this.radioButtonThirtyMinutes.Text = "30 Minutes";
            this.radioButtonThirtyMinutes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonWorkTime);
            this.panel2.Controls.Add(this.radioButtonLunchBreak);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(193, 193);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 85);
            this.panel2.TabIndex = 2;
            // 
            // radioButtonWorkTime
            // 
            this.radioButtonWorkTime.AutoSize = true;
            this.radioButtonWorkTime.Checked = true;
            this.radioButtonWorkTime.Location = new System.Drawing.Point(4, 4);
            this.radioButtonWorkTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonWorkTime.Name = "radioButtonWorkTime";
            this.radioButtonWorkTime.Size = new System.Drawing.Size(129, 29);
            this.radioButtonWorkTime.TabIndex = 0;
            this.radioButtonWorkTime.TabStop = true;
            this.radioButtonWorkTime.Text = "Work Time";
            this.radioButtonWorkTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonLunchBreak
            // 
            this.radioButtonLunchBreak.AutoSize = true;
            this.radioButtonLunchBreak.Location = new System.Drawing.Point(4, 32);
            this.radioButtonLunchBreak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonLunchBreak.Name = "radioButtonLunchBreak";
            this.radioButtonLunchBreak.Size = new System.Drawing.Size(143, 29);
            this.radioButtonLunchBreak.TabIndex = 0;
            this.radioButtonLunchBreak.Text = "Lunch Break";
            this.radioButtonLunchBreak.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // daysListBox
            // 
            this.daysListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daysListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysListBox.FormattingEnabled = true;
            this.daysListBox.Location = new System.Drawing.Point(193, 7);
            this.daysListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daysListBox.Name = "daysListBox";
            this.daysListBox.Size = new System.Drawing.Size(339, 33);
            this.daysListBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Day of the Week";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Gray;
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ButtonAdd.IconColor = System.Drawing.Color.Cyan;
            this.ButtonAdd.IconSize = 20;
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new System.Drawing.Point(935, 450);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Rotation = 0D;
            this.ButtonAdd.Size = new System.Drawing.Size(189, 54);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.Gray;
            this.ButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ButtonRemove.IconColor = System.Drawing.Color.Cyan;
            this.ButtonRemove.IconSize = 20;
            this.ButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRemove.Location = new System.Drawing.Point(935, 542);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Rotation = 0D;
            this.ButtonRemove.Size = new System.Drawing.Size(189, 56);
            this.ButtonRemove.TabIndex = 10;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // DataGridTimeSlot
            // 
            this.DataGridTimeSlot.AllowUserToAddRows = false;
            this.DataGridTimeSlot.AllowUserToDeleteRows = false;
            this.DataGridTimeSlot.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridTimeSlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTimeSlot.Location = new System.Drawing.Point(71, 373);
            this.DataGridTimeSlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridTimeSlot.Name = "DataGridTimeSlot";
            this.DataGridTimeSlot.ReadOnly = true;
            this.DataGridTimeSlot.RowHeadersWidth = 51;
            this.DataGridTimeSlot.Size = new System.Drawing.Size(777, 202);
            this.DataGridTimeSlot.TabIndex = 11;
            this.DataGridTimeSlot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTimeSlot_CellClick);
            // 
            // TimeSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 653);
            this.Controls.Add(this.DataGridTimeSlot);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.daysListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startTimePicker);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimeSlots";
            this.Text = "TimeSlots";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTimeSlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonOneHour;
        private System.Windows.Forms.RadioButton radioButtonThirtyMinutes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonWorkTime;
        private System.Windows.Forms.RadioButton radioButtonLunchBreak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox daysListBox;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ButtonAdd;
        private FontAwesome.Sharp.IconButton ButtonRemove;
        private System.Windows.Forms.DataGridView DataGridTimeSlot;
    }
}