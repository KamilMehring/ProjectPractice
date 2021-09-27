using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            bob = new Guy() { Cash = 100, Name = "Bob" };
            joe = new Guy() { Cash = 50, Name = "Joe" };
        }
        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " zl ";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " zl ";
            bankCashLabel.Text =  " Bank ma " + bank + " zl ";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ( bank >= 10 )
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            } else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();

        }
    }
}
