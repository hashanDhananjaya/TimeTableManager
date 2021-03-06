namespace CollegeCore.Lecturer
{
    partial class AddSession
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
            this.components = new System.ComponentModel.Container();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDBDataSet1 = new CollegeManagement.CollegeDBDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupId = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDBDataSet = new CollegeManagement.CollegeDBDataSet();
            this.groupsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectCode = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboSubjects = new System.Windows.Forms.ComboBox();
            this.comboTag = new System.Windows.Forms.ComboBox();
            this.studentCount = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.lecturersTableAdapter = new CollegeManagement.CollegeDBDataSetTableAdapters.lecturersTableAdapter();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programTableAdapter = new CollegeManagement.CollegeDBDataSetTableAdapters.programTableAdapter();
            this.subjectsTableAdapter = new CollegeManagement.CollegeDBDataSetTableAdapters.subjectsTableAdapter();
            this.groupsTableAdapter = new CollegeManagement.CollegeDBDataSetTableAdapters.groupsTableAdapter();
            this.comboSubGroup = new System.Windows.Forms.ComboBox();
            this.subgroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.sub_groupTableAdapter = new CollegeManagement.CollegeDBDataSetTableAdapters.sub_groupTableAdapter();
            this.ChecksboxLecturersList = new System.Windows.Forms.CheckedListBox();
            this.sessionsTableAdapter = new CollegeManagement.CollegeDBDataSetTableAdapters.SessionsTableAdapter();
            this.groupsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gvSessions = new System.Windows.Forms.DataGridView();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagsTableAdapter = new CollegeManagement.CollegeDBDataSetTableAdapters.tagsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subgroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataMember = "Sessions";
            this.sessionsBindingSource.DataSource = this.collegeDBDataSet1;
            // 
            // collegeDBDataSet1
            // 
            this.collegeDBDataSet1.DataSetName = "CollegeDBDataSet";
            this.collegeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(971, 580);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 48);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.onClick_delete);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(971, 506);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 45);
            this.button2.TabIndex = 41;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.onClick_update);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(971, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 40;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onClick_save);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 489);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Duration*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Student count*";
            // 
            // GroupId
            // 
            this.GroupId.DataSource = this.groupsBindingSource;
            this.GroupId.DisplayMember = "group_no";
            this.GroupId.FormattingEnabled = true;
            this.GroupId.Location = new System.Drawing.Point(233, 313);
            this.GroupId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupId.Name = "GroupId";
            this.GroupId.Size = new System.Drawing.Size(132, 24);
            this.GroupId.TabIndex = 33;
            this.GroupId.ValueMember = "group_id";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.collegeDBDataSet;
            // 
            // collegeDBDataSet
            // 
            this.collegeDBDataSet.DataSetName = "CollegeDBDataSet";
            this.collegeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource1
            // 
            this.groupsBindingSource1.DataMember = "groups";
            this.groupsBindingSource1.DataSource = this.collegeDBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Group Id*";
            // 
            // SubjectCode
            // 
            this.SubjectCode.DataSource = this.subjectsBindingSource;
            this.SubjectCode.DisplayMember = "subject_Code";
            this.SubjectCode.FormattingEnabled = true;
            this.SubjectCode.Location = new System.Drawing.Point(233, 198);
            this.SubjectCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubjectCode.Name = "SubjectCode";
            this.SubjectCode.Size = new System.Drawing.Size(132, 24);
            this.SubjectCode.TabIndex = 31;
            this.SubjectCode.ValueMember = "subject_Code";
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.collegeDBDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tag*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Subject code*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Lecturer(s)*";
            // 
            // lecturersBindingSource
            // 
            this.lecturersBindingSource.DataMember = "lecturers";
            this.lecturersBindingSource.DataSource = this.collegeDBDataSet;
            // 
            // comboSubjects
            // 
            this.comboSubjects.DataSource = this.subjectsBindingSource;
            this.comboSubjects.DisplayMember = "sub_name";
            this.comboSubjects.FormattingEnabled = true;
            this.comboSubjects.Location = new System.Drawing.Point(233, 137);
            this.comboSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSubjects.Name = "comboSubjects";
            this.comboSubjects.Size = new System.Drawing.Size(132, 24);
            this.comboSubjects.TabIndex = 45;
            this.comboSubjects.ValueMember = "subject_id";
            // 
            // comboTag
            // 
            this.comboTag.FormattingEnabled = true;
            this.comboTag.Location = new System.Drawing.Point(233, 254);
            this.comboTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTag.Name = "comboTag";
            this.comboTag.Size = new System.Drawing.Size(132, 24);
            this.comboTag.TabIndex = 46;
            // 
            // studentCount
            // 
            this.studentCount.Location = new System.Drawing.Point(233, 427);
            this.studentCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentCount.Name = "studentCount";
            this.studentCount.Size = new System.Drawing.Size(132, 22);
            this.studentCount.TabIndex = 47;
            this.studentCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentCount_changed_numberValidate);
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(233, 485);
            this.duration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(132, 22);
            this.duration.TabIndex = 48;
            this.duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Duration_changed_validate);
            // 
            // lecturersTableAdapter
            // 
            this.lecturersTableAdapter.ClearBeforeFill = true;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "program";
            this.programBindingSource.DataSource = this.collegeDBDataSet;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // comboSubGroup
            // 
            this.comboSubGroup.DataSource = this.subgroupBindingSource;
            this.comboSubGroup.DisplayMember = "sub_group_no";
            this.comboSubGroup.FormattingEnabled = true;
            this.comboSubGroup.Location = new System.Drawing.Point(233, 372);
            this.comboSubGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSubGroup.Name = "comboSubGroup";
            this.comboSubGroup.Size = new System.Drawing.Size(132, 24);
            this.comboSubGroup.TabIndex = 50;
            this.comboSubGroup.ValueMember = "sub_group_id";
            // 
            // subgroupBindingSource
            // 
            this.subgroupBindingSource.DataMember = "sub_group";
            this.subgroupBindingSource.DataSource = this.collegeDBDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 375);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Sub group*";
            // 
            // sub_groupTableAdapter
            // 
            this.sub_groupTableAdapter.ClearBeforeFill = true;
            // 
            // ChecksboxLecturersList
            // 
            this.ChecksboxLecturersList.FormattingEnabled = true;
            this.ChecksboxLecturersList.Location = new System.Drawing.Point(233, 69);
            this.ChecksboxLecturersList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChecksboxLecturersList.Name = "ChecksboxLecturersList";
            this.ChecksboxLecturersList.Size = new System.Drawing.Size(177, 55);
            this.ChecksboxLecturersList.TabIndex = 51;
            // 
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsBindingSource2
            // 
            this.groupsBindingSource2.DataMember = "groups";
            this.groupsBindingSource2.DataSource = this.collegeDBDataSet1;
            // 
            // gvSessions
            // 
            this.gvSessions.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSessions.Location = new System.Drawing.Point(475, 37);
            this.gvSessions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvSessions.Name = "gvSessions";
            this.gvSessions.RowHeadersWidth = 51;
            this.gvSessions.Size = new System.Drawing.Size(651, 342);
            this.gvSessions.TabIndex = 52;
            this.gvSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gcSession_CellClick);
            // 
            // tagsBindingSource
            // 
            this.tagsBindingSource.DataMember = "tags";
            this.tagsBindingSource.DataSource = this.collegeDBDataSet1;
            // 
            // tagsTableAdapter
            // 
            this.tagsTableAdapter.ClearBeforeFill = true;
            // 
            // AddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 653);
            this.Controls.Add(this.gvSessions);
            this.Controls.Add(this.ChecksboxLecturersList);
            this.Controls.Add(this.comboSubGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.studentCount);
            this.Controls.Add(this.comboTag);
            this.Controls.Add(this.comboSubjects);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubjectCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSession";
            this.Text = "AddSession";
            this.Load += new System.EventHandler(this.AddSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subgroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GroupId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SubjectCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSubjects;
        private System.Windows.Forms.ComboBox comboTag;
        private System.Windows.Forms.TextBox studentCount;
        private System.Windows.Forms.TextBox duration;
        private CollegeManagement.CollegeDBDataSet collegeDBDataSet;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private CollegeManagement.CollegeDBDataSetTableAdapters.lecturersTableAdapter lecturersTableAdapter;
        private System.Windows.Forms.BindingSource programBindingSource;
        private CollegeManagement.CollegeDBDataSetTableAdapters.programTableAdapter programTableAdapter;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private CollegeManagement.CollegeDBDataSetTableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private CollegeManagement.CollegeDBDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource1;
        private System.Windows.Forms.ComboBox comboSubGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource subgroupBindingSource;
        private CollegeManagement.CollegeDBDataSetTableAdapters.sub_groupTableAdapter sub_groupTableAdapter;
        private System.Windows.Forms.CheckedListBox ChecksboxLecturersList;
        private CollegeManagement.CollegeDBDataSet collegeDBDataSet1;
        private System.Windows.Forms.BindingSource sessionsBindingSource;
        private CollegeManagement.CollegeDBDataSetTableAdapters.SessionsTableAdapter sessionsTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource2;
        private System.Windows.Forms.DataGridView gvSessions;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private CollegeManagement.CollegeDBDataSetTableAdapters.tagsTableAdapter tagsTableAdapter;
    }
}