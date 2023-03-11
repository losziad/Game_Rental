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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_RentalDataSet.Game' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click_1(object sender, EventArgs e)
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
                           
                            cmdExpDtls.CommandText = cmdExpDtls.CommandText + " Insert Into Game  (GID,Vendor,Gname,Category,NumberofRenters,publishedYear,publishedMonth) Values (@GID,@Vendor,@Gname,@Category,@NumberofRenters,@publishedYear,@publishedMonth) ";



                            cmdExpDtls.Parameters.Add("@GID", SqlDbType.Int).Value = textBox1.Text;

                            cmdExpDtls.Parameters.Add("@Vendor", SqlDbType.NVarChar).Value = textBox7.Text;

                            cmdExpDtls.Parameters.Add("@Gname", SqlDbType.NVarChar).Value = textBox2.Text;

                            cmdExpDtls.Parameters.Add("@Category", SqlDbType.NVarChar).Value = textBox3.Text;



                            cmdExpDtls.Parameters.Add("@NumberofRenters", SqlDbType.Int).Value = textBox4.Text;


                            cmdExpDtls.Parameters.Add("@publishedYear", SqlDbType.Int).Value = textBox5.Text;


                            cmdExpDtls.Parameters.Add("@publishedMonth", SqlDbType.Int).Value = textBox6.Text;




                            cmdExpDtls.Connection = connExpDtls;
                            connExpDtls.Open();
                            int rowsAffected = cmdExpDtls.ExecuteNonQuery();

                            string Messages = "";
                            Messages = Messages.ToString()+"Game " + textBox1.Text+ " Inserted Succefully" ;
                            MessageBox.Show(Messages);



                        }
                        catch (Exception ex1)
                        {
                            label8.Text = label8.Text + "-" + ex1.ToString();
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

                label8.Text = label8.Text + "-" + ex0.ToString();
            }
            finally
            {


            }

            #endregion


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.gameTableAdapter.Fill(this.game_RentalDataSet.Game);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            #region"Delete from Sql"

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

                            cmdExpDtls.CommandText = cmdExpDtls.CommandText + " delete from Game where GID = '" + textBox1.Text +"'";
                            cmdExpDtls.Connection = connExpDtls;
                            connExpDtls.Open();
                            int rowsAffected = cmdExpDtls.ExecuteNonQuery();

                            string Messages = "";
                            Messages = Messages.ToString() + "Game " + textBox1.Text + " Deleted Succefully";
                            MessageBox.Show(Messages);



                        }
                        catch (Exception ex1)
                        {
                            label8.Text = label8.Text + "-" + ex1.ToString();
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

                label8.Text = label8.Text + "-" + ex0.ToString();
            }
            finally
            {


            }

            #endregion


        }

        private void button2_Click(object sender, EventArgs e)
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

                            cmdExpDtls.CommandText = cmdExpDtls.CommandText + " update Game set GID = @GID,Vendor = @Vendor,Gname = @Gname,Category = @Category,NumberofRenters = @NumberofRenters ,publishedYear = @publishedYear,publishedMonth = @publishedMonth ";

                            cmdExpDtls.CommandText = cmdExpDtls.CommandText + " where GID = @GID ";




                            cmdExpDtls.Parameters.Add("@GID", SqlDbType.Int).Value = textBox1.Text;

                            cmdExpDtls.Parameters.Add("@Vendor", SqlDbType.NVarChar).Value = textBox7.Text;

                            cmdExpDtls.Parameters.Add("@Gname", SqlDbType.NVarChar).Value = textBox2.Text;

                            cmdExpDtls.Parameters.Add("@Category", SqlDbType.NVarChar).Value = textBox3.Text;



                            cmdExpDtls.Parameters.Add("@NumberofRenters", SqlDbType.Int).Value = textBox4.Text;


                            cmdExpDtls.Parameters.Add("@publishedYear", SqlDbType.Int).Value = textBox5.Text;


                            cmdExpDtls.Parameters.Add("@publishedMonth", SqlDbType.Int).Value = textBox6.Text;

                            cmdExpDtls.Connection = connExpDtls;
                            connExpDtls.Open();
                            int rowsAffected = cmdExpDtls.ExecuteNonQuery();

                            string Messages = "";
                            Messages = Messages.ToString() + "Game " + textBox1.Text + " Updated Succefully";
                            MessageBox.Show(Messages);



                        }
                        catch (Exception ex1)
                        {
                            label8.Text = label8.Text + "-" + ex1.ToString();
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

                label8.Text = label8.Text + "-" + ex0.ToString();
            }
            finally
            {


            }

            #endregion

        }
    }
}
