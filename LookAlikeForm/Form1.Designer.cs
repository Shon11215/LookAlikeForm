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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_email_info = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btm_sumbit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.pnl_create = new System.Windows.Forms.Panel();
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
            this.groupBox1.SuspendLayout();
            this.pnl_create.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(151, 74);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(253, 20);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to your digital closet:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(99, 134);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(52, 17);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(99, 180);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(81, 17);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "password:";
            // 
            // txt_email_info
            // 
            this.txt_email_info.Location = new System.Drawing.Point(171, 133);
            this.txt_email_info.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email_info.Name = "txt_email_info";
            this.txt_email_info.Size = new System.Drawing.Size(121, 20);
            this.txt_email_info.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(198, 179);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(93, 20);
            this.txt_pass.TabIndex = 4;
            // 
            // btm_sumbit
            // 
            this.btm_sumbit.Location = new System.Drawing.Point(198, 239);
            this.btm_sumbit.Margin = new System.Windows.Forms.Padding(2);
            this.btm_sumbit.Name = "btm_sumbit";
            this.btm_sumbit.Size = new System.Drawing.Size(64, 34);
            this.btm_sumbit.TabIndex = 5;
            this.btm_sumbit.Text = "submit";
            this.btm_sumbit.UseVisualStyleBackColor = true;
            this.btm_sumbit.Click += new System.EventHandler(this.btm_sumbit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.btm_sumbit);
            this.groupBox1.Controls.Add(this.lbl_welcome);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.txt_email_info);
            this.groupBox1.Controls.Add(this.lbl_pass);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(37, 21);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(198, 33);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name - ";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(247, 31);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(68, 18);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(198, 60);
            this.lbl_color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(54, 13);
            this.lbl_color.TabIndex = 3;
            this.lbl_color.Text = "Color ID - ";
            // 
            // pnl_create
            // 
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
            this.pnl_create.Location = new System.Drawing.Point(73, 42);
            this.pnl_create.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_create.Name = "pnl_create";
            this.pnl_create.Size = new System.Drawing.Size(606, 415);
            this.pnl_create.TabIndex = 8;
            // 
            // btn_id
            // 
            this.btn_id.Location = new System.Drawing.Point(247, 51);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(74, 24);
            this.btn_id.TabIndex = 20;
            this.btn_id.Text = "click";
            this.btn_id.UseVisualStyleBackColor = true;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(240, 328);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(106, 33);
            this.btn_create.TabIndex = 19;
            this.btn_create.Text = "Create item.";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_casual
            // 
            this.lbl_casual.AutoSize = true;
            this.lbl_casual.Location = new System.Drawing.Point(134, 290);
            this.lbl_casual.Name = "lbl_casual";
            this.lbl_casual.Size = new System.Drawing.Size(98, 13);
            this.lbl_casual.TabIndex = 18;
            this.lbl_casual.Text = "Is the item casual ?";
            // 
            // chk_casual
            // 
            this.chk_casual.AutoSize = true;
            this.chk_casual.Location = new System.Drawing.Point(240, 291);
            this.chk_casual.Name = "chk_casual";
            this.chk_casual.Size = new System.Drawing.Size(15, 14);
            this.chk_casual.TabIndex = 17;
            this.chk_casual.UseVisualStyleBackColor = true;
            // 
            // lbl_favorite
            // 
            this.lbl_favorite.AutoSize = true;
            this.lbl_favorite.Location = new System.Drawing.Point(134, 268);
            this.lbl_favorite.Name = "lbl_favorite";
            this.lbl_favorite.Size = new System.Drawing.Size(102, 13);
            this.lbl_favorite.TabIndex = 16;
            this.lbl_favorite.Text = "Is the item favorite ?";
            // 
            // chk_favorite
            // 
            this.chk_favorite.AutoSize = true;
            this.chk_favorite.Location = new System.Drawing.Point(240, 269);
            this.chk_favorite.Name = "chk_favorite";
            this.chk_favorite.Size = new System.Drawing.Size(15, 14);
            this.chk_favorite.TabIndex = 15;
            this.chk_favorite.UseVisualStyleBackColor = true;
            // 
            // lbl_seasson
            // 
            this.lbl_seasson.AutoSize = true;
            this.lbl_seasson.Location = new System.Drawing.Point(67, 233);
            this.lbl_seasson.Name = "lbl_seasson";
            this.lbl_seasson.Size = new System.Drawing.Size(166, 13);
            this.lbl_seasson.TabIndex = 14;
            this.lbl_seasson.Text = "Pick the seassons this item fit for -";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chk_summer);
            this.flowLayoutPanel1.Controls.Add(this.chk_Fall);
            this.flowLayoutPanel1.Controls.Add(this.chk_winter);
            this.flowLayoutPanel1.Controls.Add(this.chk_spring);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(240, 223);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 40);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // chk_summer
            // 
            this.chk_summer.AutoSize = true;
            this.chk_summer.Location = new System.Drawing.Point(3, 3);
            this.chk_summer.Name = "chk_summer";
            this.chk_summer.Size = new System.Drawing.Size(64, 17);
            this.chk_summer.TabIndex = 15;
            this.chk_summer.Text = "Summer";
            this.chk_summer.UseVisualStyleBackColor = true;
            // 
            // chk_Fall
            // 
            this.chk_Fall.AutoSize = true;
            this.chk_Fall.Location = new System.Drawing.Point(73, 3);
            this.chk_Fall.Name = "chk_Fall";
            this.chk_Fall.Size = new System.Drawing.Size(42, 17);
            this.chk_Fall.TabIndex = 16;
            this.chk_Fall.Text = "Fall";
            this.chk_Fall.UseVisualStyleBackColor = true;
            // 
            // chk_winter
            // 
            this.chk_winter.AutoSize = true;
            this.chk_winter.Location = new System.Drawing.Point(121, 3);
            this.chk_winter.Name = "chk_winter";
            this.chk_winter.Size = new System.Drawing.Size(57, 17);
            this.chk_winter.TabIndex = 17;
            this.chk_winter.Text = "Winter";
            this.chk_winter.UseVisualStyleBackColor = true;
            // 
            // chk_spring
            // 
            this.chk_spring.AutoSize = true;
            this.chk_spring.Location = new System.Drawing.Point(184, 3);
            this.chk_spring.Name = "chk_spring";
            this.chk_spring.Size = new System.Drawing.Size(56, 17);
            this.chk_spring.TabIndex = 18;
            this.chk_spring.Text = "Spring";
            this.chk_spring.UseVisualStyleBackColor = true;
            // 
            // lbl_usage
            // 
            this.lbl_usage.AutoSize = true;
            this.lbl_usage.Location = new System.Drawing.Point(164, 139);
            this.lbl_usage.Name = "lbl_usage";
            this.lbl_usage.Size = new System.Drawing.Size(82, 13);
            this.lbl_usage.TabIndex = 0;
            this.lbl_usage.Text = "Choose one of -";
            // 
            // lbl_sizes
            // 
            this.lbl_sizes.AutoSize = true;
            this.lbl_sizes.Location = new System.Drawing.Point(166, 84);
            this.lbl_sizes.Name = "lbl_sizes";
            this.lbl_sizes.Size = new System.Drawing.Size(82, 13);
            this.lbl_sizes.TabIndex = 12;
            this.lbl_sizes.Text = "Choose one of -";
            // 
            // flp_usage
            // 
            this.flp_usage.Location = new System.Drawing.Point(248, 130);
            this.flp_usage.Name = "flp_usage";
            this.flp_usage.Size = new System.Drawing.Size(269, 27);
            this.flp_usage.TabIndex = 0;
            // 
            // flp_sizes
            // 
            this.flp_sizes.Location = new System.Drawing.Point(249, 76);
            this.flp_sizes.Margin = new System.Windows.Forms.Padding(2);
            this.flp_sizes.Name = "flp_sizes";
            this.flp_sizes.Size = new System.Drawing.Size(269, 28);
            this.flp_sizes.TabIndex = 11;
            // 
            // Txt_NewItemBrand
            // 
            this.Txt_NewItemBrand.Location = new System.Drawing.Point(246, 195);
            this.Txt_NewItemBrand.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NewItemBrand.Name = "Txt_NewItemBrand";
            this.Txt_NewItemBrand.Size = new System.Drawing.Size(68, 20);
            this.Txt_NewItemBrand.TabIndex = 9;
            // 
            // txt_NewItemType
            // 
            this.txt_NewItemType.Location = new System.Drawing.Point(247, 164);
            this.txt_NewItemType.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NewItemType.Name = "txt_NewItemType";
            this.txt_NewItemType.Size = new System.Drawing.Size(68, 20);
            this.txt_NewItemType.TabIndex = 8;
            // 
            // txt_NewItemPrice
            // 
            this.txt_NewItemPrice.Location = new System.Drawing.Point(249, 107);
            this.txt_NewItemPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NewItemPrice.Name = "txt_NewItemPrice";
            this.txt_NewItemPrice.Size = new System.Drawing.Size(68, 20);
            this.txt_NewItemPrice.TabIndex = 7;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(198, 195);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(44, 13);
            this.lbl_brand.TabIndex = 6;
            this.lbl_brand.Text = "Brand - ";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(198, 170);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(40, 13);
            this.lbl_type.TabIndex = 5;
            this.lbl_type.Text = "Type - ";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(198, 112);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(40, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 468);
            this.Controls.Add(this.pnl_create);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_create.ResumeLayout(false);
            this.pnl_create.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_email_info;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btm_sumbit;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

