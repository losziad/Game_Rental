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
    public partial class ClientAccount : Form
    {
        public ClientAccount()
        {
            InitializeComponent();
        }

        private void ClientAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_RentalDataSet.Client' table. You can move, or remove it, as needed.
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.game_RentalDataSet.Client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region"Update Into Sql"

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

                            cmdExpDtls.CommandText = cmdExpDtls.CommandText + " update Client set Gender = @Gender,Fname = @Fname,Lname = @Lname,phone = @phone,Age = @Age ,NumberOfRenteredGames = @NumberOfRenteredGames,email = @email,GID=@GID,password=@password ";

                            cmdExpDtls.CommandText = cmdExpDtls.CommandText + " where Fname = @Fname and Lname = @Lname";


                            cmdExpDtls.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = textBox1.Text;

                            cmdExpDtls.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = textBox2.Text;

                            cmdExpDtls.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = textBox3.Text;

                            cmdExpDtls.Parameters.Add("@Age", SqlDbType.Int).Value = textBox4.Text;

                            cmdExpDtls.Parameters.Add("@phone", SqlDbType.NVarChar).Value = textBox5.Text;

                            cmdExpDtls.Parameters.Add("@NumberOfRenteredGames", SqlDbType.Int).Value = textBox6.Text;

                            cmdExpDtls.Parameters.Add("@GID", SqlDbType.Int).Value = textBox7.Text;

                            cmdExpDtls.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBox8.Text;

                            cmdExpDtls.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox9.Text;

                            cmdExpDtls.Connection = connExpDtls;
                            connExpDtls.Open();
                            int rowsAffected = cmdExpDtls.ExecuteNonQuery();

                            string Messages = "";
                            Messages = Messages.ToString() +" Updated Succefully";
                            MessageBox.Show(Messages);



                        }
                        catch (Exception ex1)
                        {
                            label10.Text = label10.Text + "-" + ex1.ToString();
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

                label10.Text = label10.Text + "-" + ex0.ToString();
            }
            finally
            {


            }

            #endregion
        }
    }
}
