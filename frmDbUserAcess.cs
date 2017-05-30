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
using Dapper.FastCrud;
using Dapper;

namespace DbUserManagement
{
    public partial class frmDbUserAcess : Form
    {
        public frmDbUserAcess()
        {
            InitializeComponent();
            txtLoginUser.Text = EnvironmentVariables.DefaultServerUser;
            txtAdminPassword.Text = EnvironmentVariables.DefaultServerPwd;
            txtDatabase.Text = EnvironmentVariables.DefaultDatabase;
            txtServer.Text = EnvironmentVariables.DefaultServer;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (
                var connection =
                    new SqlConnection(
                        $"Data Source={txtServer.Text};Initial Catalog={txtDatabase.Text};User ID = {txtLoginUser.Text}; Password = {txtAdminPassword.Text};")
            )
            {
                connection.Open();
                //if (connection.State == ConnectionState.Open)
                //    MessageBox.Show("Connection Success!");
                //Get all users
                var selectedItem = comboBox1.SelectedItem.ToString();

                var sql = "";
                if (selectedItem == "View")
                {
                    foreach (var view in ObjectList.SelectedItems)
                    {
                        sql += $"grant select on {view} to {UserList.SelectedItem};";
                    }
                }

                if (selectedItem == "Table")
                {
                    foreach (var view in ObjectList.SelectedItems)
                    {
                        sql += $"grant select on {view} to {UserList.SelectedItem};";
                    }
                }
                if (selectedItem == "Stored Procedure")
                {
                    foreach (var view in ObjectList.SelectedItems)
                    {
                        sql += $"grant execute on {view} to {UserList.SelectedItem};";
                    }
                }

                if (sql != "")
                {
                    var data = connection.Query<string>(sql);
                    //Load users to dropdown
                    ObjectList.Items.AddRange(data.ToArray());

                    MessageBox.Show($"User {UserList.SelectedItem} now has access to {ObjectList.SelectedItem}");
                }
                else
                {
                    MessageBox.Show("Please select object type");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadObjectList();
        }

        private void LoadObjectList()
        {
            ObjectList.Items.Clear();
            //Load users to dropdown
            var data = GetDbObjects();
            ObjectList.Items.AddRange(data.ToArray());
            var autoc = new AutoCompleteStringCollection();
            autoc.AddRange(data.ToArray());
            txtSearchObject.AutoCompleteCustomSource = autoc;
        }

        private IEnumerable<string> GetDbObjects()
        {
            string searchText = txtSearchObject.Text;
            IEnumerable<string> data = new List<string>(); ;
            using (
                var connection =
                    new SqlConnection(
                        $"Data Source={txtServer.Text};Initial Catalog={txtDatabase.Text};User ID = {txtLoginUser.Text}; Password = {txtAdminPassword.Text};")
            )
            {
                connection.Open();
                //if (connection.State == ConnectionState.Open)
                //    MessageBox.Show("Connection Success!");
                //Get all users
                var selectedItem = comboBox1.SelectedItem?.ToString();

                var sql = "";
                if (selectedItem == "View")
                    sql = $"select * from sysobjects sobjects WHERE sobjects.xtype = 'V' and name like '%{searchText}%'";
                if (selectedItem == "Table")
                    sql = $"select * from sysobjects sobjects WHERE sobjects.xtype = 'U' and name like '%{searchText}%'";
                if (selectedItem == "Stored Procedure")
                    sql = $"select * from sysobjects sobjects WHERE sobjects.xtype = 'P' and name like '%{searchText}%'";

                if (sql != "")
                {
                    data = connection.Query<string>(sql);
                    
                }
                else
                {
                    MessageBox.Show("Please select object type");
                }
                return data;
            }
        }

        private void txtSearchObject_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LoadObjectList();
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            using (var connection =
                    new SqlConnection(
                        $"Data Source={txtServer.Text};Initial Catalog={txtDatabase.Text};User ID = {txtLoginUser.Text}; Password = {txtAdminPassword.Text};")
            )
            {
                connection.Open();
                //if (connection.State == ConnectionState.Open)
                //    MessageBox.Show("Connection Success!");

                try
                {
                    //Get all users
                    var data = connection.Query<string>($"create user {txtNewUser.Text} for login {txtNewUserLogin.Text}");

                    //Load users to dropdown
                    UserList.Items.AddRange(data.ToArray());
                    MessageBox.Show("User created successfully.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"{ex.Message}");
                }
            }
        }


        public void TestConnection()
        {
            UserList.Items.Clear();
            using (var connection =
                    new SqlConnection($"Data Source={txtServer.Text};Initial Catalog={txtDatabase.Text};User ID = {txtLoginUser.Text}; Password = {txtAdminPassword.Text};"))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                        MessageBox.Show("Success !");
                    //Get all users
                    var data = connection.Query<string>("SELECT name FROM sys.database_principals where type_desc = 'SQL_User'");

                    //Load users to dropdown
                    UserList.Items.AddRange(data.ToArray());
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection Failed !");
                }
            }
        }

        private void btnRefreshConnection_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void txtSearchObject_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
           
            using (var connection = new SqlConnection($"Data Source={txtServer.Text};Initial Catalog=master;User ID = {txtLoginUser.Text}; Password = {txtAdminPassword.Text};"))
            {
                using (var transaction = connection.BeginTransaction())
                {
                    var sql =
                   $"create login {txtNewLoginName.Text} with password {txtNewLoginPassword.Text}, DEFAULT_DATABASE=[{txtDefaultLoginDatabase.Text}], DEFAULT_LANGUAGE=[British], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON';";

                    foreach (var role in chkDbLoginRoles.Items)
                    {
                        sql += $"sys.sp_addsrvrolemember @loginname = '{txtNewLoginName.Text}', @rolename = '{role}'";
                    }
                   var rowsEffected =  connection.Execute(sql);
                    MessageBox.Show("Login created successfully.");
                }
            }

        }
    }
}
