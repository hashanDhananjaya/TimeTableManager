using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeCore.Infrastructure;
using CollegeCore.Utilities;
using CollegeManagement.Server.Infrastructure;
//using Google.Protobuf.WellKnownTypes;

namespace CollegeManagement.TimeTable
{
    public partial class TimeTableMain : Form
    {
        TimeTableGeneratorToPDFCore timeTable = new TimeTableGeneratorToPDFCore();

        public TimeTableMain()
        {

            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            LoadData();
            Cursor.Current = Cursors.Default;
        }

        private void LoadData()
        {
            comboBoxStudent.DataSource = timeTable.GetData(CommonConstants.QUERY_GET_SUBGROUPS);
            comboBoxLecturer.DataSource = timeTable.GetData(CommonConstants.QUERY_GET_LECTURERS);
            comboBoxRoom.DataSource = timeTable.GetData(CommonConstants.QUERY_GET_ROOMS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fbd = new SaveFileDialog();
            fbd.RestoreDirectory = true;
            fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fbd.Filter = "Pdf File|*.pdf";
            fbd.FileName = "Time-Table-Generated-at-" + DateTime.Now.ToString("yyyyMMddHHmmssffff");

            Exception status = null;

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
            {
                Cursor.Current = Cursors.WaitCursor;

                if (radioButtonLecturer.Checked == true) 
                {
                   status = timeTable.GenerateTimeTable(fbd.FileName, CommonConstants.QUERY_GET_TIMETABLE_BY_LECTURER, comboBoxLecturer.SelectedItem.ToString(), "LEC");
                
                }
                else if (radioButtonRoom.Checked == true)
                {
                    status = timeTable.GenerateTimeTable(fbd.FileName, CommonConstants.QUERY_GET_TIMETABLE_BY_ROOM, comboBoxRoom.SelectedItem.ToString(), "HALL");
                }
                else if (radioButtonStudent.Checked == true)
                {
                    status = timeTable.GenerateTimeTable(fbd.FileName, CommonConstants.QUERY_GET_TIMETABLE_BY_STUDENT_GROUP, comboBoxStudent.SelectedItem.ToString(), "GROUP");
                }
                

                Cursor.Current = Cursors.Default;

                if (status != null)
                {
                    MessageBox.Show("Error Genarating PDF!!\n" + status.Message.ToString(), "Generate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked == true)
            {
                comboBoxStudent.Enabled = true;
            }
            else 
            {
                comboBoxStudent.Enabled = false;
            }
        }

        private void radioButtonLecturer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLecturer.Checked == true)
            {
                comboBoxLecturer.Enabled = true;
            }
            else
            {
                comboBoxLecturer.Enabled = false;
            }
        }

        private void radioButtonRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRoom.Checked == true)
            {
                comboBoxRoom.Enabled = true;
            }
            else
            {
                comboBoxRoom.Enabled = false;
            }
        }
    }
}
