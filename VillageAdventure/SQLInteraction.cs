using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VillageAdventure
{
    class SQLInteraction
    {
        
        public static MySqlConnection con = new MySqlConnection();
        static MySqlCommand cmd;
       

        //Creates Database if not exists
        public static void CreateDatabase(string dbname)
        {
            
            try
            {
                con.ConnectionString = "server=web.hak-kitz.eu;database=a.promebner_VillageAdventure;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                string text = "CREATE DATABASE IF NOT EXISTS '" + dbname + "';";
                cmd = new MySqlCommand(text, con);
                //MessageBox.Show("Database opened!");
                con.Close();
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }
            
        }
        
        //Creates Table if not exists
        public static void CreateTable(string dbname, string tablename)
        {
            try
            {
                con.ConnectionString = "server=web.hak-kitz.eu;database=a.promebner_VillageAdventure;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                string text = "use [" + dbname + "] if not exists(select * from sysobjects where name = '" + tablename + "') begin create table " + tablename + "(Id int NOT NULL Primary Key,username varchar(20),password varchar(70)) end";
                cmd = new MySqlCommand(text, con);
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Login Check for the password
        public static void CheckTable(string tablename, string v_username, string v_password)
        {
            string hashedpw;
            try
            {
                con.ConnectionString = "server=web.hak-kitz.eu;database=a.promebner_VillageAdventure;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                cmd.CommandText = "Select password From Login Where username='" + v_username + "'";
                hashedpw = (string)cmd.ExecuteScalar();
                //hashedpw = v_password;
                if(hashedpw != null)
                {
                    if(BCrypt.CheckPassword(v_password, hashedpw))
                    {
                        MessageBox.Show("You are now logged in!","Logged In!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!","Error!");
                    }
                }
                con.Close(); 
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //New Account inserts into the database 
        public static void InsertInto(string tablename, string v_username, string v_password)
        {

            try
            {
                con.ConnectionString = "server=web.hak-kitz.eu;database=a.promebner_VillageAdventure;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                cmd.CommandText = "INSERT INTO " + tablename +"(username,password) VALUES('" + v_username + "', '" + v_password + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
