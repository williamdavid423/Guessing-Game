using System;
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
        int playerAmount;
        public Form1()
        {
            InitializeComponent();
            playerAmount = randGen.Next(1, 101);
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int userGuess = Convert.ToInt32(numberInput.Text);
                
                //outputLabel.Text = $"{playerAmount}";

                if(userGuess > playerAmount)
                    {
                    outputLabel1.Text = "Too High!";
                }
                else if(userGuess < playerAmount)
                {
                    outputLabel1.Text = "Too Low!";
                }
                else if(userGuess == playerAmount)
                {
                    outputLabel1.Text = "Congratulations, You Guessed Correct!";
                   
                }
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
