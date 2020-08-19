using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyurvedicSystem.Controllers.AccessController
{
    class AccessCOntroller
    {
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        MySqlDataReader rd;
        int count;
        String user, privilages;
        bool status;


        public bool login(String username,String password)
        {
            string connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            MySqlConnection conn = new MySqlConnection(connetionString);
            String query = "select * from users where uname = '" + username + "' and pword ='" + password + "'";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    count = count + 1;
                    user = rd["name"].ToString();
                    privilages = rd["privilages"].ToString();
                }
                if (count == 1)
                {
                    status = true;
                    new FrmMain(user, privilages).Show();
                }
                else
                {
                    status = false;
                    MessageBox.Show("Please Enter a Valid Userame & Password");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return status;
        }

        public bool addUser(String name,String username,String password,String privilages)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into ayurvedicsystem.users (  name,uname,pword,privilages) values" +
                " ('" + name.ToUpper() + "','" + username.ToUpper() + "','" + password.ToUpper() + "','" + privilages + "')";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
            return status;
        }


        public List<String> searchUser(String username)
        {
            MySqlDataReader rd;
            String user = "", privilages = "";
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            List<String> userDetails = new List<string>();

            query = "select * from users where name = '" + username.ToUpper() + "' ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("ekek innwa");
                    count = count + 1;
                    String name, uname, password, priviages;

                    userDetails.Add (rd["name"].ToString());
                    userDetails.Add (rd["uname"].ToString());
                    userDetails.Add (rd["pword"].ToString());
                    userDetails.Add (rd["privilages"].ToString());
    
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return userDetails;
        }

        public void updateUser(String nameOld,String nameNew,String username,String password,String privilages)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "update ayurvedicsystem.users set uname = '" + username.ToUpper() + "',pword = '" + password + "',privilages = '" + privilages + "' where name='" + nameOld.ToUpper() + "' ";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
               
                conn.Close();
                MessageBox.Show("Updated Succefully...");
            }

            catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
               
            }

        }
    }
}
