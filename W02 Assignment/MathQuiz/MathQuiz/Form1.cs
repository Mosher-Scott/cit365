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
           
        // Holds the values of the addition items
        int addend1, addend2;

        // Hold subtraction values
        int minuend;
        int subtrahend;

        // Holds multiplication values
        int multiplicand;
        int multiplier;

        // Hold division values
        int dividend;
        int divisor;

        // Holds the value of the time that is left
        int timeLeft;


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

            // Now for subtraction values
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Multiplication
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Dividing
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Start timer
            timeLeft = 30;
            timeLabel.Text = "30 Seconds";
            timer1.Start();
        }

        /// <summary>
        /// Check the answer to see if the user got all correct
        /// </summary>
        /// <returns>True is answer is correct. Otherwise false</returns>
    private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend - subtrahend == difference.Value) 
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;

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

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (CheckTheAnswer())
            {
                // If this returns true, then the user got the answer right.  Stop the time & show a message
                timeLabel.BackColor = Color.LawnGreen;
                timer1.Stop();
                MessageBox.Show("You got everything correct!  Congrats!");
                startButton.Enabled = true;
            }

            else if ((timeLeft < 5)  && (timeLeft > 0))
            {
                timeLabel.BackColor = Color.Red;
                timeLeft--;
                timeLabel.Text = timeLeft + " Seconds";
            }

            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() is false, keep counting
                // Display the new time left
                // by updating the Time Left label.
                timeLeft--;
                timeLabel.Text = timeLeft + " Seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in this control
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ScottMosherMathQuiz_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            dateLabel.Text = currentDate.ToString("dd MMMM yyy");
        }
    }
}
