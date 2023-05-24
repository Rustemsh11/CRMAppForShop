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
            var data = new Catalog<T>(dbSet);
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
    }
}
