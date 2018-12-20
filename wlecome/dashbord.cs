using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wlecome
{
    public partial class dashbord : Form
    {
        int cust_id;
        public dashbord( int id)
        {
            cust_id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            withdraw w = new withdraw(cust_id);
            this.Hide();
            w.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
