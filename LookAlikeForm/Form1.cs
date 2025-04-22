using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookAlikeForm
{
    public partial class Form1 : Form
    {
        string curr_user = null;
        User[] users = new User[]{
             new User("123456789", "dor", "123", "John",
             "Doe", "Johnny", "123-456-7890", new DateTime(1990, 5, 12)),

             new User("987654321", "user2@example.com", "Secure456", "Jane",
             "Smith", "Janie", "987-654-3210", new DateTime(1985, 8, 25)),

             new User("951753852", "user3@example.com", "Strong789", "Alex",
             "Brown", "Al", "555-666-7777", new DateTime(1998, 12, 3))};

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btm_sumbit_Click(object sender, EventArgs e) {
            if (btm_sumbit.Enabled) {
                curr_user = Login(users);
            }        
        }

        private string Login(User[] users) {
            string email = txt_email_info.Text;
            string password = txt_pass.Text;
            for (int i = 0; i < users.Length; i++) {
                if (users[i].Email == email && users[i].Password == password) {
                    btm_sumbit.Enabled = false;
                    return users[i].UserId;

                }

            }
            txt_email_info.Text = "";
            txt_pass.Text = "";
            MessageBox.Show("Wrong Email or Password. ");
            return null;

        }
    }
}
