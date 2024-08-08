using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTUARANT_MANAGEMENT_SYSTEM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Close();
        }

        private void cusBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
