using snake.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class AdminMenu : Form
    {
        Project_PRN211Context context = new Project_PRN211Context();
        public AdminMenu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Project_PRN211Context context = new Project_PRN211Context();
            var st = context.Users.Select(x => new User
            {
                UserId = x.UserId,
                Email = x.Email,
                Name = x.Name,
            });
            dataGridView1.DataSource = st.ToList();

            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["IsAdmin"].Visible = false;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            Project_PRN211Context context = new Project_PRN211Context();
            List<string> st = context.Games.Select(x => x.Name).ToList();
            st.Insert(0, "");
            comboBox1.DataSource = st;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Project_PRN211Context context = new Project_PRN211Context();
                var st = context.Users.Select(x => new User
                {
                    UserId = x.UserId,
                    Email = x.Email,
                    Name = x.Name,
                });
                dataGridView1.DataSource = st.ToList();

                dataGridView1.Columns["Password"].Visible = false;
                dataGridView1.Columns["IsAdmin"].Visible = false;
            }
            else
            {
                Project_PRN211Context context = new Project_PRN211Context();
                var user = from s in context.Users
                           join d in context.UserGames on s.UserId equals d.UserId
                           join g in context.Games on d.GameId equals g.GameId
                           where g.Name == comboBox1.Text
                           orderby d.Score descending
                           select new { s.UserId, s.Email, s.Name, Score = d.Score };
                dataGridView1.DataSource = user.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var st = context.Users.Where(x => x.Name.Contains(textBox1.Text)).Select(x => new User
            {
                UserId = x.UserId,
                Email = x.Email,
                Name = x.Name,
            }).ToList();
            dataGridView1.DataSource = st;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog();

                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (j == dataGridView1.Columns.Count - 1)
                            {
                                writer.Write(dataGridView1.Rows[i].Cells[j].Value + "");
                            }
                            else
                            {
                                writer.Write(dataGridView1.Rows[i].Cells[j].Value + ";");
                            }
                        }
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Save to file succesfully");
            
        }
    }
}
