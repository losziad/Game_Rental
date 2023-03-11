using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Configuration;
namespace Game_Rental
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_RentalDataSet.Admin' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region"Insert Into Sql"

            try
            {
                var connectionStringStk = ConfigurationManager.ConnectionStrings["Game_Rental.Properties.Settings.Game_RentalConnectionString"].ConnectionString;

                using (SqlConnection connExpDtls = new SqlConnection(ConfigurationManager.ConnectionStrings["Game_Rental.Properties.Settings.Game_RentalConnectionString"].ConnectionString))
                {
                    using (SqlCommand cmdExpDtls = new SqlCommand())
                    {
                        try
                        {


                            cmdExpDtls.CommandType = CommandType.Text;

                            cmdExpDtls.CommandText = cmdExpDtls.CommandText + " Insert Into Admin  (Fname,Lname,email,phone,password) Values (@Fname,@Lname,@email,@phone,@password) ";



                            cmdExpDtls.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = textBox1.Text;

                            cmdExpDtls.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = textBox2.Text;

                            cmdExpDtls.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBox3.Text;

                            cmdExpDtls.Parameters.Add("@phone", SqlDbType.NVarChar).Value = textBox4.Text;


                            cmdExpDtls.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox5.Text;

                            cmdExpDtls.Connection = connExpDtls;
                            connExpDtls.Open();
                            int rowsAffected = cmdExpDtls.ExecuteNonQuery();

                            string Messages = "";
                            Messages = Messages.ToString() +" Sign Up Succeded";
                            MessageBox.Show(Messages);



                        }
                        catch (Exception ex1)
                        {
                            label6.Text = label6.Text + "-" + ex1.ToString();
                        }
                        finally
                        {
                            connExpDtls.Close();
                        }

                    }

                }


            }
            catch (Exception ex0)
            {

                label6.Text = label6.Text + "-" + ex0.ToString();
            }
            finally
            {

                AdminOptions f = new AdminOptions();
                f.Show();
            }
           
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.adminTableAdapter.Fill(this.game_RentalDataSet.Admin);
        }
    }
}
