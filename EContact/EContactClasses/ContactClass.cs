using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EContact.EContactClasses
{
    class ContactClass
    {
        //getter and setter
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gendar { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["conn_string"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //db connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //writting sql query
                String sql = "SELECT * FROM tbl_contact";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;   
        }

        //inserting data
        public bool Insert(ContactClass c)
        {
            //create a default return type and setting its value to false
            bool isSuccess = false;

            //connect db
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to insert
                string sql = "INSERT INTO tbl_contact(FirstName, LastName, ContactNo, Address, Gendar) VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gendar)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@FLastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gendar", c.Gendar);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //UPDATE DB
        public bool Update(ContactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gendar=@Gendar WHERE ContactID=@ContactID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameters
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@FLastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gendar", c.Gendar);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                
                
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }  
  
        //DELETE FROM DB
        public bool Delete(ContactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbl_contact WHERE ContactID =@ContactId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

               if (rows>0)
	           {
		            isSuccess = true;
	           }
               else
               {
                   isSuccess = false;
               }
            }
            catch (Exception ex)
            {
                
                
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

    }

}
