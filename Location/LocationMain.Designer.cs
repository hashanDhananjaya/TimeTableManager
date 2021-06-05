namespace CollegeCore.Location
{
    partial class LocationMain
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
            this.panelLocationChild = new System.Windows.Forms.Panel();
            this.icnBtnAddBuild = new FontAwesome.Sharp.IconButton();
            this.icnBtnAddRoom = new FontAwesome.Sharp.IconButton();
            this.icnAssignRoom = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panelLocationChild
            // 
            this.panelLocationChild.BackColor = System.Drawing.Color.White;
            this.panelLocationChild.Location = new System.Drawing.Point(0, 55);
            this.panelLocationChild.Name = "panelLocationChild";
            this.panelLocationChild.Size = new System.Drawing.Size(1198, 730);
            this.panelLocationChild.TabIndex = 1;
            // 
            // icnBtnAddBuild
            // 
            this.icnBtnAddBuild.BackColor = System.Drawing.Color.Gray;
            this.icnBtnAddBuild.FlatAppearance.BorderSize = 0;
            this.icnBtnAddBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnAddBuild.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnAddBuild.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnAddBuild.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icnBtnAddBuild.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnAddBuild.IconColor = System.Drawing.Color.WhiteSmoke;
            this.icnBtnAddBuild.IconSize = 16;
            this.icnBtnAddBuild.Location = new System.Drawing.Point(0, 0);
            this.icnBtnAddBuild.Name = "icnBtnAddBuild";
            this.icnBtnAddBuild.Rotation = 0D;
            this.icnBtnAddBuild.Size = new System.Drawing.Size(409, 49);
            this.icnBtnAddBuild.TabIndex = 0;
            this.icnBtnAddBuild.Text = "Add New Building";
            this.icnBtnAddBuild.UseVisualStyleBackColor = false;
            this.icnBtnAddBuild.Click += new System.EventHandler(this.icnBtnAddBuild_Click);
            // 
            // icnBtnAddRoom
            // 
            this.icnBtnAddRoom.BackColor = System.Drawing.Color.Gray;
            this.icnBtnAddRoom.FlatAppearance.BorderSize = 0;
            this.icnBtnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnAddRoom.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnAddRoom.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnAddRoom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icnBtnAddRoom.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnAddRoom.IconColor = System.Drawing.Color.Black;
            this.icnBtnAddRoom.IconSize = 16;
            this.icnBtnAddRoom.Location = new System.Drawing.Point(408, 0);
            this.icnBtnAddRoom.Name = "icnBtnAddRoom";
            this.icnBtnAddRoom.Rotation = 0D;
            this.icnBtnAddRoom.Size = new System.Drawing.Size(407, 49);
            this.icnBtnAddRoom.TabIndex = 1;
            this.icnBtnAddRoom.Text = "Add New Room";
            this.icnBtnAddRoom.UseVisualStyleBackColor = false;
            this.icnBtnAddRoom.Click += new System.EventHandler(this.icnBtnAddRoom_Click);
            // 
            // icnAssignRoom
            // 
            this.icnAssignRoom.BackColor = System.Drawing.Color.Gray;
            this.icnAssignRoom.FlatAppearance.BorderSize = 0;
            this.icnAssignRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnAssignRoom.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnAssignRoom.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnAssignRoom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icnAssignRoom.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnAssignRoom.IconColor = System.Drawing.Color.Black;
            this.icnAssignRoom.IconSize = 16;
            this.icnAssignRoom.Location = new System.Drawing.Point(812, 0);
            this.icnAssignRoom.Name = "icnAssignRoom";
            this.icnAssignRoom.Rotation = 0D;
            this.icnAssignRoom.Size = new System.Drawing.Size(380, 49);
            this.icnAssignRoom.TabIndex = 2;
            this.icnAssignRoom.Text = "Assign Rooms";
            this.icnAssignRoom.UseVisualStyleBackColor = false;
            this.icnAssignRoom.Click += new System.EventHandler(this.icnAssignRoom_Click);
            // 
            // LocationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 703);
            this.Controls.Add(this.icnBtnAddBuild);
            this.Controls.Add(this.icnAssignRoom);
            this.Controls.Add(this.icnBtnAddRoom);
            this.Controls.Add(this.panelLocationChild);
            this.Name = "LocationMain";
            this.Text = "LocationMain";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLocationChild;
        private FontAwesome.Sharp.IconButton icnBtnAddBuild;
        private FontAwesome.Sharp.IconButton icnBtnAddRoom;
        private FontAwesome.Sharp.IconButton icnAssignRoom;
    }
}