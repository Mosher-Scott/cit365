using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Mosher
{
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            // Allows you to shrink code blocks
            #region

            #endregion

            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();

            // Now close this window
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_PopupMessage(object sender, EventArgs e)
        {
            ToolTip deskWidthMessage = new ToolTip();
            deskWidthMessage.ShowAlways = true;
            deskWidthMessage.IsBalloon = true;
            deskWidthMessage.SetToolTip(DeskWidthInputBox, "Min 12\",  Max 96\"");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeskHeightInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesktopHeightInputBox_PopupMessage(object sender, EventArgs e)
        {
            ToolTip deskWidthMessage = new ToolTip();
            deskWidthMessage.ShowAlways = true;
            deskWidthMessage.IsBalloon = true;
            deskWidthMessage.SetToolTip(DeskDepthtInputBox, "Min 12\",  Max 48\"");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumberOfDrawersInputBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip numberOfDrawersMessage = new ToolTip();
            numberOfDrawersMessage.ShowAlways = true;
            numberOfDrawersMessage.IsBalloon = true;
            numberOfDrawersMessage.SetToolTip(NumberOfDrawersInputBox, "Min 0, Max 7");
        }

        private void SurfaceMaterialInputBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip surfaceMaterialMessage = new ToolTip();
            surfaceMaterialMessage.ShowAlways = true;
            surfaceMaterialMessage.IsBalloon = true;
            surfaceMaterialMessage.SetToolTip(SurfaceMaterialInputBox, "Laminate, oak, Rosewood, Veneer, Pine");
        }

        private void RushOrderInputBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip rushOrderMessage = new ToolTip();
            rushOrderMessage.ShowAlways = true;
            rushOrderMessage.IsBalloon = true;
            rushOrderMessage.SetToolTip(RushOrderInputBox, "3, 5, 7, or 14 Days (Normal Production)");
        }

        private void GenerateQuote(object sender, EventArgs e)
        {
            // Validate everything again, just so someone can't submit empty data

            double width = 15;
            double depth = 6;
            int drawers = 5;
            string material = "Goat";
            int rushOrderOption = 9;

            Desk myDesk = new Desk(width, depth, drawers, material, rushOrderOption);

            DisplayQuote.Desk = myDesk;

            DisplayQuote viewDisplayQuoteForm = new DisplayQuote();

            viewDisplayQuoteForm.Tag = this;
            viewDisplayQuoteForm.Show(this);

            // Now close this window
            Hide();

        }

       private void validateDeskWidthInput(object sender, CancelEventArgs e)
        {

            //  Get the width input.  If not a number, throw an exception
            try
            {
                double number = double.Parse(DeskWidthInputBox.Text);

                if (number < Desk.MINWIDTH || number > Desk.MAXWIDTH)
                {
                    DeskWidthInputBox.ForeColor = Color.Black;
                    DeskWidthInputBox.BackColor = Color.Red;
                    DeskWidthInputBox.Focus();
                    MessageBox.Show($"Min Width: {Desk.MINWIDTH}\"\nMax Width: {Desk.MAXWIDTH}\"");
                }
                else
                {
                    DeskWidthInputBox.ForeColor = Color.Black;
                    DeskWidthInputBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                DeskWidthInputBox.ForeColor = Color.Red;
                DeskWidthInputBox.Focus();
                MessageBox.Show("Please enter a number for the Width");
            }

        }

        private void validateDeskDepthInput(object sender, CancelEventArgs e)
        {
            try
            {
                double number = double.Parse(DeskDepthtInputBox.Text);

                if (number < Desk.MINDEPTH || number > Desk.MAXDEPTH)
                {
                    DeskDepthtInputBox.ForeColor = Color.Black;
                    DeskDepthtInputBox.BackColor = Color.Red;
                    DeskDepthtInputBox.Focus();
                    MessageBox.Show($"Min Width: {Desk.MINDEPTH}\"\nMax Width: {Desk.MAXDEPTH}\"");
                }
                else
                {
                    DeskDepthtInputBox.ForeColor = Color.Black;
                    DeskDepthtInputBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                DeskDepthtInputBox.ForeColor = Color.Red;
                DeskDepthtInputBox.Focus();
                MessageBox.Show("Please enter a number for the Depth");
            }
        }

        private void validateNumDrawersInput(object sender, CancelEventArgs e)
        {
            try
            {
                double number = double.Parse(NumberOfDrawersInputBox.Text);

                if (number < Desk.MINDRAWERS || number > Desk.MAXDRAWERS)
                {
                    NumberOfDrawersInputBox.ForeColor = Color.Black;
                    NumberOfDrawersInputBox.BackColor = Color.Red;
                    NumberOfDrawersInputBox.Focus();
                    MessageBox.Show($"Min Width: {Desk.MINDRAWERS}\"\nMax Width: {Desk.MAXDRAWERS}\"");
                }
                else
                {
                    NumberOfDrawersInputBox.ForeColor = Color.Black;
                    NumberOfDrawersInputBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number for the Number of Drawers");
                NumberOfDrawersInputBox.ForeColor = Color.Red;
                NumberOfDrawersInputBox.Focus();
            }
        }

        private void validateSurfaceMaterialInput(object sender, CancelEventArgs e)
        {
            try
            {
                string surfaceMaterial = SurfaceMaterialInputBox.Text;

                Boolean isValideSurfaceMaterial = false;

                // While the validation fails, change the text color
                while (!isValideSurfaceMaterial)
                {
                    SurfaceMaterialInputBox.ForeColor = Color.Black;
                    SurfaceMaterialInputBox.BackColor = Color.Red;
                    SurfaceMaterialInputBox.Focus();
                    MessageBox.Show($"Min Width: {Desk.MINDRAWERS}\"\nMax Width: {Desk.MAXDRAWERS}\"");
                }


                SurfaceMaterialInputBox.ForeColor = Color.Black;
                SurfaceMaterialInputBox.BackColor = Color.White;

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number for the Number of Drawers");
                SurfaceMaterialInputBox.ForeColor = Color.Red;
                SurfaceMaterialInputBox.Focus();
            }
        }

    }
}
