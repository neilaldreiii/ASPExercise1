using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo
{
    public partial class Registration : System.Web.UI.Page
    {
        //mysql info
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        string queryStr;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerEventMethod(object sender, EventArgs e)
        {
            registerUser();
        }
        private void registerUser()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["webconfigstring"].ToString();

            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "";

            queryStr = "INSERT INTO `webappdemo.userregistration` " +
                "(firstname, middlename, lastname, email, phonenumber, username, password)" +
                "VALUES ('" + FirstnameTextBox.Text + "', '" + MiddlenameTextBox.Text + "', '" + LastnameTextBox.Text + "','" + EmailTextBox.Text + "','" + PhonenumberTextBox.Text + "','" + UsernameTextBox.Text + "', '" + PasswordTextBox.Text +"')";

            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
            cmd.ExecuteReader();

            conn.Close();
        }
    }
}