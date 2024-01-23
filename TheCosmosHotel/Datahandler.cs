using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheCosmosHotel
{
    class Datahandler
    {
        static SqlConnection connect = new SqlConnection(@"Data Source= PC\SQLEXPRESS; Initial Catalog= TheCosmosHotel; Integrated Security = SSPI");
        string query;
        List<Customer> MyCustList = new List<Customer>();
        List<Booking> MyBooksList = new List<Booking>();
        List<Room> MyRoomsList = new List<Room>();
        List<Login> Users = new List<Login>();
        public List<Room> ViewAllRooms()
        {
            try
            {
                SqlDataReader Reader = null;
                connect.Open();
                query = "Select * from tblRoom";
                SqlCommand command = new SqlCommand(query, connect);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    MyRoomsList.Add(new Room(Reader.GetInt16(0), Reader[1].ToString(), Reader.GetDouble(2), Reader[3].ToString()));
                }
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
            }
            return MyRoomsList;
        }
        public List<Booking> ViewBooking()
        {
            try
            {
                SqlDataReader Reader = null;
                connect.Open();
                query = "Select * from tblBookings";
                SqlCommand command = new SqlCommand(query, connect);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    MyBooksList.Add(new Booking(Reader.GetInt16(0), Reader[1].ToString(), Reader.GetInt16(2), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString(), Reader[7].ToString(), Reader[8].ToString(), Reader[9].ToString()));
                }
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
            }
            return MyBooksList;
        }

        public List<Customer> ViewAllCustomers()
        {
            try
            {
                SqlDataReader Reader = null;
                connect.Open();
                query = "Select * from tblCustomer";
                SqlCommand command = new SqlCommand(query, connect);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    MyCustList.Add(new Customer(Reader.GetInt16(0), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString(), Reader[7].ToString(), Reader[8].ToString()));
                }
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MyCustList;
        }
        public void InsertBooking(Booking book)
        {
            try
            {
                connect.Open();
                query = "Insert Into tblBookings(bookingDate, customerID, RoomID, proposedCheckInDate,proposedCheckOutDate) Values('" + book.BookingDate + "','" + book.CustomerID + "','" + book.RoomID + "','" + book.ProposedCheckInDate + "','" + book.ProposedCheckoutDate + "')";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
            }
        }
        public void InsertCustomer(Customer cust)
        {
            try
            {
                connect.Open();
                query = "Insert Into tblCustomer(FirstName, Surname, Gender, DateOfBirth, Nationality, PhoneNumber, Email, CreditRating) Values('" + cust.Firstname + "','" + cust.Lastname + "','" + cust.Gender + "','" + cust.DateOfBirth + "','" + cust.Nationality + "','" + cust.Phonenumber + "','" + cust.Email + "','" + cust.Creditrating + "')";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
            }
        }
        public void DeleteBooking(string bookingID)
        {
            try
            {
                connect.Open();
                query = "Delete from tblBookings Where bookingId= '" + bookingID + "'";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
            }
        }
        public void DeleteBookingByCustomer(int CustomerID)
        {
            try
            {
                connect.Open();
                query = "Delete * from tblBookings Where customerID= '" + CustomerID + "'";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
            }
        }
        public void UpdateBooking(int bookindID, string newRoomType, string newRoomNumber, string actualIn, string actualOut)
        {
            try
            {
                connect.Open();
                query = "Update tblBookings Set actualCheckInDate='"+actualIn+ "' ,actualCheckOutDate='"+actualOut+ "',RoomID='"+newRoomNumber+ "',RoomType='"+newRoomType+ "' Where bookingId= '" + bookindID+"'";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CancelBooking(int bookindID, string cancelDate, string reason )
        {
            try
            {
                connect.Open();
                query = "Update tblBookings Set cancellationDATE='"+cancelDate+ "', cancellationReason='"+reason+"'  Where bookingId= '" + bookindID + "'";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateCustomer(Customer cust)
        {
            try
            {
                connect.Open();
                query = "Update tblCustomer Set FirstName='" + cust.Firstname + "',Surname='" + cust.Lastname + "',Gender='" + cust.Gender + "',DateOfBirth='" + cust.DateOfBirth + "',PhoneNumber='" + cust.Phonenumber + "',Email='" + cust.Email + "',CreditRating='" + cust.Creditrating + "', Nationality='"+cust.Nationality+"' Where CustomerID='"+cust.CustomerID+"'";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Booking> SearchBooking(int id)
        {
            try
            {
                SqlDataReader Reader = null;
                connect.Open();
                query = "Select * from tblBookings where BookingID='" + id + "'";
                SqlCommand command = new SqlCommand(query, connect);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    MyBooksList.Add(new Booking(Reader.GetInt16(0), Reader[1].ToString(), Reader.GetInt16(2) , Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString(), Reader[7].ToString(), Reader[8].ToString(), Reader[9].ToString()));
                }
                connect.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            return MyBooksList;
        }
        public List<Login> GetUsers()
        {
            try
            {
                SqlDataReader Reader = null;
                connect.Open();
                query = " Select * from tblUsers";
                SqlCommand command = new SqlCommand(query, connect);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Users.Add(new Login(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString()));
                }

                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Users;
        }
        public void UpdateRoom(string r, string num)
        {
            try
            {
                connect.Open();
                query = "Update tblRoom Set RoomStatus='" + r + "' Where roomNo = '"+ num+ "'";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteCustomer(int CustomerID)
        {
            try
            {
                connect.Open();
                query = "Delete * from tblCustomer Where CustomerID='"+CustomerID+"'";
                SqlCommand command = new SqlCommand(query, connect);
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Information", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
