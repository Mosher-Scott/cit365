﻿using System;
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
    public partial class DisplayQuote : Form
    {

        private Object1 _obj1;
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();

            // Now close this window
            Close();
        }

        private void ReturnToAddQuoteScreenLabel_Click(object sender, EventArgs e)
        {

            AddQuote addQuoteForm = (AddQuote)Tag;
            addQuoteForm.Show();

            // Close the window
            Close();
        }
    }
}
