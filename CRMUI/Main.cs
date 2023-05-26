using CRMBLL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMUI
{
    public partial class Main : Form
    {
        private CRMContext db;
        public Main()
        {
            db = new CRMContext();
            InitializeComponent();
        }

        /// <summary>
        /// Получаем тип сущности и контекст базы данных и формируем результат для показа окна сущности
        /// </summary>
        private void GetDataAndShowWindow<T>(DbSet<T> dbSet) where T : class
        {
            var data = new Catalog<T>(dbSet,db);
            data.Show();
        }
        

        private void tovarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataAndShowWindow<Product>(db.Products);
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataAndShowWindow<Seller>(db.Sellers);
        }



        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataAndShowWindow<Customer>(db.Customers);
        }

        
        private void checksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataAndShowWindow<Check>(db.Checks);
        }

        private void addCustomerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void addSellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SellerForm form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void addTovarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }
    }
}
