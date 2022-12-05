using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_lotto
{
    public partial class Form1 : Form
    {
        Random rng = new();

        int[] randomNum = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateRandomNum_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++)
            {
                randomNum[i] = rng.Next(1, 50);
                
                for(int j = 0; j < i; j++)
                {
                    if(i != 0 && randomNum[i] == randomNum[j])
                    {
                        i--;
                    }
                }
            }
            DisplayNum1.Text = Convert.ToString(randomNum[0]);
            DisplayNum2.Text = Convert.ToString(randomNum[1]);
            DisplayNum3.Text = Convert.ToString(randomNum[2]);
            DisplayNum4.Text = Convert.ToString(randomNum[3]);
            DisplayNum5.Text = Convert.ToString(randomNum[4]);
            DisplayNum6.Text = Convert.ToString(randomNum[5]);
        }
    }
}
