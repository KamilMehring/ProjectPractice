using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Queue<Worker> workerLine = new Queue<Worker>();
        private void addWorker_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text)) return;
            workerLine.Enqueue(new Worker(name.Text));
            name.Text = "";
            RedrawList();
        }
        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach (Worker worker in workerLine)
            {
                line.Items.Add(number + ". " + worker.Name);
                number++;
            }

        }
    }
}
