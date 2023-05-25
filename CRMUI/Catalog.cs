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
    public partial class Catalog<T> : Form where T: class 
    {
        DbSet<T> dbSet;
        CRMContext dbContext;
        public Catalog(DbSet<T> set)
        {
            InitializeComponent();
            
            dbSet = set;
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }
        public Catalog(DbSet<T> set, CRMContext db)
        {
            InitializeComponent();
            dbContext = db;
            dbSet = set;
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;

            if(typeof(T) == typeof(Product))
            {
                var product = dbSet.Find(id) as Product;
                if (product != null)
                {
                    ProductForm form = new ProductForm(product);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product;
                        dbContext.SaveChanges();
                        dataGridView1.Update();
                        
                    }
                }
            }
        }
    }
}
