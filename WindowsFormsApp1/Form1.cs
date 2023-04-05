using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            int charCounter = 0;
            string text = "text 1";
            charCounter += text.Length;
            MessageBox.Show(text);
            text = "text 2";
            charCounter += text.Length;
            MessageBox.Show(text);
            text = "text 3";
            charCounter += text.Length;
            MessageBox.Show(text,(charCounter/3).ToString() + " chars on average");

            
        }

        static public void guessNumber()
        {
            Random r = new Random();
            DialogResult dialogRes;
            MessageBox.Show("Pick a number from 1 to 2000");
            int attempts = 0;
            while (true)
            {
                dialogRes = MessageBox.Show("Is it a " + r.Next(1, 2000) + " ?", "Suggestion", MessageBoxButtons.YesNo);
                attempts++;
                if (dialogRes == DialogResult.Yes) break;
            }
            MessageBox.Show("Number is right after " + attempts.ToString() + " attempts");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guessNumber();
        }
    }
}
