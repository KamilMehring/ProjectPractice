﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace StosowanieDebuggera
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = 15;            
            number = number + 10; 
            number = 36 * 15; 
            number = 12 - (42 / 7); 
            number += 10; 
            number *= 3; 
            number = 71 / 3; 
             
            int count = 0; 
            count++; 
            count--; 
             
            string result = "witam";
            result += " ponownie " + result;
            output.Text = result; 
            result = "wartością jest: " + count;
            result = ""; 
             
            bool yesNo = false; 
            bool anotherBool = true; 
            yesNo = !anotherBool;
        }
    }
}
