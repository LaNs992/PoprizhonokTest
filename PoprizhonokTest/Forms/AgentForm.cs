using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PoprizhonokTest.Forms
{
    public partial class AgentForm : Form
    {
        public AgentForm()
        {
            InitializeComponent();
            LoadControl();
            comboBox1.DisplayMember = nameof(TtpeAgent.Titel);
            comboBox1.ValueMember=nameof(TtpeAgent.Id);

        }
        public void LoadControl()
        {        
            using (var db = new PoprizhonokContext())
            {
                var agents = db.Agents.Include(nameof(Agent.TypeAgent));
                foreach (var agent in agents)
                {
                    var tourInfo = new AgentViwer(agent);
                    tourInfo.Parent = flowLayoutPanel1;
                    tourInfo.OnImageChanged += TourInfo_OnImageChanged;
                }

            }

        }
        private void TourInfo_OnImageChanged(Agent agent, byte[] image)
        {
            using (var db = new PoprizhonokContext())
            {
                var tourDB = db.Agents.FirstOrDefault(x => x.IdAgent == agent.IdAgent);
                tourDB.Logo = image;
                db.SaveChanges();
            }
        }
        
        private void Sort()
        {
            var selectedSort = ((TtpeAgent)comboBox1.SelectedItem).Id;

            foreach (var item in flowLayoutPanel1.Controls)
            {
                var visible = true;
                if (item is AgentViwer dishView)
                {
                    if (selectedSort != 10000 && !(dishView.Agent.TypeAgentId == selectedSort))
                    {
                        visible = false;
                    }
                    if (!(string.IsNullOrEmpty(textBox1.Text) || dishView.Agent.NameAg.Contains(textBox1.Text)))
                    {
                        visible = false;
                    }

                    dishView.Visible = visible;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm= new ProductForm();
            productForm.ShowDialog(); 
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            

            using(var db=new PoprizhonokContext()) { 
            var hehe = db.TtpeAgents.OrderBy(x => x.Id);

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(hehe.ToArray());
            comboBox1.Items.Insert(0, new TtpeAgent()
            {
                Id = 10000,
                Titel = "Все геи",
            });
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Addagent = new AddAgentForm();
            if (Addagent.ShowDialog() ==DialogResult.OK) 
            {
                using (var db = new PoprizhonokContext())
                {
                    db.Agents.Add(Addagent.Agent);
                    db.SaveChanges();
                    var tourInfo = new AgentViwer(Addagent.Agent);
                    tourInfo.Parent = flowLayoutPanel1;
                }
               
            }

        }
    }
}
