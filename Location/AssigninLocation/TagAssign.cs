using CollegeCore;
using CollegeManagement.Server.Infrastructure;
using CollegeManagement.Server.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CollegeCore.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement.Location.AssigninLocation
{
    public partial class TagAssign : Form
    {

        AssignRoomController objTagName = new AssignRoomController();
        string tag,building,room;
        AssignRooms objCurrentAssignTag = new AssignRooms();

        public TagAssign()
        {
            InitializeComponent();
        }

        private void TagAssign_Load(object sender, EventArgs e)
        {
            
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tag = comboBox1.Text;
            building = comboBox2.Text;
            if (tag != null)
            {

                getTagDetails();
                getTagRoom(tag, building);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tag = comboBox1.Text;
            building = comboBox2.Text;
            if (building != null)
            {
                getTagRoom(tag, building);
            }
            else 
            {
                MessageBox.Show("building name cannot be null");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            room = comboBox3.Text;
        }

        private void icnBtnAdd_Click(object sender, EventArgs e)
        {
            objCurrentAssignTag.tag = tag;
            objCurrentAssignTag.building = building;
            objCurrentAssignTag.room = room;

            bool result = objTagName.insertAssignedTags(objCurrentAssignTag);

            if (result == true)
            {
                MessageBox.Show("Succesfully Inserted");
                comboBox3.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
            }
            else 
            {
                MessageBox.Show("Insertion Failed");
            }
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

            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = ds.Tables[0].Columns[0].ToString();

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

            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = ds.Tables[0].Columns[0].ToString();

        }

      
    }
}
