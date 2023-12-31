﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_BioMarkt
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductScreen productsScreen = new ProductScreen();
            productsScreen.ShowDialog();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillingScreen billingScreen = new BillingScreen();
            billingScreen.ShowDialog();
        }
    }
}
