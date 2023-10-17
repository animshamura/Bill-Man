namespace _Coffee_Shop
{
    partial class CoffeeShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.CBox1 = new System.Windows.Forms.ComboBox();
            this.CBox2 = new System.Windows.Forms.ComboBox();
            this.RText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button.Location = new System.Drawing.Point(262, 242);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 31);
            this.Button.TabIndex = 0;
            this.Button.Text = "Save ";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact No. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Coffee Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(197, 77);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(207, 22);
            this.Name.TabIndex = 7;
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(197, 108);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(207, 22);
            this.Contact.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(197, 139);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(207, 22);
            this.Address.TabIndex = 9;
            // 
            // CBox1
            // 
            this.CBox1.FormattingEnabled = true;
            this.CBox1.Items.AddRange(new object[] {
            "Latte",
            "Cappuccino",
            "Americano",
            "Espresso",
            "Mocha"});
            this.CBox1.Location = new System.Drawing.Point(197, 169);
            this.CBox1.Name = "CBox1";
            this.CBox1.Size = new System.Drawing.Size(207, 22);
            this.CBox1.TabIndex = 10;
            // 
            // CBox2
            // 
            this.CBox2.FormattingEnabled = true;
            this.CBox2.Items.AddRange(new object[] {
            "Large",
            "Regular",
            "Small"});
            this.CBox2.Location = new System.Drawing.Point(197, 198);
            this.CBox2.Name = "CBox2";
            this.CBox2.Size = new System.Drawing.Size(207, 22);
            this.CBox2.TabIndex = 11;
            // 
            // RText
            // 
            this.RText.Location = new System.Drawing.Point(486, 37);
            this.RText.Name = "RText";
            this.RText.Size = new System.Drawing.Size(239, 226);
            this.RText.TabIndex = 12;
            this.RText.Text = "";
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::_Coffee_Shop.Properties.Resources._342176924_1094269111531389_8759585060751367048_n;
            this.ClientSize = new System.Drawing.Size(789, 328);
            this.Controls.Add(this.RText);
            this.Controls.Add(this.CBox2);
            this.Controls.Add(this.CBox1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.CoffeeShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Name;
        private TextBox Contact;
        private TextBox Address;
        private ComboBox CBox1;
        private ComboBox CBox2;
        private RichTextBox RText;
    }
}