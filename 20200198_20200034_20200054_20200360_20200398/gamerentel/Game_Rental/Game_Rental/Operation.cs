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

namespace Game_Rental
{
    public partial class Operation : Form
    {
        public Operation()
        {
            InitializeComponent();
        }

        private void Operation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_RentalDataSet1.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter1.Fill(this.game_RentalDataSet1.Game);
            // TODO: This line of code loads data into the 'game_RentalDataSet.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.game_RentalDataSet.Game);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5CQ45GJ;Initial Catalog=Game_Rental;Integrated Security=True");
            SqlCommand mycommand = new SqlCommand();
            mycommand.Connection = con;
            con.Open();
            mycommand.CommandText = mycommand.CommandText + "update Game set NumberofRenters = NumberofRenters-1";
            mycommand.CommandText = mycommand.CommandText + "where Gname=@Gname";
            mycommand.Parameters.Add("@Gname", SqlDbType.NVarChar).Value = textBox1.Text;
            mycommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Returned Successfually");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5CQ45GJ;Initial Catalog=Game_Rental;Integrated Security=True");
            SqlCommand mycommand = new SqlCommand();
            mycommand.Connection = con;
            con.Open();
            mycommand.CommandText = mycommand.CommandText + "update Game set NumberofRenters = NumberofRenters+1";
            mycommand.CommandText = mycommand.CommandText + "where Gname=@Gname";
            mycommand.Parameters.Add("@Gname", SqlDbType.NVarChar).Value = textBox1.Text;
            mycommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Rented Successfually");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gameTableAdapter.Fill(this.game_RentalDataSet.Game);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
