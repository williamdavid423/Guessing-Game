﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            try
            {
                int playerAmount;
                int userGuess = Convert.ToInt32(numberInput.Text);
                playerAmount = randGen.Next(1, 101);
                outputLabel.Text = $"{playerAmount}";
            }
            catch
            {

            }


        }

        private void NumberInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
