using CollegeCore.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCore.Infrastructure
{
    public class RoomCore
    {
        public void insertRoomDetails(RoomModel objRoom)
        {
            try
            {
                string Query = "Insert into rooms(Room_Name,Room_Block,Building,Capacity,Room_Type) values('" + objRoom.Room_Name + "','" + objRoom.Room_Block + "','" + objRoom.Building + "','" + objRoom.Capacity + "','" + objRoom.Room_Type + "')";
                

                SqlCommand cmd = new SqlCommand(Query, DBConnection.DatabaseConnection);
                SqlDataReader myReader;
                DBConnection.OpenConnection();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                DBConnection.CloseConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<RoomModel> getRoomDetails()
        {
            List<RoomModel> listRooms = new List<RoomModel>();
            try
            {
                string Query = "Select Room_Name,Room_Block,Building,Capacity,Room_Type from rooms";
                

                SqlCommand cmd = new SqlCommand(Query, DBConnection.DatabaseConnection);
                SqlDataReader myReader;
                DBConnection.OpenConnection();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    RoomModel objRoomModel = new RoomModel();
                    objRoomModel.Room_Name = myReader["Room_Name"].ToString();
                    objRoomModel.Room_Block = myReader["Room_Block"].ToString();
                    objRoomModel.Building = myReader["Building"].ToString();
                    objRoomModel.Capacity = myReader["Capacity"].ToString();
                    objRoomModel.Room_Type = myReader["Room_Type"].ToString();
                    listRooms.Add(objRoomModel);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return listRooms;
        }

       

        public void updateRoomDetails(RoomModel objRoom, RoomModel objPrevRoom)
        {
            try
            {
                string Query = "Update rooms SET room_name = '" + objRoom.Room_Name + "' , room_block = '" + objRoom.Room_Block + "' , Building = '" + objRoom.Building + "' , Capacity = '" + objRoom.Capacity + "' , room_type = '" + objRoom.Room_Type + "' where room_name = '" + objPrevRoom.Room_Name + "' and room_block = '" + objPrevRoom.Room_Block + "' and Building = '" + objPrevRoom.Building + "' and Capacity = '" + objPrevRoom.Capacity + "' and room_type = '" + objPrevRoom.Room_Type + "'";
                

                SqlCommand cmd = new SqlCommand(Query, DBConnection.DatabaseConnection);
                SqlDataReader myReader;
                DBConnection.OpenConnection();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                DBConnection.CloseConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void deleteRoomDetails(RoomModel objRoom)
        {
            try
            {
                string Query = "Delete from rooms where room_name = '" + objRoom.Room_Name + "' and room_block = '" + objRoom.Room_Block + "' and Building = '" + objRoom.Building + "' and Capacity = '" + objRoom.Capacity + "' and room_type = '" + objRoom.Room_Type + "'";
                

                SqlCommand cmd = new SqlCommand(Query, DBConnection.DatabaseConnection);
                SqlDataReader myReader;
                DBConnection.OpenConnection();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                DBConnection.CloseConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public List<RoomModel> getBuildings()
        {
            List<RoomModel> listBuldings = new List<RoomModel>();
            try
            {
                string Query = "Select tag,building,room,lecturer from AssignTagRoom";
                

                SqlCommand cmd = new SqlCommand(Query, DBConnection.DatabaseConnection);
                SqlDataReader myReader;
                DBConnection.OpenConnection();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    RoomModel objBuildings = new RoomModel();

                    objBuildings.Building = myReader["Building"].ToString();

                    listBuldings.Add(objBuildings);
                }
            }
            catch (Exception ex)
            {

            }

            return listBuldings;
        }
    }
}
