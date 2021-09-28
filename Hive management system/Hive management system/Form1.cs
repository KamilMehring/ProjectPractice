﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hive_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru" , "Wytwarzanie moid" }, 175);
            workers[1] = new Worker(new string[] { "Pielęnacja jaj", "Naucznie pszczółek" }, 114);
            workers[2] = new Worker(new string[] { "Utrzymywanie ula" , "Patrol z żądzłami" }, 149);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru" , "Wytwarzanie miodu" ,
            "Pielęnacja jaj", "Naucznie pszczółek" , "Utrzymywanie ula" , "Patrol z żądzłami" }, 155);
            queen = new Queen(workers , 275);
        }
        private Queen queen;

        private void assignJob_Click_1(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania '" + workerBeeJob.Text + "'", "Królowa pszczół mówi...");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' będzie ukończone za " + shifts.Value + " zmiany", "Królowa pszczół mówi.. ");

        }
        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void workerBeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void report_TextChanged(object sender, EventArgs e)
        {

        }

        private void shifts_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
