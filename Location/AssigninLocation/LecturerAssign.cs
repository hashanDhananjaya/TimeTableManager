using CollegeCore;
using CollegeManagement.Server.Infrastructure;
using CollegeManagement.Server.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement.Location.AssigninLocation
{
    public partial class LecturerAssign : Form
    {

        string tag, building, room,lecturer;
        AssignRoomController objAssign = new AssignRoomController();
        AssignRooms objCurrentAssign = new AssignRooms();
        public LecturerAssign()
        {
            InitializeComponent();
            getLecturerNames();
            lecturer = cmbLecturer.Text;
        }

        private void cmbLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            getLecturerNames();
            lecturer = cmbLecturer.Text;
        }

        private void cmbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            tag = cmbTag.Text;
            building = cmbBuilding.Text;
            getTagDetails();
            getTagRoom(tag,building);
        }

        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            tag = cmbTag.Text;
            building = cmbBuilding.Text;
            getTagRoom(tag, building);
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            room = cmbRoom.Text;
        }

        private void icnBtnAdd_Click(object sender, EventArgs e)
        {
            lecturer = cmbLecturer.Text;
            objCurrentAssign.lecturer = lecturer;
            objCurrentAssign.tag = tag;
            objCurrentAssign.building = building;
            objCurrentAssign.room = room;

            bool result = objAssign.insertAssignedLecturer(objCurrentAssign);

            if (result == true)
            {
                MessageBox.Show("Succesfully Insrted");
                cmbLecturer.Text = "";
                cmbBuilding.Text = "";
                cmbRoom.Text = "";
                cmbTag.Text = "";
            }
            else
            {
                MessageBox.Show("Insertion Failed");
            }
        }

        private void LecturerAssign_Load(object sender, EventArgs e)
        {

        }

        public void getTagDetails()
        {
            string query = "Select Building from rooms where Room_Type ='" + tag + "'";
            
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(query, DBConnection.DatabaseConnection);

            try
            {
                DBConnection.OpenConnection();
                sda.Fill(ds);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                DBConnection.CloseConnection();
            }

            cmbBuilding.DataSource = ds.Tables[0];
            cmbBuilding.DisplayMember = ds.Tables[0].Columns[0].ToString();

        }

        public void getTagRoom(string tag, string building)
        {
            string query = "Select Room_Name from rooms where Room_Type ='" + tag + "' and Building='" + building + "'";
            
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(query, DBConnection.DatabaseConnection);

            try
            {
                DBConnection.OpenConnection();
                sda.Fill(ds);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                DBConnection.CloseConnection();
            }

            cmbRoom.DataSource = ds.Tables[0];
            cmbRoom.DisplayMember = ds.Tables[0].Columns[0].ToString();

        }

        public void getLecturerNames()
        {
            string query = "Select lecturer_name from lecturers";
            
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(query, DBConnection.DatabaseConnection);

            try
            {
                DBConnection.OpenConnection();
                sda.Fill(ds);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                DBConnection.CloseConnection();
            }

            cmbLecturer.DataSource = ds.Tables[0];
            cmbLecturer.DisplayMember = ds.Tables[0].Columns[0].ToString();

        }
    }
}
