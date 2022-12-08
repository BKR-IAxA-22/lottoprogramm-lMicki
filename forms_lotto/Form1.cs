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
        Random rng = new();     //Random class
        Label[] label = new Label[6];   //Array for the labels
        TextBox[] textBox = new TextBox[6];     //Array for the Textboxes

        int[] randomNum = new int[6];   //Array for the unsorted generated numbers
        int[] generatedNum = new int[6];    //Array for the sorted generated numbers

        int timesRolled = 0;    //Counter for the times rolled

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateRandomNum_Click(object sender, EventArgs e)
        {
            timesRolled++;

            label[0] = DisplayNum1; label[1] = DisplayNum2; label[2] = DisplayNum3; label[3] = DisplayNum4; label[4] = DisplayNum5; label[5] = DisplayNum6;

            textBox[0] = InputNum6; textBox[1] = InputNum5; textBox[2] = InputNum4; textBox[3] = InputNum3; textBox[4] = InputNum2; textBox[5] = InputNum1;

            /*
            Generating random numbers 
            */

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

            /*
            Sorts Numbers in order from high to low
            */

            for(int i = 0; i < 6; i++)
            {
                generatedNum[i] = randomNum.Max();
                randomNum[Array.IndexOf(randomNum, randomNum.Max())] = 0;
            }

            /*
            Changes Background color of textboxes depending on if the inputted number was rolled
            */

            for(int i = 0; i < 6; i++) { bool colorTextBox = false;
                for(int j = 0; j < 6; j++)
                {
                    if(textBox[i].Text != "")
                    {
                        if (Convert.ToInt32(textBox[i].Text) == generatedNum[j])
                        {
                            textBox[i].BackColor = Color.LightGreen;
                            colorTextBox = true;
                        }
                        else if (colorTextBox == false) textBox[i].BackColor = Color.White;
                    }
                    else textBox[i].BackColor = Color.Yellow;
                }
            }

            GenerateRandomNum.Text = $"Generate! x{timesRolled}";

            /*
            Sets sorted numbers to labels
            */

            for(int i = 0; i < 6; i++)
            {
                label[i].Text = Convert.ToString(generatedNum[i]);
            }
        }
    }
}
