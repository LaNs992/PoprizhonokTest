using Microsoft.EntityFrameworkCore;
using PoprizhonokTest.Context;
using PoprizhonokTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoprizhonokTest.Forms
{
    
    public partial class AgentViwer : UserControl
    {
        private readonly Agent agentViwer;

        public Agent Agent => agentViwer;
        public AgentViwer(Agent agent)
        {
            InitializeComponent();
            this.agentViwer=agent;
            InitTour(agent);
        }
        private void InitTour(Agent agent)
        {
            using (var db = new PoprizhonokContext())
            {
                var type = db.TtpeAgents.FirstOrDefault(x => x.Id == agent.TypeAgentId);
                NameLbl.Text = agent.NameAg;
                TypeLbl.Text = type.Titel;
                CountLbl.Text = agent.NameAg;
                Numberlbl.Text = agent.Number;
                Favoritlbl.Text = $"Приоритетность: {agent.Favorit}";
                if (agent.Logo != null)
                {
                    pictureBox1.Image = Image.FromStream(new MemoryStream(agent.Logo));
                }
            }
        }
        public event Action<Agent, byte[]> OnImageChanged;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var image = File.ReadAllBytes(openFileDialog1.FileName);
            OnImageChanged?.Invoke(agentViwer, image);
            pictureBox1.Image = Image.FromStream(new MemoryStream(image));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var db = new PoprizhonokContext())
            {
                var agent = db.Agents.FirstOrDefault(x => x.IdAgent == Agent.IdAgent);

                var addform = new AddAgentForm(agent);
                var result= addform.ShowDialog();
                if(result==DialogResult.OK)
                {
                    db.SaveChanges();
                    InitTour(agent);
                }
            }   
        }
    }
}
