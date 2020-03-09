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
    public partial class DisplayQuoteInfo : Form
    {

        public DisplayQuoteInfo(string name, double width, double depth, int drawers, string material, int rushOrderInfo)
        {
            InitializeComponent();

            // Set the values on the form with the desk size/material info

            OrderInfoLabel.Text = $"Quote For {name}";
            widthValue.Text = $"{width.ToString()}\"";
            DepthValue.Text = $"{depth.ToString()}\"";
            DrawersValue.Text = drawers.ToString();
            SurfaceValue.Text = material;
            RushValue.Text = rushOrderInfo.ToString();

            // Create an desk object so we can use it
            Desk userDesk = new Desk(width, depth, drawers, material, rushOrderInfo);

            // Display pricing
            BasePriceValue.Text = $"${Desk.BASEPRICE.ToString()}";
            ExtraSpaceValue.Text = $"${userDesk.getSurfaceAreaCost().ToString()}";
            DrawersPriceValue.Text = $"${userDesk.getDrawerCost().ToString()}";
            MaterialPriceValue.Text = $"${userDesk.getSurfaceMaterialCost().ToString()}";
            RushOrderValue.Text = $"${userDesk.getRushOrderPrice().ToString()}";

            // Get total price & display it
            TotalPriceValue.Text = $"${userDesk.getTotalCost().ToString()}";
        }

        // Close the form and return back to the Main Menu
        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();

            // Now close this window
            Close();
        }

        // Close this form, and return to the Add Quote screen
        private void ReturnToAddQuoteScreenLabel_Click(object sender, EventArgs e)
        {

            AddQuote addQuoteForm = (AddQuote)Tag;
            addQuoteForm.Show();

            // Close the window
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            
        }
    }
}
