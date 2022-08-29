using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MarketplaceApp
{
    public partial class SignUp : Form
    {
        public string _sqlConnectionStr = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        public SignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            User user = new User(textBoxSignUpName.Text, textBoxSignUpEmail.Text, textBoxSignUpUsername.Text, textBoxSignUpPassword.Text);
            string checkFields = user.SignUpCheckFields();

            if (!checkBoxAgree.Checked)
            {
                MessageBox.Show("Please check the Terms and Conditions.");
            }

            else if (checkBoxAgree.Checked)
            {
                if (checkFields == "")
                {
                    using (SqlConnection con = new SqlConnection(_sqlConnectionStr))
                    {

                        SqlCommand cmd = new SqlCommand("AddNewUser", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("Name", SqlDbType.VarChar, 50).Value = textBoxSignUpName.Text;
                        cmd.Parameters.Add("Email", SqlDbType.VarChar, 50).Value = textBoxSignUpEmail.Text;
                        cmd.Parameters.Add("Username", SqlDbType.VarChar, 50).Value = textBoxSignUpUsername.Text;
                        cmd.Parameters.Add("Password", SqlDbType.VarChar, 50).Value = textBoxSignUpPassword.Text;

                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Thank you for becoming a member " + textBoxSignUpName.Text + ".");
                   
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("The following information is missing: " + checkFields + "\n\nPlease fill out all the information needed.");
                }
            }                  
        }

        private void buttonSignUpBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
