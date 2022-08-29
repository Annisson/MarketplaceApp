using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MarketplaceApp
{
    public partial class Form1 : Form
    {
        public string _sqlConnectionStr = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        SqlConnection con;
        int userIDLoggedIn = 0;
        string usernameLoggedIn = "";
        int selectedAdID = 0;
        int selectedADUserID = 0;

        public Form1()
        {
            con = new SqlConnection(_sqlConnectionStr);
            InitializeComponent();
            ShowCategoriesSearch();
            Guest();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter both Username and Password to login.");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
                {
                    string name = textBoxUsername.Text;
                    string pwd = textBoxPassword.Text;

                    SqlCommand cmdLogin = new SqlCommand("SELECT * FROM Users WHERE Username = '" + name + "' AND Password = '" + pwd + "'", conn);
                    SqlCommand cmdName = new SqlCommand("SELECT Username FROM Users WHERE Username = '" + name + "' AND Password = '" + pwd + "'", conn);
                    SqlCommand cmdID = new SqlCommand("SELECT ID FROM Users WHERE Username = '" + name + "' AND Password = '" + pwd + "'", conn);

                    conn.Open();
                    cmdLogin.ExecuteNonQuery();

                    var username = cmdName.ExecuteScalar();
                    var id = cmdID.ExecuteScalar();

                    SqlDataReader reader = cmdLogin.ExecuteReader();
                    if (reader.HasRows)
                    {
                        LoggedIn();
                        userIDLoggedIn = Convert.ToInt32(id);
                        usernameLoggedIn = Convert.ToString(username);
                        textBoxLoggedInAs.Text = usernameLoggedIn;
                        MessageBox.Show("Logged in");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("User and Password entered is incorrect.");
                        Guest();
                    }                      
                }
            }                      
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Guest();
            MessageBox.Show("Logged out");
        }

        private void labelNewMember_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string categoryStr = comboBoxSearchCategory.Text;

            if (textBoxSearch.Text != "" && comboBoxSearchCategory.Text != "Select Category")
            {
                using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
                {
                    int categoryID = 0;
                    SqlCommand cmdID = new SqlCommand("SELECT ID FROM Categories WHERE Type = '" + categoryStr + "'", conn);

                    conn.Open();
                    var id = cmdID.ExecuteScalar();
                    categoryID = Convert.ToInt32(id);

                    SqlCommand cmd = new SqlCommand("SELECT Title, Price, Date FROM Ads WHERE Title LIKE '%" + textBoxSearch.Text + "%' OR " +
                        "Description LIKE '%" + textBoxSearch.Text + "%' AND CategoryID = '" + categoryID + "'", conn);
                
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridViewResults.DataSource = dt;
                }

            }
            else if (textBoxSearch.Text != "" && comboBoxSearchCategory.Text == "Select Category")
            {
                using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
                {                 
                    SqlCommand cmd = new SqlCommand("SELECT Title, Price, Date FROM Ads WHERE Title LIKE '%" + textBoxSearch.Text + "%' OR " +
                        "Description LIKE '%" + textBoxSearch.Text + "%'", conn);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridViewResults.DataSource = dt;
                }
            }
            else if (textBoxSearch.Text == "" && comboBoxSearchCategory.Text != "Select Category")
            {
                using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
                {
                    int categoryID = 0;
                    SqlCommand cmdID = new SqlCommand("SELECT ID FROM Categories WHERE Type = '" + categoryStr + "'", conn);

                    conn.Open();
                    var id = cmdID.ExecuteScalar();
                    categoryID = Convert.ToInt32(id);

                    SqlCommand cmd = new SqlCommand("SELECT Title, Price, Date FROM Ads WHERE CategoryID = '" + categoryID + "'", conn);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridViewResults.DataSource = dt;
                }

            }

        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonCreateAD.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewResults.Rows[e.RowIndex];

                string title = row.Cells["Title"].Value.ToString();
                string date = row.Cells["Date"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Ads WHERE Title = '" + title + "' AND Date = '" + date + "'", conn);

                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    var adIDDt = dt.Rows[0][0].ToString();
                    var titleDt = dt.Rows[0][1].ToString();
                    var descriptionDt = dt.Rows[0][2].ToString();
                    var priceDt = dt.Rows[0][3].ToString();
                    var categoryIDDt = dt.Rows[0][4].ToString();
                    var userIDDt = dt.Rows[0][5].ToString();
                    var dateDt = dt.Rows[0][6].ToString();

                    selectedAdID = Convert.ToInt32(adIDDt);
                    selectedADUserID = Convert.ToInt32(userIDDt);

                    SqlCommand categoryCmd = new SqlCommand("SELECT Type FROM Categories WHERE ID = '" + categoryIDDt + "'", conn);
                    var categoryExec = categoryCmd.ExecuteScalar();
                    string categoryType = Convert.ToString(categoryExec);

                    textBoxTitle.Text = titleDt;
                    comboBoxDetailsCategory.Text = categoryType;
                    textBoxDate.Text = dateDt;
                    textBoxPrice.Text = priceDt;
                    textBoxDescription.Text = descriptionDt;
                }
                
                ToolTip toolTip = new ToolTip();

                if (selectedADUserID == userIDLoggedIn)
                {
                    buttonUpdateAD.Enabled = true;
                    buttonRemoveAD.Enabled = true;
                    buttonContactSeller.Enabled = false;

                }
                else if (selectedADUserID != userIDLoggedIn)
                {
                    buttonUpdateAD.Enabled = false;
                    buttonRemoveAD.Enabled = false;
                    buttonContactSeller.Enabled = true;
                }
            }
        }

        private void buttonCreateAD_Click(object sender, EventArgs e)
        {
            string categoryStr = comboBoxDetailsCategory.Text;

            Ads ads = new Ads(textBoxTitle.Text, categoryStr, textBoxPrice.Text, textBoxDescription.Text, userIDLoggedIn, DateTime.Now);
            string checkFields = ads.AdsCheckFields();

            if (checkFields == "")
            {
                if (int.TryParse(textBoxPrice.Text, out int userPrice))
{
                    using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
                    {

                        SqlCommand cmd = new SqlCommand("CreateNewAD", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        int categoryID = 0;
                        SqlCommand cmdID = new SqlCommand("SELECT ID FROM Categories WHERE Type = '" + categoryStr + "'", conn);

                        conn.Open();
                        var id = cmdID.ExecuteScalar();
                        categoryID = Convert.ToInt32(id);

                        cmd.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = textBoxTitle.Text;
                        cmd.Parameters.Add("Description", SqlDbType.VarChar, 300).Value = textBoxDescription.Text;
                        cmd.Parameters.Add("Price", SqlDbType.Int).Value = textBoxPrice.Text;
                        cmd.Parameters.Add("CategoryID", SqlDbType.Int).Value = categoryID;
                        cmd.Parameters.Add("UserID", SqlDbType.Int).Value = userIDLoggedIn;
                        cmd.Parameters.Add("Date", SqlDbType.SmallDateTime).Value = DateTime.Now;

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Your AD for '" + textBoxTitle.Text + "' has been created.");
                    ClearFields();
                }
                else
                { 
                    MessageBox.Show("Price must be a numeric value."); 
                }               

            }
            else
            {
                MessageBox.Show("The following information is missing: " + checkFields + "\n\nPlease fill out all the information needed.");
            }
        }

        private void buttonRemoveAD_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
            {
                SqlCommand cmd = new SqlCommand("RemoveAD", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("ID", SqlDbType.Int).Value = selectedAdID;
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Your AD for '" + textBoxTitle.Text + "' has been removed.");
            ClearFields();
        }

        private void buttonUpdateAD_Click(object sender, EventArgs e)
        {
            string categoryStr = comboBoxDetailsCategory.Text;

            using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
            {
                SqlCommand cmd = new SqlCommand("UpdateAD", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                int categoryID = 0;
                SqlCommand cmdID = new SqlCommand("SELECT ID FROM Categories WHERE Type = '" + categoryStr + "'", conn);

                conn.Open();
                var id = cmdID.ExecuteScalar();
                categoryID = Convert.ToInt32(id);

                cmd.Parameters.Add("ID", SqlDbType.Int).Value = selectedAdID;
                cmd.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = textBoxTitle.Text;
                cmd.Parameters.Add("Description", SqlDbType.VarChar, 300).Value = textBoxDescription.Text;
                cmd.Parameters.Add("Price", SqlDbType.Int).Value = textBoxPrice.Text;
                cmd.Parameters.Add("CategoryID", SqlDbType.Int).Value = categoryID;
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Your AD for '" + textBoxTitle.Text + "' has been updated.");
        }

        public void labelClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonContactSeller_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacting seller...beep boop");
        }

        private void ShowCategoriesSearch() 
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Type FROM Categories", con))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.NewRow();
                row[0] = "Select Category";
                dt.Rows.InsertAt(row, 0);

                comboBoxSearchCategory.DisplayMember = "Type";
                comboBoxSearchCategory.DataSource = dt;
            }
        }
        private void ShowCategoriesAds() 
        {
            using (SqlConnection conn = new SqlConnection(_sqlConnectionStr))
             {
                SqlCommand cmd = new SqlCommand("SELECT Type FROM Categories", conn);
            
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.NewRow();
                row[0] = "Select Category";
                dt.Rows.InsertAt(row, 0);

                comboBoxDetailsCategory.DisplayMember = "Type";
                comboBoxDetailsCategory.DataSource = dt;

            }

        }
        private void ClearFields()
        {
            textBoxTitle.Text = "";
            ShowCategoriesAds();
            textBoxDate.Text = DateTime.Now.ToShortDateString();
            textBoxPrice.Text = "";
            textBoxDescription.Text = "";
            buttonCreateAD.Enabled = true;
            buttonUpdateAD.Enabled = false;
            buttonRemoveAD.Enabled = false;
        }

        private void Guest()
        {
            textBoxLoggedInAs.Text = "Guest";
            userIDLoggedIn = 0;
            buttonLogout.Visible = false;
            buttonCreateAD.Visible = false;
            buttonUpdateAD.Visible = false;
            buttonRemoveAD.Visible = false;
            labelF1Username.Visible = true;
            labelF1Password.Visible = true;
            textBoxUsername.Visible = true;
            textBoxUsername.Text = "";
            textBoxPassword.Visible = true;
            textBoxPassword.Text = "";
            labelNewMember.Visible = true;
            buttonLogin.Visible = true;
            buttonContactSeller.Enabled = true;
        }

        private void LoggedIn()
        {
            ShowCategoriesAds();
            textBoxDate.Text = DateTime.Now.ToShortDateString();
            buttonLogout.Visible = true;
            buttonCreateAD.Visible = true;
            buttonUpdateAD.Visible = true;
            buttonUpdateAD.Enabled = false;
            buttonRemoveAD.Visible = true;
            buttonRemoveAD.Enabled = false;
            labelF1Username.Visible = false;
            labelF1Password.Visible = false;
            textBoxUsername.Visible = false;
            textBoxPassword.Visible = false;
            labelNewMember.Visible = false;
            buttonLogin.Visible = false;
            buttonContactSeller.Enabled = false;
        }

    }
    
}
