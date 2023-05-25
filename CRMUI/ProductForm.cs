using CRMBLL.Model;
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
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(Product product) : this()
        {
            Product = product ?? new Product();
            productNameTextBox.Text = Product.Name;
            costInput.Value = Product.Price;
            countInput.Value = Product.Count;
        }
        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Product = new Product
            {
                Name = productNameTextBox.Text,
                Count = Convert.ToInt32(countInput.Value),
                Price = costInput.Value
            };
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
