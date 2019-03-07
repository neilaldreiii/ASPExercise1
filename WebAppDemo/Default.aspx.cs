using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo
{
    public partial class Default : System.Web.UI.Page
    {
        //MySQL Connection
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String queryStr;
        String name;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitEventMethod(object sender, EventArgs e)
        {
            /*
             * 
             * Checks if a user tries to do sql injection for input form
             * 
             */
            if(checkAgainstWhiteList(usernameTextBox.Text) == true && 
                checkAgainstWhiteList(passwordTextBox.Text) == true)
            {
                DoSQLQuery();
            }

            else
            {
                passwordTextBox.Text = "Wadu Hek!";
            }
        }

        //Check to see if user input is valid
        private bool checkAgainstWhiteList(String userInput)
        {
            var regExpression = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9]*$");

            if(regExpression.IsMatch(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Actual query
        private void DoSQLQuery()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();
                queryStr = "";


                //Adding place holders to prevent sql injection

                queryStr = "SELECT * FROM `userregistration` WHERE `username`=?uname AND `password`=?pword";

                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                //Treats user inputs as an actual string instead of a query
                cmd.Parameters.AddWithValue("?uname", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("?pword", passwordTextBox.Text);

                reader = cmd.ExecuteReader();

                name = "";
                while (reader.HasRows && reader.Read())
                {
                    name = reader.GetString(reader.GetOrdinal("firstname")) + " " + reader.GetString(reader.GetOrdinal("middlename")) + " " +
                        reader.GetString(reader.GetOrdinal("lastname"));
                }

                if (reader.HasRows)
                {
                    //store session
                    Session["uname"] = name;
                    Response.BufferOutput = true;
                    Response.Redirect("LoggedIn.aspx", false);
                }
                else
                {
                    passwordTextBox.Text = "Invalid user";
                }

                reader.Close();
                conn.Close();
            }
            catch(Exception e)
            {
                passwordTextBox.Text = e.ToString();
            }
        }
    }
}