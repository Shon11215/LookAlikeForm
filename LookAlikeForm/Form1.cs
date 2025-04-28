using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace LookAlikeForm
{
    public partial class Form1 : Form
    {
        ClothingItem[] clothes = new ClothingItem[1];
        string curr_user = null;
        string curr_id = null;
        bool is_valid = false;
        User[] users = new User[]{
             new User("123456789", "dor", "123", "John",
             "Doe", "Johnny", "123-456-7890", new DateTime(1990, 5, 12)),

             new User("987654321", "user2@example.com", "Secure456", "Jane",
             "Smith", "Janie", "987-654-3210", new DateTime(1985, 8, 25)),

             new User("951753852", "user3@example.com", "Strong789", "Alex",
             "Brown", "Al", "555-666-7777", new DateTime(1998, 12, 3))};

        public Form1()
        {
            InitializeComponent();
            Create_flow(typeof(Sizes), flp_sizes);
            Create_flow(typeof(Usage), flp_usage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btm_sumbit_Click(object sender, EventArgs e)
        {
            curr_id = Login(users, out curr_user);
            if (curr_id != null)
            {
                OpenPage(pnl_login, false);
                OpenPage(pnl_main, true);
                lbl_hello.Text += $"{curr_user}!";
            }
        }

        private string Login(User[] users, out string curr_user)
        {
            string email = txt_email_info.Text;
            string password = txt_pass.Text;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Email == email && users[i].Password == password)
                {
                    btm_sumbit.Enabled = false;
                    curr_user = users[i].FirstName;
                    return users[i].UserId;

                }

            }
            txt_email_info.Text = "";
            txt_pass.Text = "";
            MessageBox.Show("Wrong Email or Password. ");
            curr_user = null;
            return null;

        }

        void Create_flow(Type enum_type, FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            foreach (Object usage in Enum.GetValues(enum_type))
            {
                RadioButton radio_btn = new RadioButton();
                radio_btn.Text = usage.ToString();
                radio_btn.AutoSize = true;
                flp.Controls.Add(radio_btn);
            }
        }
        void CreateButtons()
        {
            flp_item_buttons.Controls.Clear();
            foreach (ClothingItem item in clothes)
            {
                if (item == null) continue;
                Button btn = new Button();
                btn.Text = item.Name;
                btn.Size = new Size(250, 75);
                btn.Font = new Font("Segoe UI", 18, FontStyle.Bold); 
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Tag = item;
                btn.Click += Btn_Click;
                flp_item_buttons.Controls.Add((Button)btn);
            }


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            ClothingItem clickedItem = clickedButton.Tag as ClothingItem;
            string seasons = string.Join(", ", clickedItem.Seasons);

            lst_item.View = View.List;
            lst_item.Clear();

            lbl_item_name.Text = clickedItem.Name; 
            lst_item.Items.Add("Size: " + clickedItem.Size);
            lst_item.Items.Add(clickedItem.Color);
            lst_item.Items.Add("Price: " + clickedItem.Cost);
            lst_item.Items.Add("How often: " + clickedItem.Usage);
            lst_item.Items.Add("Type: " + clickedItem.Type);
            lst_item.Items.Add("Brand: " + clickedItem.Brand);
            lst_item.Items.Add("Seasons: " + seasons);
            lst_item.Items.Add("Favorite?: " + (clickedItem.Is_favorite?"yes":"no"));
            lst_item.Items.Add("Casual?: " + (clickedItem.Is_casual?"yes":"no"));



        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            int price;
            if (RadioCheck(flp_sizes) != null && RadioCheck(flp_usage) != null &&
                int.TryParse(txt_NewItemPrice.Text, out price) && price >= 0)
            {
                ClothingItem item = new ClothingItem(curr_id, btn_id.BackColor.ToString(), txt_name.Text, Markseassons(), chk_favorite.Checked, RadioCheck(flp_usage),
               txt_NewItemType.Text, Txt_NewItemBrand.Text, int.Parse(txt_NewItemPrice.Text), RadioCheck(flp_sizes), chk_casual.Checked);
                is_valid = true;
                Array.Resize(ref clothes, clothes.Length + 1);
                clothes[clothes.Length - 1] = item;
            }
            MessageBox.Show(is_valid ? "Item was made!" : "Invalid item please enter valid item!");
            ClearBtn();

        }

        private void ClearBtn()
        {
            txt_name.Text = "";
            btn_id.BackColor = Color.White;
            txt_NewItemPrice.Text = "";
            txt_NewItemType.Text = "";
            Txt_NewItemBrand.Text = "";
            foreach (RadioButton item in flp_sizes.Controls)
            {
                item.Checked = false;
            }
            foreach (RadioButton item in flp_usage.Controls)
            {
                item.Checked = false;
            }
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                item.Checked = false;
            }
            chk_favorite.Checked = false;
            chk_casual.Checked = false;
        }

        string RadioCheck(FlowLayoutPanel flp)
        {
            foreach (RadioButton btn in flp.Controls)
            {
                if (btn.Checked) return btn.Text;
            }
            return null;
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            dlg.Color = btn_id.BackColor;
            dlg.ShowDialog();
            btn_id.BackColor = dlg.Color;
            dlg.Dispose();
        }
        string[] Markseassons()
        {
            string[] seasons_to_pass = new string[0];
            foreach (CheckBox box in flowLayoutPanel1.Controls)
            {
                if (box.Checked)
                {
                    Array.Resize(ref seasons_to_pass, seasons_to_pass.Length + 1);
                    seasons_to_pass[seasons_to_pass.Length - 1] = box.Text;
                }
            }
            return seasons_to_pass;
        }
        void OpenPage(Panel pnl, bool state)
        {
            pnl.Visible = state;
        }

        private void btn_NewItem_Click(object sender, EventArgs e)
        {
            OpenPage(pnl_main, false);
            OpenPage(pnl_create, true);
        }

        private void Btn_seeItem_Click(object sender, EventArgs e)
        {
            OpenPage(pnl_main, false);
            OpenPage(pnl_wardrobe, true);
            CreateButtons();
        }

        private void btn_back_make_Click(object sender, EventArgs e)
        {
            OpenPage(pnl_create, false);
            OpenPage(pnl_main, true);
        }

        private void btn_wardrobe_back_Click(object sender, EventArgs e)
        {
            OpenPage(pnl_wardrobe, false);
            OpenPage(pnl_main, true);
        }

        private void pnl_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
