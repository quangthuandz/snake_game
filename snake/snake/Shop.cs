using Microsoft.VisualBasic.ApplicationServices;
using snake.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Shop : Form
    {
        Project_PRN211Context con = new Project_PRN211Context();
        public int Uid = 0;
        public Shop()
        {
            InitializeComponent();
            this.FormClosed += Form2_FormClosed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {

            textBox1.Text = con.Users.Where(x => x.UserId == 2).Select(x => x.Money).FirstOrDefault().ToString();
        }

        private void btnBuyShield_Click(object sender, EventArgs e)
        {
            int total = 100 * (int)shiedNum.Value;
            Models.User user = con.Users.FirstOrDefault(u => u.UserId == 2);
            Models.UserItem userItem = con.UserItems.FirstOrDefault(x => x.UserId == 2 && x.ItemId == 1);
            if (userItem.Quatity + (int)shiedNum.Value > 5)
            {
                MessageBox.Show("You can only buy 5 power a day");
            }
            else
            {
                if (user != null)
                {
                    if (user.Money == 0)
                    {
                        MessageBox.Show("No money");
                    }
                    user.Money = user.Money - total;
                    con.Update(user);
                    con.SaveChanges();
                    userItem.Quatity = userItem.Quatity + (int)shiedNum.Value;
                    con.UserItems.Update(userItem);
                    con.SaveChanges();
                    textBox1.Text = user.Money.ToString();
                    MessageBox.Show("Buy successfully");
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Gọi phương thức ReloadForm() của Form1
            Menu menu = Application.OpenForms.OfType<Menu>().FirstOrDefault();
            menu?.ReloadForm();
        }
        private void btnBuySpeed_Click(object sender, EventArgs e)
        {
            int total = 100 * (int)speedNum.Value;
            Models.User user = con.Users.FirstOrDefault(u => u.UserId == 2);
            Models.UserItem userItem = con.UserItems.FirstOrDefault(x => x.UserId == 2 && x.ItemId == 2);
            if (userItem.Quatity + (int)shiedNum.Value > 5)
            {
                MessageBox.Show("You can only buy 5 power a day");
            }
            else
            {
                if (user != null)
                {
                    if (user.Money == 0)
                    {
                        MessageBox.Show("No money");
                    }
                    user.Money = user.Money - total;
                    con.Update(user);
                    con.SaveChanges();
                    userItem.Quatity = userItem.Quatity + (int)speedNum.Value;
                    con.UserItems.Update(userItem);
                    con.SaveChanges();
                    textBox1.Text = user.Money.ToString();
                    MessageBox.Show("Buy successfully");
                }
            }
            
        }

        private void btnBuyHeart_Click(object sender, EventArgs e)
        {
            
            int total = 100 * (int)heartNum.Value;
            Models.User user = con.Users.FirstOrDefault(u => u.UserId == 2);
            Models.UserItem userItem = con.UserItems.FirstOrDefault(x => x.UserId == 2 && x.ItemId == 3);
            if (userItem.Quatity + (int)shiedNum.Value > 5)
            {
                MessageBox.Show("You can only buy 5 power a day");
            }
            else
            {
                if (user != null)
                {
                    if (user.Money == 0)
                    {
                        MessageBox.Show("No money");
                    }
                    user.Money = user.Money - total;
                    con.Update(user);
                    con.SaveChanges();
                    userItem.Quatity = userItem.Quatity + (int)heartNum.Value;
                    con.UserItems.Update(userItem);
                    con.SaveChanges();
                    textBox1.Text = user.Money.ToString();
                    MessageBox.Show("Buy successfully");
                }
            }
            
        }
        int advertise = 0;
        private void btnAdvertising_Click(object sender, EventArgs e)
        {
            if (advertise == 5)
            {
                MessageBox.Show("Out of advertisement");
            }
            advertise += 1;
            Models.User user = con.Users.FirstOrDefault(u => u.UserId == 2);
            user.NumberOfAdvertisement = advertise;
            user.Money = user.Money + 500;
            con.Update(user);
            con.SaveChanges();
            Advertising a = new Advertising();
            a.ShowDialog();
        }
    }
}
