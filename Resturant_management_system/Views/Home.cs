﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_management_system.Views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            Employee employee = new Employee();
            employee.FormClosed += (s, args) => this.Show();
            employee.Show();
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Close();

            Menu menu = new Menu();
            menu.Close();


            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
