﻿using CRMBLL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMUI
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }
        public SellerForm()
        {
            InitializeComponent();
        }
        public SellerForm(Seller seller) :this()
        {
            Seller = seller ?? new Seller();
            sellerNameTextBox.Text = Seller.Name;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();
            Seller.Name = sellerNameTextBox.Text;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
