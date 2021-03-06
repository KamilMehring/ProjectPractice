using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace OdczytZapis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader(@"C:\Users\xopero\source\repos\Ratuj_Ludzi3\OdczytZapis\OdczytZapis\plik.txt");

            richTextBox1.Text = reader.ReadToEnd();
            reader.Close();


            Dictionary<char, String> morseCode = new Dictionary<char, String>()
            {
                       {'a' , ".-"},{'b' , "-..."},{'c' , "-.-."},
                {'d' , "-.."},{'e' , "."},{'f' , "..-."},
                {'g' , "--."},{'h' , "...."},{'i' , ".."},
                {'j' , ".---"},{'k' , "-.-"},{'l' , ".-.."},
                {'m' , "--"},{'n' , "-."},{'o' , "---"},
                {'p' , ".--."},{'q' , "--.-"},{'r' , ".-."},
                {'s' , ".-."},{'t' , "-"},{'u' , "..-"},
                {'v' , "...-"},{'w' , ".--"},{'x' , "-..-"},
                {'y' , "-.--"},{'z' , "--.."},{' ' ,"  "},


            };


            string userText = richTextBox1.Text;
            userText = userText.ToLower();
            richTextBox1.Text = null;
            for (int index = 0; index < userText.Length; index++)
            {


                char t = userText[index];
                if (morseCode.ContainsKey(t))
                {
                    richTextBox1.Text += (morseCode[t]);
                }
            }
            TextWriter writer = new StreamWriter(@"C:\Users\xopero\source\repos\Ratuj_Ludzi3\OdczytZapis\OdczytZapis\plik2.txt");

            writer.Write(richTextBox1.Text);

            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            TextReader reader = new StreamReader(@"C:\Users\xopero\source\repos\Ratuj_Ludzi3\OdczytZapis\OdczytZapis\plik2.txt");

            richTextBox3.Text = reader.ReadToEnd();
            reader.Close();


            Dictionary<string, String> userText = new Dictionary<string, String>()
            {
                        {"a" , ".-"},{"b" , "-..."},{"c" , "-.-."},
                {"d" , "-.."},{"e" , "."},{"f" , "..-."},
                {"g" , "--."},{"h" , "...."},{"i" , ".."},
                {"j" , ".---"},{"k" , "-.-"},{"l" , ".-.."},
                {"m" , "--"},{"n" , "-."},{"o" , "---"},
                {"p" , ".--."},{"q" , "--.-"},{"r" , ".-."},
                {"s" , ".-."},{"t" , "-"},{"u" , "..-"},
                {"v" , "...-"},{"w" , ".--"},{"x" , "-..-"},
                {"y" , "-.--"},{"z" , "--.."},{" " ,"  "}
            };

            string morseCode = richTextBox3.Text;

            string[] ssize = morseCode.Split(null); // (',') a , b 


            string convertedFromMorse = "";

            for(int z = 0; z < ssize.Length; z++)
            {
                string myKey = userText.FirstOrDefault(x => x.Value == ssize[z]).Key;
                convertedFromMorse += myKey; 
            }
            richTextBox3.Text = convertedFromMorse;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader(@"C:\Users\xopero\source\repos\Ratuj_Ludzi3\OdczytZapis\OdczytZapis\plik.txt");

            richTextBox2.Text = reader.ReadToEnd();
            reader.Close();

            Dictionary<char, String> asciiCode = new Dictionary<char, String>()
            {
                {'a' , "97"},{'b' , "98"},{'c' , "99"},
                {'d' , "100"},{'e' , "101"},{'f' , "102"},
                {'g' , "103"},{'h' , "104"},{'i' , "105"},
                {'j' , "106"},{'k' , "107"},{'l' , "108"},
                {'m' , "109"},{'n' , "110"},{'o' , "111"},
                {'p' , "112"},{'q' , "113"},{'r' , "114"},
                {'s' , "115"},{'t' , "116"},{'u' , "117"},
                {'v' , "118"},{'w' , "119"},{'x' , "120"},
                {'y' , "121"},{'z' , "122"},{' ' ,"  "},


            };
            string userText = richTextBox2.Text;
            userText = userText.ToLower();
            richTextBox2.Text = null;
            for (int index = 0; index < userText.Length; index++)
            {

                char t = userText[index];
                if (asciiCode.ContainsKey(t))
                {
                    richTextBox2.Text += (asciiCode[t]);
                }
            }
            TextWriter writer = new StreamWriter(@"C:\Users\xopero\source\repos\Ratuj_Ludzi3\OdczytZapis\OdczytZapis\plik3.txt");

            writer.Write(richTextBox2.Text);

            writer.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader(@"C:\Users\xopero\source\repos\Ratuj_Ludzi3\OdczytZapis\OdczytZapis\plik3.txt");

            richTextBox4.Text = reader.ReadToEnd();
            reader.Close();

            Dictionary<string, String> numUser = new Dictionary<string, String>()
            {
                {"a" , "97"},{"b" , "98"},{"c" , "99"},
                {"d" , "100"},{"e" , "101"},{"f" , "102"},
                {"g" , "103"},{"h" , "104"},{"i" , "105"},
                {"j" , "106"},{"k" , "107"},{"l" , "108"},
                {"m" , "109"},{"n" , "110"},{"o" , "111"},
                {"p" , "112"},{"q" , "113"},{"r" , "114"},
                {"s" , "115"},{"t" , "116"},{"u" , "117"},
                {"v" , "118"},{"w" , "119"},{"x" , "120"},
                {"y" , "121"},{"z" , "122"},{" " ,"  "},

            };
            string asciiCode = richTextBox4.Text;

            string[] ssize = asciiCode.Split(null); // (',') a , b 


            string convertedFromAscii = "";

            for (int z = 0; z < ssize.Length; z++)
            {
                string myKey = numUser.FirstOrDefault(x => x.Value == ssize[z]).Key;
                convertedFromAscii += myKey;
            }
            richTextBox4.Text = convertedFromAscii;
        
    
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

       

      
    }

}

