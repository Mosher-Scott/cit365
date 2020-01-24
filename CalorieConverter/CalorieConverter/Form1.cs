using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieConverter
{
    public partial class Form1 : Form
    {
        // Set some global variables
        int totalCalories = 0;

        int carbs = 0;

        int fat = 0;

        int protein = 0;


        public Form1()
        {
            InitializeComponent();


        }

        private int getCarbProteinCalories(int carbs)
        {
            int calories = carbs * 4;

            return calories;
        }

        private int getFatCalories(int fat)
        {
            int calories = fat * 9;

            return calories;
        }

        private void displayCarbPercent(double item)
        {

        }


        private double getPercentages(double item)
        {
            double itemPercent = (item / totalCalories) * 100;

            return itemPercent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void caloriesPerItemLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // All things that happen from a button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Get total calories value
            try
            {
                totalCalories = Int32.Parse(totalCaloriesInput.Text);

            } catch(InvalidCastException)
            {
                MessageBox.Show("Error.  Input a number.");
            }

            // Get Carbs
            try
            {
                // Get the user input
                carbs = Int32.Parse(carbsInput.Text);

                // Get carb Calories
                int carbCalories = getCarbProteinCalories(carbs);

                // Get the percent
                double carbPercent = getPercentages(carbCalories);

                carbsCalorieResult.Text = carbCalories.ToString();

                carbsPercent.Text = String.Format("{0:0.##}", carbPercent) + "%";

            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error getting Carbs.  Please enter in a valid number.");
            }

            // Get Protein
            try
            {
                // Get the user input
                protein = Int32.Parse(proteinInput.Text);

                // Get protein Calories
                int carbProtein = getCarbProteinCalories(protein);

                // Get the percent
                double proteinPercent = getPercentages(carbProtein);

                proteinCaloriesResult.Text = carbProtein.ToString();

                proteinPercentDisplay.Text = String.Format("{0:0.##}", proteinPercent) + "%";

            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error getting Protein.  Please enter in a valid number.");
            }

            // Get Fat
            try
            {
                // Get the user input
                fat = Int32.Parse(fatInput.Text);

                // Get fat Calories
                int carbFat = getFatCalories(fat);

                // Get the percent
                double fatPercent = getPercentages(carbFat);

                fatCaloriesResult.Text = carbFat.ToString();

                fatPercentDisplay.Text = String.Format("{0:0.##}", fatPercent) + "%";

            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error getting Protein.  Please enter in a valid number.");
            }

        }



        private void proteinCaloriesResult_Click(object sender, EventArgs e)
        {

        }
    }
}
