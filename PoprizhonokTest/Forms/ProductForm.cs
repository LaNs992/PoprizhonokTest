using PoprizhonokTest.Context;
using PoprizhonokTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoprizhonokTest.Forms
{
    public partial class ProductForm : Form
    {

    
        public ProductForm()
        {
            InitializeComponent();
            intiDatagroid();
        }
        public void intiDatagroid()
        {
            using (var db = new PoprizhonokContext())
            { 
               
                dataGridView1.DataSource = db.Products.Select(x => new Models.Product
                {
                    Id = x.Id,
                    Articul = x.Articul,
                    CehProiz = x.CehProiz,
                    Count = x.Count,
                    NamePr = x.NamePr,
                    Price = x.Price,
                    TypeProductId = x.TypeProductId
                }).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addProd = new AdddProductForm();
            if (addProd.ShowDialog() == DialogResult.OK)
            {
                using (var db = new PoprizhonokContext())
                {
                    db.Products.Add(addProd.Product);
                    db.SaveChanges();
                    intiDatagroid();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var hotelDataGrid = (Product)dataGridView1.SelectedRows[0].DataBoundItem;
            if (hotelDataGrid == null)
            {
                return;
            }
            using (var db = new PoprizhonokContext())
            {
                var productDB = db.Products.FirstOrDefault(x => x.Id == hotelDataGrid.Id);
                var hotelChange = new AdddProductForm(productDB);
                if (hotelChange.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    intiDatagroid();
                }
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var product = (Product)dataGridView1.SelectedRows[0].DataBoundItem;
            using (var db = new PoprizhonokContext())
            {
                var hotelDB =db.Products.FirstOrDefault(x => x.Id == product.Id);

                db.Products.Remove(hotelDB);
                db.SaveChanges();
                intiDatagroid();
            }
        }
    }
}
