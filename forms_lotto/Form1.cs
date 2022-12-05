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
        Label[] label = new Label[6];

        int[] randomNum = new int[6];
        int[] generatedNum = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateRandomNum_Click(object sender, EventArgs e)
        {
            label[0] = DisplayNum1;
            label[1] = DisplayNum2;
            label[2] = DisplayNum3;
            label[3] = DisplayNum4;
            label[4] = DisplayNum5;
            label[5] = DisplayNum6;

            for (int i = 0; i < 6; i++)
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

            for(int i = 0; i < 6; i++)
            {
                generatedNum[i] = randomNum.Max();
                randomNum[Array.IndexOf(randomNum, randomNum.Max())] = 0;
            }

            for(int i = 0; i < 6; i++)
            {
                label[i].Text = Convert.ToString(generatedNum[i]);
            }
        }
    }
}
