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
    public partial class AddAgentForm : Form
    {
        public readonly Agent agent;
        public AddAgentForm()
        {
            InitializeComponent();
            agent = new Agent();
        }
        public Agent Agent => agent;
        public AddAgentForm(Agent agent):this() 
        {
            this.agent= agent;
            button1.Text = "EDIT";
            textBox1.Text = agent.Mail;
            comboBox1.Text = agent.TypeAgentId.ToString();
            textBox2.Text= agent.Number;
            textBox3.Text = agent.Adres;
            textBox4.Text = agent.Director;
            numericUpDown1.Value = (int)agent.Favorit;
            textBox5.Text = agent.NameAg;
            textBox6.Text =agent.Kpp.ToString();
            textBox7.Text = agent.Inn.ToString();
        }

      

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            agent.NameAg=textBox5.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            agent.TypeAgentId =Convert.ToInt32( comboBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            agent.Mail=textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            agent.Number=textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            agent.Adres=textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            agent.Director=textBox4.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            agent.Favorit =(int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            agent.Inn =Convert.ToInt64(textBox7.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            agent.Kpp = Convert.ToInt32(textBox6.Text);
        }
    }
}
