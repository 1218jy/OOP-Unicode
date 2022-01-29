using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { 
                string[] inputString = textBox1.Text.Split(new char[] { ' ' });

                Console.WriteLine(String.Join(" ", inputString));

                char[] myArray = Array.ConvertAll(inputString, char.Parse);

                for (int i = 0; i < inputString.Length; i++)
                {
                    int newCode = myArray[i];

                    int encrypte = newCode - 1;

                    char myChar = (char)encrypte;

                    textBox1.Text = myChar.ToString();
                }
         
            
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] inputString = textBox1.Text.Split(new char[] { ',' });

            Console.WriteLine(String.Join(",", inputString));

            char[] myArray = Array.ConvertAll(inputString, char.Parse);

            for (int i = 0; i < inputString.Length; i++)
            {
                int newCode = myArray[i];

                int encrypte = (newCode + 1);

                char myChar = (char)encrypte;

                textBox1.Text = myChar.ToString();
            }


        }
    }
}
