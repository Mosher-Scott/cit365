using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {

     // Create a Random object called randomizer 
     // to generate random numbers.
    Random randomizer = new Random();

        int addend1, addend2;

    /// <summary>
    /// Star the quiz by getting all the problems, and starting the timer
    /// </summary>
    public void StartTheQuiz()
        {
            // Fill in the adition problem by generationg 2 numbers to add.  Store them in the variables
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the ints to a string
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // This is the numeric control.  The will make sure the value is 0 when starting the problem
            sum.Value = 0;
        }

    public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void ScottMosherMathQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
