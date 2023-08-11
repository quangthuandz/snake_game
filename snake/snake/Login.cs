using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using snake.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace snake
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Project_PRN211Context context = new Project_PRN211Context();
            var user = context.Users.FirstOrDefault(x => x.Email == txtEmail.Text && x.Password == txtPass.Text);

            if (user == null)
            {
                MessageBox.Show("Wrong Email or Password");
            }
            else
            {
                if (user.IsAdmin == 0)
                {
                    Menu m = new Menu();
                    m.UserId = user.UserId;
                    Normal n = new Normal();
                    n.UserId = user.UserId;
                    m.ShowDialog();

                }
                else
                {
                    AdminMenu m = new AdminMenu();
                    m.ShowDialog(this);
                }

            }
        }
    }
}
