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
            this.txt_color = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.pnl_create = new System.Windows.Forms.Panel();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.txt_NewItemPrice = new System.Windows.Forms.TextBox();
            this.txt_NewItemType = new System.Windows.Forms.TextBox();
            this.Txt_NewItemBrand = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.pnl_create.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(227, 114);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(371, 29);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to your digital closet:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(149, 206);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(72, 25);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(149, 277);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(111, 25);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "password:";
            // 
            // txt_email_info
            // 
            this.txt_email_info.Location = new System.Drawing.Point(256, 205);
            this.txt_email_info.Name = "txt_email_info";
            this.txt_email_info.Size = new System.Drawing.Size(179, 26);
            this.txt_email_info.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(297, 276);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(138, 26);
            this.txt_pass.TabIndex = 4;
            // 
            // btm_sumbit
            // 
            this.btm_sumbit.Location = new System.Drawing.Point(297, 367);
            this.btm_sumbit.Name = "btm_sumbit";
            this.btm_sumbit.Size = new System.Drawing.Size(96, 52);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(56, 32);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(9, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name - ";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(83, 22);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 26);
            this.txt_name.TabIndex = 1;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(83, 55);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(100, 26);
            this.txt_color.TabIndex = 2;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(9, 61);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(80, 20);
            this.lbl_color.TabIndex = 3;
            this.lbl_color.Text = "Color ID - ";
            // 
            // pnl_create
            // 
            this.pnl_create.Controls.Add(this.Txt_NewItemBrand);
            this.pnl_create.Controls.Add(this.txt_NewItemType);
            this.pnl_create.Controls.Add(this.txt_NewItemPrice);
            this.pnl_create.Controls.Add(this.lbl_brand);
            this.pnl_create.Controls.Add(this.lbl_type);
            this.pnl_create.Controls.Add(this.lbl_price);
            this.pnl_create.Controls.Add(this.txt_name);
            this.pnl_create.Controls.Add(this.txt_color);
            this.pnl_create.Controls.Add(this.lbl_color);
            this.pnl_create.Controls.Add(this.lbl_name);
            this.pnl_create.Location = new System.Drawing.Point(12, 106);
            this.pnl_create.Name = "pnl_create";
            this.pnl_create.Size = new System.Drawing.Size(270, 316);
            this.pnl_create.TabIndex = 8;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(9, 138);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(57, 20);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price - ";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(9, 194);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(56, 20);
            this.lbl_type.TabIndex = 5;
            this.lbl_type.Text = "Type - ";
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(9, 237);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(65, 20);
            this.lbl_brand.TabIndex = 6;
            this.lbl_brand.Text = "Brand - ";
            // 
            // txt_NewItemPrice
            // 
            this.txt_NewItemPrice.Location = new System.Drawing.Point(83, 131);
            this.txt_NewItemPrice.Name = "txt_NewItemPrice";
            this.txt_NewItemPrice.Size = new System.Drawing.Size(100, 26);
            this.txt_NewItemPrice.TabIndex = 7;
            // 
            // txt_NewItemType
            // 
            this.txt_NewItemType.Location = new System.Drawing.Point(83, 194);
            this.txt_NewItemType.Name = "txt_NewItemType";
            this.txt_NewItemType.Size = new System.Drawing.Size(100, 26);
            this.txt_NewItemType.TabIndex = 8;
            // 
            // Txt_NewItemBrand
            // 
            this.Txt_NewItemBrand.Location = new System.Drawing.Point(83, 237);
            this.Txt_NewItemBrand.Name = "Txt_NewItemBrand";
            this.Txt_NewItemBrand.Size = new System.Drawing.Size(100, 26);
            this.Txt_NewItemBrand.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(288, 187);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 100);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(135, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 456);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnl_create);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Panel pnl_create;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox Txt_NewItemBrand;
        private System.Windows.Forms.TextBox txt_NewItemType;
        private System.Windows.Forms.TextBox txt_NewItemPrice;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

