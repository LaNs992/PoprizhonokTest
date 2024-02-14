using Microsoft.VisualBasic.Logging;
using PoprizhonokTest.Context;
using PoprizhonokTest.Forms;
using PoprizhonokTest.Models;

namespace PoprizhonokTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db= new PoprizhonokContext())
            {
                if (db.Users.Any(x=>x.Login==textBox1.Text && x.Password == textBox2.Text))
                {
                    var currentUser = db.Users.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);
                    AgentForm agentForm = new AgentForm();

                    switch (currentUser.RoleId)
                    {
                        case 1:
                            profile.user = 1;
                            break;
                        case 2:
                            profile.user = 2;
                            break;
                        

                    }
                    agentForm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль или логин", "Ошибка авторизации");

                }
            }
        }
    }
}