using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Cutlets_40_LKR.Value =0;
            EggBun_120_LKR.Value = 0;
            IceCream_150_LKR.Value = 0;
            CupCake_150_LKR.Value = 0;
            VegeKottu_500_LKR.Value = 0;
            EggKottu_500_LKR.Value = 0;
            Seafood_800_LKR.Value= 0;
            EggRice_800_LKR.Value = 0;
            IceCoffee_150_LKR.Value = 0;
            CocaCola_150_LKR.Value = 0;
            Lime_100_LKR.Value = 0;
            Orange_100_LKR.Value = 0;

            totaltext.Text = "0";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
                        
        }

        private void Cutlets_40_LKR_ValueChanged(object sender, EventArgs e)
        {

        }


        private void calBtn_Click(object sender, EventArgs e)
        {
            double total = 0.0;

            // Item prices
            double cutlets_40_LKR = 40;
            double eggBun_120_LKR = 120;
            double iceCream_150_LKR = 150;
            double cupCake_150_LKR = 150;
            double vegeKottu_500_LKR = 500;
            double eggKottu_500_LKR = 500;
            double seafood_800_LKR = 800;
            double eggRice_800_LKR = 800;
            double iceCoffee_150_LKR = 150;
            double cocaCola_150_LKR = 150;
            double lime_100_LKR = 100;
            double orange_100_LKR = 100;

            // Calculating the total based on the quantity selected by the user
            total += cutlets_40_LKR * (double)Cutlets_40_LKR.Value;
            total += eggBun_120_LKR * (double)EggBun_120_LKR.Value;
            total += iceCream_150_LKR * (double)IceCream_150_LKR.Value;
            total += cupCake_150_LKR * (double)CupCake_150_LKR.Value;
            total += vegeKottu_500_LKR * (double)VegeKottu_500_LKR.Value;
            total += eggKottu_500_LKR * (double)EggKottu_500_LKR.Value;
            total += seafood_800_LKR * (double)Seafood_800_LKR.Value;
            total += eggRice_800_LKR * (double)EggRice_800_LKR.Value;
            total += iceCoffee_150_LKR * (double)IceCoffee_150_LKR.Value;
            total += cocaCola_150_LKR * (double)CocaCola_150_LKR.Value;
            total += lime_100_LKR * (double)Lime_100_LKR.Value;
            total += orange_100_LKR * (double)Orange_100_LKR.Value;


            totaltext.Text = total.ToString();

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Successfull !", "Payment Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Cutlets_40_LKR.Value = 0;
            EggBun_120_LKR.Value = 0;
            IceCream_150_LKR.Value = 0;
            CupCake_150_LKR.Value = 0;
            VegeKottu_500_LKR.Value = 0;
            EggKottu_500_LKR.Value = 0;
            Seafood_800_LKR.Value = 0;
            EggRice_800_LKR.Value = 0;
            IceCoffee_150_LKR.Value = 0;
            CocaCola_150_LKR.Value = 0;
            Lime_100_LKR.Value = 0;
            Orange_100_LKR.Value = 0;

            totaltext.Text = "0";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
