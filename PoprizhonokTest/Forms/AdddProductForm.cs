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
    public partial class AdddProductForm : Form
    {
        private readonly Product product;
        public AdddProductForm()
        {
            InitializeComponent();
            product = new Product();
        }
        public Product Product => product;
        public AdddProductForm(Product product):this()
        {
            this.product = product;
            textBox1.Text = product.NamePr;
            comboBox1.Text = product.TypeProductId.ToString();
            textBox2.Text = product.Articul.ToString();
            numericUpDown1.Value = (decimal)product.Count;
            numericUpDown2.Value= (decimal)product.CehProiz;
            numericUpDown3.Value = (decimal)product.Price;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            product.NamePr = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            product.Articul = Convert.ToInt32( textBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            product.TypeProductId = Convert.ToInt32(comboBox1.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            product.Count = Convert.ToInt32(numericUpDown1.Text);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            product.CehProiz = Convert.ToInt32(numericUpDown2.Text);
        }

        private void AdddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            product.Price = Convert.ToInt32(numericUpDown3.Text);
        }
    }
}
