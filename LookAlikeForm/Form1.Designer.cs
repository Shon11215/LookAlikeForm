namespace LookAlikeForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnl_wardrobe = new System.Windows.Forms.Panel();
            this.btn_wardrobe_back = new System.Windows.Forms.Button();
            this.pnl_item_attribute = new System.Windows.Forms.Panel();
            this.lbl_item_name = new System.Windows.Forms.Label();
            this.lst_item = new System.Windows.Forms.ListView();
            this.pnl_create = new System.Windows.Forms.Panel();
            this.btn_back_make = new System.Windows.Forms.Button();
            this.btn_id = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_casual = new System.Windows.Forms.Label();
            this.chk_casual = new System.Windows.Forms.CheckBox();
            this.lbl_favorite = new System.Windows.Forms.Label();
            this.chk_favorite = new System.Windows.Forms.CheckBox();
            this.lbl_seasson = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chk_summer = new System.Windows.Forms.CheckBox();
            this.chk_Fall = new System.Windows.Forms.CheckBox();
            this.chk_winter = new System.Windows.Forms.CheckBox();
            this.chk_spring = new System.Windows.Forms.CheckBox();
            this.lbl_usage = new System.Windows.Forms.Label();
            this.lbl_sizes = new System.Windows.Forms.Label();
            this.flp_usage = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_sizes = new System.Windows.Forms.FlowLayoutPanel();
            this.Txt_NewItemBrand = new System.Windows.Forms.TextBox();
            this.txt_NewItemType = new System.Windows.Forms.TextBox();
            this.txt_NewItemPrice = new System.Windows.Forms.TextBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.flp_item_buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.Btn_seeItem = new System.Windows.Forms.Button();
            this.btn_NewItem = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.txt_email_info = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btm_sumbit = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnl_wardrobe.SuspendLayout();
            this.pnl_item_attribute.SuspendLayout();
            this.pnl_create.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnl_wardrobe
            // 
            this.pnl_wardrobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_wardrobe.Controls.Add(this.btn_wardrobe_back);
            this.pnl_wardrobe.Controls.Add(this.flp_item_buttons);
            this.pnl_wardrobe.Controls.Add(this.pnl_item_attribute);
            this.pnl_wardrobe.Location = new System.Drawing.Point(0, 0);
            this.pnl_wardrobe.Name = "pnl_wardrobe";
            this.pnl_wardrobe.Size = new System.Drawing.Size(900, 559);
            this.pnl_wardrobe.TabIndex = 11;
            this.pnl_wardrobe.Visible = false;
            // 
            // btn_wardrobe_back
            // 
            this.btn_wardrobe_back.Location = new System.Drawing.Point(423, 486);
            this.btn_wardrobe_back.Name = "btn_wardrobe_back";
            this.btn_wardrobe_back.Size = new System.Drawing.Size(348, 40);
            this.btn_wardrobe_back.TabIndex = 14;
            this.btn_wardrobe_back.Text = "Back";
            this.btn_wardrobe_back.UseVisualStyleBackColor = true;
            this.btn_wardrobe_back.Click += new System.EventHandler(this.btn_wardrobe_back_Click);
            // 
            // pnl_item_attribute
            // 
            this.pnl_item_attribute.BackColor = System.Drawing.Color.Transparent;
            this.pnl_item_attribute.Controls.Add(this.lbl_item_name);
            this.pnl_item_attribute.Controls.Add(this.lst_item);
            this.pnl_item_attribute.Location = new System.Drawing.Point(357, 3);
            this.pnl_item_attribute.Name = "pnl_item_attribute";
            this.pnl_item_attribute.Size = new System.Drawing.Size(540, 476);
            this.pnl_item_attribute.TabIndex = 12;
            // 
            // lbl_item_name
            // 
            this.lbl_item_name.AutoSize = true;
            this.lbl_item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_name.Location = new System.Drawing.Point(106, 2);
            this.lbl_item_name.Name = "lbl_item_name";
            this.lbl_item_name.Size = new System.Drawing.Size(0, 39);
            this.lbl_item_name.TabIndex = 1;
            // 
            // lst_item
            // 
            this.lst_item.Font = new System.Drawing.Font("Narkisim", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_item.HideSelection = false;
            this.lst_item.Location = new System.Drawing.Point(6, 44);
            this.lst_item.Name = "lst_item";
            this.lst_item.Size = new System.Drawing.Size(531, 431);
            this.lst_item.TabIndex = 0;
            this.lst_item.UseCompatibleStateImageBehavior = false;
            // 
            // pnl_create
            // 
            this.pnl_create.BackgroundImage = global::LookAlikeForm.Properties.Resources.Create3;
            this.pnl_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_create.Controls.Add(this.btn_back_make);
            this.pnl_create.Controls.Add(this.btn_id);
            this.pnl_create.Controls.Add(this.btn_create);
            this.pnl_create.Controls.Add(this.lbl_casual);
            this.pnl_create.Controls.Add(this.chk_casual);
            this.pnl_create.Controls.Add(this.lbl_favorite);
            this.pnl_create.Controls.Add(this.chk_favorite);
            this.pnl_create.Controls.Add(this.lbl_seasson);
            this.pnl_create.Controls.Add(this.flowLayoutPanel1);
            this.pnl_create.Controls.Add(this.lbl_usage);
            this.pnl_create.Controls.Add(this.lbl_sizes);
            this.pnl_create.Controls.Add(this.flp_usage);
            this.pnl_create.Controls.Add(this.flp_sizes);
            this.pnl_create.Controls.Add(this.Txt_NewItemBrand);
            this.pnl_create.Controls.Add(this.txt_NewItemType);
            this.pnl_create.Controls.Add(this.txt_NewItemPrice);
            this.pnl_create.Controls.Add(this.lbl_brand);
            this.pnl_create.Controls.Add(this.lbl_type);
            this.pnl_create.Controls.Add(this.lbl_price);
            this.pnl_create.Controls.Add(this.txt_name);
            this.pnl_create.Controls.Add(this.lbl_color);
            this.pnl_create.Controls.Add(this.lbl_name);
            this.pnl_create.Location = new System.Drawing.Point(0, 0);
            this.pnl_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_create.Name = "pnl_create";
            this.pnl_create.Size = new System.Drawing.Size(900, 562);
            this.pnl_create.TabIndex = 8;
            this.pnl_create.Visible = false;
            // 
            // btn_back_make
            // 
            this.btn_back_make.Location = new System.Drawing.Point(32, 415);
            this.btn_back_make.Name = "btn_back_make";
            this.btn_back_make.Size = new System.Drawing.Size(93, 32);
            this.btn_back_make.TabIndex = 21;
            this.btn_back_make.Text = "Back";
            this.btn_back_make.UseVisualStyleBackColor = true;
            this.btn_back_make.Click += new System.EventHandler(this.btn_back_make_Click);
            // 
            // btn_id
            // 
            this.btn_id.Location = new System.Drawing.Point(329, 63);
            this.btn_id.Margin = new System.Windows.Forms.Padding(4);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(99, 30);
            this.btn_id.TabIndex = 20;
            this.btn_id.Text = "click";
            this.btn_id.UseVisualStyleBackColor = true;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(320, 404);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(141, 41);
            this.btn_create.TabIndex = 19;
            this.btn_create.Text = "Create item.";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_casual
            // 
            this.lbl_casual.AutoSize = true;
            this.lbl_casual.Location = new System.Drawing.Point(179, 357);
            this.lbl_casual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_casual.Name = "lbl_casual";
            this.lbl_casual.Size = new System.Drawing.Size(119, 16);
            this.lbl_casual.TabIndex = 18;
            this.lbl_casual.Text = "Is the item casual ?";
            // 
            // chk_casual
            // 
            this.chk_casual.AutoSize = true;
            this.chk_casual.Location = new System.Drawing.Point(320, 358);
            this.chk_casual.Margin = new System.Windows.Forms.Padding(4);
            this.chk_casual.Name = "chk_casual";
            this.chk_casual.Size = new System.Drawing.Size(18, 17);
            this.chk_casual.TabIndex = 17;
            this.chk_casual.UseVisualStyleBackColor = true;
            // 
            // lbl_favorite
            // 
            this.lbl_favorite.AutoSize = true;
            this.lbl_favorite.Location = new System.Drawing.Point(179, 330);
            this.lbl_favorite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_favorite.Name = "lbl_favorite";
            this.lbl_favorite.Size = new System.Drawing.Size(123, 16);
            this.lbl_favorite.TabIndex = 16;
            this.lbl_favorite.Text = "Is the item favorite ?";
            // 
            // chk_favorite
            // 
            this.chk_favorite.AutoSize = true;
            this.chk_favorite.Location = new System.Drawing.Point(320, 331);
            this.chk_favorite.Margin = new System.Windows.Forms.Padding(4);
            this.chk_favorite.Name = "chk_favorite";
            this.chk_favorite.Size = new System.Drawing.Size(18, 17);
            this.chk_favorite.TabIndex = 15;
            this.chk_favorite.UseVisualStyleBackColor = true;
            // 
            // lbl_seasson
            // 
            this.lbl_seasson.AutoSize = true;
            this.lbl_seasson.Location = new System.Drawing.Point(89, 287);
            this.lbl_seasson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_seasson.Name = "lbl_seasson";
            this.lbl_seasson.Size = new System.Drawing.Size(204, 16);
            this.lbl_seasson.TabIndex = 14;
            this.lbl_seasson.Text = "Pick the seassons this item fit for -";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chk_summer);
            this.flowLayoutPanel1.Controls.Add(this.chk_Fall);
            this.flowLayoutPanel1.Controls.Add(this.chk_winter);
            this.flowLayoutPanel1.Controls.Add(this.chk_spring);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(320, 274);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 49);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // chk_summer
            // 
            this.chk_summer.AutoSize = true;
            this.chk_summer.Location = new System.Drawing.Point(4, 4);
            this.chk_summer.Margin = new System.Windows.Forms.Padding(4);
            this.chk_summer.Name = "chk_summer";
            this.chk_summer.Size = new System.Drawing.Size(79, 20);
            this.chk_summer.TabIndex = 15;
            this.chk_summer.Text = "Summer";
            this.chk_summer.UseVisualStyleBackColor = true;
            // 
            // chk_Fall
            // 
            this.chk_Fall.AutoSize = true;
            this.chk_Fall.Location = new System.Drawing.Point(91, 4);
            this.chk_Fall.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Fall.Name = "chk_Fall";
            this.chk_Fall.Size = new System.Drawing.Size(51, 20);
            this.chk_Fall.TabIndex = 16;
            this.chk_Fall.Text = "Fall";
            this.chk_Fall.UseVisualStyleBackColor = true;
            // 
            // chk_winter
            // 
            this.chk_winter.AutoSize = true;
            this.chk_winter.Location = new System.Drawing.Point(150, 4);
            this.chk_winter.Margin = new System.Windows.Forms.Padding(4);
            this.chk_winter.Name = "chk_winter";
            this.chk_winter.Size = new System.Drawing.Size(67, 20);
            this.chk_winter.TabIndex = 17;
            this.chk_winter.Text = "Winter";
            this.chk_winter.UseVisualStyleBackColor = true;
            // 
            // chk_spring
            // 
            this.chk_spring.AutoSize = true;
            this.chk_spring.Location = new System.Drawing.Point(225, 4);
            this.chk_spring.Margin = new System.Windows.Forms.Padding(4);
            this.chk_spring.Name = "chk_spring";
            this.chk_spring.Size = new System.Drawing.Size(68, 20);
            this.chk_spring.TabIndex = 18;
            this.chk_spring.Text = "Spring";
            this.chk_spring.UseVisualStyleBackColor = true;
            // 
            // lbl_usage
            // 
            this.lbl_usage.AutoSize = true;
            this.lbl_usage.Location = new System.Drawing.Point(219, 171);
            this.lbl_usage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usage.Name = "lbl_usage";
            this.lbl_usage.Size = new System.Drawing.Size(101, 16);
            this.lbl_usage.TabIndex = 0;
            this.lbl_usage.Text = "Choose one of -";
            // 
            // lbl_sizes
            // 
            this.lbl_sizes.AutoSize = true;
            this.lbl_sizes.Location = new System.Drawing.Point(221, 103);
            this.lbl_sizes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sizes.Name = "lbl_sizes";
            this.lbl_sizes.Size = new System.Drawing.Size(101, 16);
            this.lbl_sizes.TabIndex = 12;
            this.lbl_sizes.Text = "Choose one of -";
            // 
            // flp_usage
            // 
            this.flp_usage.Location = new System.Drawing.Point(331, 160);
            this.flp_usage.Margin = new System.Windows.Forms.Padding(4);
            this.flp_usage.Name = "flp_usage";
            this.flp_usage.Size = new System.Drawing.Size(359, 33);
            this.flp_usage.TabIndex = 0;
            // 
            // flp_sizes
            // 
            this.flp_sizes.Location = new System.Drawing.Point(332, 94);
            this.flp_sizes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_sizes.Name = "flp_sizes";
            this.flp_sizes.Size = new System.Drawing.Size(359, 34);
            this.flp_sizes.TabIndex = 11;
            // 
            // Txt_NewItemBrand
            // 
            this.Txt_NewItemBrand.Location = new System.Drawing.Point(328, 240);
            this.Txt_NewItemBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NewItemBrand.Name = "Txt_NewItemBrand";
            this.Txt_NewItemBrand.Size = new System.Drawing.Size(89, 22);
            this.Txt_NewItemBrand.TabIndex = 9;
            // 
            // txt_NewItemType
            // 
            this.txt_NewItemType.Location = new System.Drawing.Point(329, 202);
            this.txt_NewItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NewItemType.Name = "txt_NewItemType";
            this.txt_NewItemType.Size = new System.Drawing.Size(89, 22);
            this.txt_NewItemType.TabIndex = 8;
            // 
            // txt_NewItemPrice
            // 
            this.txt_NewItemPrice.Location = new System.Drawing.Point(332, 132);
            this.txt_NewItemPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NewItemPrice.Name = "txt_NewItemPrice";
            this.txt_NewItemPrice.Size = new System.Drawing.Size(89, 22);
            this.txt_NewItemPrice.TabIndex = 7;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(264, 240);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(53, 16);
            this.lbl_brand.TabIndex = 6;
            this.lbl_brand.Text = "Brand - ";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(264, 209);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(49, 16);
            this.lbl_type.TabIndex = 5;
            this.lbl_type.Text = "Type - ";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(264, 138);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(48, 16);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price - ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(329, 38);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(89, 21);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(264, 74);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(65, 16);
            this.lbl_color.TabIndex = 3;
            this.lbl_color.Text = "Color ID - ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(264, 41);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name - ";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_item_buttons
            // 
            this.flp_item_buttons.AutoScroll = true;
            this.flp_item_buttons.AutoSize = true;
            this.flp_item_buttons.BackColor = System.Drawing.Color.Transparent;
            this.flp_item_buttons.BackgroundImage = global::LookAlikeForm.Properties.Resources.Wardrobe;
            this.flp_item_buttons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_item_buttons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_item_buttons.Location = new System.Drawing.Point(6, 3);
            this.flp_item_buttons.Name = "flp_item_buttons";
            this.flp_item_buttons.Size = new System.Drawing.Size(345, 523);
            this.flp_item_buttons.TabIndex = 13;
            // 
            // pnl_main
            // 
            this.pnl_main.BackgroundImage = global::LookAlikeForm.Properties.Resources.Menu;
            this.pnl_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_main.Controls.Add(this.Btn_seeItem);
            this.pnl_main.Controls.Add(this.btn_NewItem);
            this.pnl_main.Controls.Add(this.lbl_hello);
            this.pnl_main.Location = new System.Drawing.Point(33, 12);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnl_main.Size = new System.Drawing.Size(867, 550);
            this.pnl_main.TabIndex = 10;
            this.pnl_main.Visible = false;
            // 
            // Btn_seeItem
            // 
            this.Btn_seeItem.Location = new System.Drawing.Point(470, 109);
            this.Btn_seeItem.Name = "Btn_seeItem";
            this.Btn_seeItem.Size = new System.Drawing.Size(176, 31);
            this.Btn_seeItem.TabIndex = 2;
            this.Btn_seeItem.Text = "Look trough your closet";
            this.Btn_seeItem.UseVisualStyleBackColor = true;
            this.Btn_seeItem.Click += new System.EventHandler(this.Btn_seeItem_Click);
            // 
            // btn_NewItem
            // 
            this.btn_NewItem.Location = new System.Drawing.Point(12, 189);
            this.btn_NewItem.Name = "btn_NewItem";
            this.btn_NewItem.Size = new System.Drawing.Size(177, 29);
            this.btn_NewItem.TabIndex = 1;
            this.btn_NewItem.Text = "Create a new item";
            this.btn_NewItem.UseVisualStyleBackColor = true;
            this.btn_NewItem.Click += new System.EventHandler(this.btn_NewItem_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hello.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello.Location = new System.Drawing.Point(3, -5);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(178, 60);
            this.lbl_hello.TabIndex = 0;
            this.lbl_hello.Text = "Welcome ";
            // 
            // pnl_login
            // 
            this.pnl_login.BackgroundImage = global::LookAlikeForm.Properties.Resources.Login2;
            this.pnl_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_login.Controls.Add(this.txt_email_info);
            this.pnl_login.Controls.Add(this.lbl_email);
            this.pnl_login.Controls.Add(this.txt_pass);
            this.pnl_login.Controls.Add(this.lbl_pass);
            this.pnl_login.Controls.Add(this.btm_sumbit);
            this.pnl_login.Controls.Add(this.lbl_welcome);
            this.pnl_login.Location = new System.Drawing.Point(0, 0);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(909, 562);
            this.pnl_login.TabIndex = 9;
            this.pnl_login.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_login_Paint);
            // 
            // txt_email_info
            // 
            this.txt_email_info.Location = new System.Drawing.Point(120, 108);
            this.txt_email_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email_info.Name = "txt_email_info";
            this.txt_email_info.Size = new System.Drawing.Size(160, 22);
            this.txt_email_info.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(24, 109);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 20);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(156, 164);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(123, 22);
            this.txt_pass.TabIndex = 4;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(24, 166);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(95, 20);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "password:";
            // 
            // btm_sumbit
            // 
            this.btm_sumbit.Location = new System.Drawing.Point(199, 214);
            this.btm_sumbit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_sumbit.Name = "btm_sumbit";
            this.btm_sumbit.Size = new System.Drawing.Size(85, 42);
            this.btm_sumbit.TabIndex = 5;
            this.btm_sumbit.Text = "submit";
            this.btm_sumbit.UseVisualStyleBackColor = true;
            this.btm_sumbit.Click += new System.EventHandler(this.btm_sumbit_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(93, 35);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(307, 25);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to your digital closet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 558);
            this.Controls.Add(this.pnl_wardrobe);
            this.Controls.Add(this.pnl_create);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_login);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnl_wardrobe.ResumeLayout(false);
            this.pnl_wardrobe.PerformLayout();
            this.pnl_item_attribute.ResumeLayout(false);
            this.pnl_item_attribute.PerformLayout();
            this.pnl_create.ResumeLayout(false);
            this.pnl_create.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_email_info;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btm_sumbit;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Panel pnl_create;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox Txt_NewItemBrand;
        private System.Windows.Forms.TextBox txt_NewItemType;
        private System.Windows.Forms.TextBox txt_NewItemPrice;
        private System.Windows.Forms.FlowLayoutPanel flp_sizes;
        private System.Windows.Forms.FlowLayoutPanel flp_usage;
        private System.Windows.Forms.Label lbl_sizes;
        private System.Windows.Forms.Label lbl_usage;
        private System.Windows.Forms.Label lbl_seasson;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chk_summer;
        private System.Windows.Forms.CheckBox chk_Fall;
        private System.Windows.Forms.CheckBox chk_winter;
        private System.Windows.Forms.CheckBox chk_spring;
        private System.Windows.Forms.Label lbl_casual;
        private System.Windows.Forms.CheckBox chk_casual;
        private System.Windows.Forms.Label lbl_favorite;
        private System.Windows.Forms.CheckBox chk_favorite;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_id;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_hello;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Btn_seeItem;
        private System.Windows.Forms.Button btn_NewItem;
        private System.Windows.Forms.Button btn_back_make;
        private System.Windows.Forms.Panel pnl_wardrobe;
        private System.Windows.Forms.Panel pnl_item_attribute;
        private System.Windows.Forms.FlowLayoutPanel flp_item_buttons;
        private System.Windows.Forms.Button btn_wardrobe_back;
        private System.Windows.Forms.ListView lst_item;
        private System.Windows.Forms.Label lbl_item_name;
    }
}

