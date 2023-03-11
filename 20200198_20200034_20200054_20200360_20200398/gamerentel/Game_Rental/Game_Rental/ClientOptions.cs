using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Rental
{
    public partial class ClientOptions : Form
    {
        public ClientOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientAccount f = new ClientAccount();
            f.Show();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Search f = new Search();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation f = new Operation();
            f.Show();
        }
    }
}
