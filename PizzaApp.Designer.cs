using System;
using System.ComponentModel;

namespace PizzaApp_Assignment_100973300
{
    partial class PizzaApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.ResetOrderButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePizza1 = new System.Windows.Forms.TabPage();
            this.cheBoxToppings = new System.Windows.Forms.CheckedListBox();
            this.ComBoxSpecialtyPizzas = new System.Windows.Forms.ComboBox();
            this.ComBoxSauces = new System.Windows.Forms.ComboBox();
            this.ComBoxCrust = new System.Windows.Forms.ComboBox();
            this.ComBoxSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBeverages2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.TextBoxWater = new System.Windows.Forms.TextBox();
            this.TextBoxSoda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageSpecialtyItems3 = new System.Windows.Forms.TabPage();
            this.cmboSpeciality = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageCustomerInfo4 = new System.Windows.Forms.TabPage();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorBoxSodaWater = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ErrorMsgEmpty = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPagePizza1.SuspendLayout();
            this.tabPageBeverages2.SuspendLayout();
            this.tabPageSpecialtyItems3.SuspendLayout();
            this.tabPageCustomerInfo4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PlaceOrderButton.Location = new System.Drawing.Point(331, 335);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(115, 31);
            this.PlaceOrderButton.TabIndex = 5;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // ResetOrderButton
            // 
            this.ResetOrderButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ResetOrderButton.Location = new System.Drawing.Point(200, 335);
            this.ResetOrderButton.Name = "ResetOrderButton";
            this.ResetOrderButton.Size = new System.Drawing.Size(115, 31);
            this.ResetOrderButton.TabIndex = 4;
            this.ResetOrderButton.Text = "Reset Order";
            this.ResetOrderButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePizza1);
            this.tabControl.Controls.Add(this.tabPageBeverages2);
            this.tabControl.Controls.Add(this.tabPageSpecialtyItems3);
            this.tabControl.Controls.Add(this.tabPageCustomerInfo4);
            this.tabControl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(69, 23);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(516, 296);
            this.tabControl.TabIndex = 3;
            // 
            // tabPagePizza1
            // 
            this.tabPagePizza1.Controls.Add(this.cheBoxToppings);
            this.tabPagePizza1.Controls.Add(this.ComBoxSpecialtyPizzas);
            this.tabPagePizza1.Controls.Add(this.ComBoxSauces);
            this.tabPagePizza1.Controls.Add(this.ComBoxCrust);
            this.tabPagePizza1.Controls.Add(this.ComBoxSize);
            this.tabPagePizza1.Controls.Add(this.label6);
            this.tabPagePizza1.Controls.Add(this.label5);
            this.tabPagePizza1.Controls.Add(this.label4);
            this.tabPagePizza1.Controls.Add(this.label3);
            this.tabPagePizza1.Controls.Add(this.label2);
            this.tabPagePizza1.Controls.Add(this.label1);
            this.tabPagePizza1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePizza1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPagePizza1.Location = new System.Drawing.Point(4, 25);
            this.tabPagePizza1.Name = "tabPagePizza1";
            this.tabPagePizza1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePizza1.Size = new System.Drawing.Size(508, 267);
            this.tabPagePizza1.TabIndex = 0;
            this.tabPagePizza1.Text = "Pizza";
            this.tabPagePizza1.UseVisualStyleBackColor = true;
            // 
            // cheBoxToppings
            // 
            this.cheBoxToppings.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheBoxToppings.ForeColor = System.Drawing.Color.Purple;
            this.cheBoxToppings.FormattingEnabled = true;
            this.cheBoxToppings.Items.AddRange(new object[] {
            "Anchovies\t",
            "Onions",
            "Beef\t",
            "Pepperoni",
            "Bacon\t",
            "Peppers",
            "Black olives\t",
            "Pesto",
            "Chicken\t",
            "Pineapple",
            "Extra cheese\t",
            "Sausage",
            "Ham\t",
            "Spinach",
            "Mushrooms"});
            this.cheBoxToppings.Location = new System.Drawing.Point(292, 86);
            this.cheBoxToppings.Name = "cheBoxToppings";
            this.cheBoxToppings.Size = new System.Drawing.Size(163, 148);
            this.cheBoxToppings.TabIndex = 10;
            // 
            // ComBoxSpecialtyPizzas
            // 
            this.ComBoxSpecialtyPizzas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSpecialtyPizzas.ForeColor = System.Drawing.Color.Purple;
            this.ComBoxSpecialtyPizzas.FormattingEnabled = true;
            this.ComBoxSpecialtyPizzas.Items.AddRange(new object[] {
            "Veggie",
            "BBQ Chicken Feast",
            "Hawaiian",
            "Pepperoni Feast",
            "Philly Steak"});
            this.ComBoxSpecialtyPizzas.Location = new System.Drawing.Point(48, 212);
            this.ComBoxSpecialtyPizzas.Name = "ComBoxSpecialtyPizzas";
            this.ComBoxSpecialtyPizzas.Size = new System.Drawing.Size(208, 24);
            this.ComBoxSpecialtyPizzas.TabIndex = 9;
            // 
            // ComBoxSauces
            // 
            this.ComBoxSauces.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSauces.ForeColor = System.Drawing.Color.Purple;
            this.ComBoxSauces.FormattingEnabled = true;
            this.ComBoxSauces.Items.AddRange(new object[] {
            "Pesto",
            "Salsa",
            "BBQ Sauce",
            "Ranch Sauce"});
            this.ComBoxSauces.Location = new System.Drawing.Point(48, 166);
            this.ComBoxSauces.Name = "ComBoxSauces";
            this.ComBoxSauces.Size = new System.Drawing.Size(208, 24);
            this.ComBoxSauces.TabIndex = 8;
            // 
            // ComBoxCrust
            // 
            this.ComBoxCrust.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxCrust.ForeColor = System.Drawing.Color.Purple;
            this.ComBoxCrust.FormattingEnabled = true;
            this.ComBoxCrust.Items.AddRange(new object[] {
            "THIN \'N\' CRISPY",
            "EDGE",
            "CLASSIC CRUST",
            "CHEESY CRUST"});
            this.ComBoxCrust.Location = new System.Drawing.Point(48, 119);
            this.ComBoxCrust.Name = "ComBoxCrust";
            this.ComBoxCrust.Size = new System.Drawing.Size(208, 24);
            this.ComBoxCrust.TabIndex = 7;
            // 
            // ComBoxSize
            // 
            this.ComBoxSize.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSize.ForeColor = System.Drawing.Color.Purple;
            this.ComBoxSize.FormattingEnabled = true;
            this.ComBoxSize.Items.AddRange(new object[] {
            "Small (10 inch) - $9.99",
            "Medium (12 inch) - $12.99",
            "Large (16 inch) - $15.99"});
            this.ComBoxSize.Location = new System.Drawing.Point(48, 73);
            this.ComBoxSize.Name = "ComBoxSize";
            this.ComBoxSize.Size = new System.Drawing.Size(208, 24);
            this.ComBoxSize.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Crust";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Specially Pizzas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sauces";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings - $1.50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzaaaaaaaaaaaaa";
            // 
            // tabPageBeverages2
            // 
            this.tabPageBeverages2.Controls.Add(this.label19);
            this.tabPageBeverages2.Controls.Add(this.label18);
            this.tabPageBeverages2.Controls.Add(this.ErrorBoxSodaWater);
            this.tabPageBeverages2.Controls.Add(this.label12);
            this.tabPageBeverages2.Controls.Add(this.TextBoxWater);
            this.tabPageBeverages2.Controls.Add(this.TextBoxSoda);
            this.tabPageBeverages2.Controls.Add(this.label11);
            this.tabPageBeverages2.Controls.Add(this.label10);
            this.tabPageBeverages2.Controls.Add(this.label7);
            this.tabPageBeverages2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBeverages2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPageBeverages2.Location = new System.Drawing.Point(4, 25);
            this.tabPageBeverages2.Name = "tabPageBeverages2";
            this.tabPageBeverages2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBeverages2.Size = new System.Drawing.Size(508, 267);
            this.tabPageBeverages2.TabIndex = 1;
            this.tabPageBeverages2.Text = "Beverages";
            this.tabPageBeverages2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(258, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Quantity";
            // 
            // TextBoxWater
            // 
            this.TextBoxWater.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWater.ForeColor = System.Drawing.Color.Purple;
            this.TextBoxWater.Location = new System.Drawing.Point(241, 138);
            this.TextBoxWater.Name = "TextBoxWater";
            this.TextBoxWater.Size = new System.Drawing.Size(100, 23);
            this.TextBoxWater.TabIndex = 4;
            this.TextBoxWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxSoda
            // 
            this.TextBoxSoda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSoda.ForeColor = System.Drawing.Color.Purple;
            this.TextBoxSoda.Location = new System.Drawing.Point(241, 105);
            this.TextBoxSoda.Name = "TextBoxSoda";
            this.TextBoxSoda.Size = new System.Drawing.Size(100, 23);
            this.TextBoxSoda.TabIndex = 3;
            this.TextBoxSoda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Water(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Soda(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(147, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pizzaaaaaaaaaaaaa";
            // 
            // tabPageSpecialtyItems3
            // 
            this.tabPageSpecialtyItems3.Controls.Add(this.cmboSpeciality);
            this.tabPageSpecialtyItems3.Controls.Add(this.label13);
            this.tabPageSpecialtyItems3.Controls.Add(this.label8);
            this.tabPageSpecialtyItems3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSpecialtyItems3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPageSpecialtyItems3.Location = new System.Drawing.Point(4, 25);
            this.tabPageSpecialtyItems3.Name = "tabPageSpecialtyItems3";
            this.tabPageSpecialtyItems3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpecialtyItems3.Size = new System.Drawing.Size(508, 267);
            this.tabPageSpecialtyItems3.TabIndex = 2;
            this.tabPageSpecialtyItems3.Text = "Specialty Items";
            this.tabPageSpecialtyItems3.UseVisualStyleBackColor = true;
            // 
            // cmboSpeciality
            // 
            this.cmboSpeciality.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSpeciality.ForeColor = System.Drawing.Color.Purple;
            this.cmboSpeciality.FormattingEnabled = true;
            this.cmboSpeciality.Items.AddRange(new object[] {
            "Wings - $5.00",
            "Cheese Sticks - $4.00",
            "Garlic Bread - $3.00"});
            this.cmboSpeciality.Location = new System.Drawing.Point(160, 126);
            this.cmboSpeciality.Name = "cmboSpeciality";
            this.cmboSpeciality.Size = new System.Drawing.Size(169, 24);
            this.cmboSpeciality.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(175, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Specialty Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(147, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pizzaaaaaaaaaaaaa";
            // 
            // tabPageCustomerInfo4
            // 
            this.tabPageCustomerInfo4.Controls.Add(this.label28);
            this.tabPageCustomerInfo4.Controls.Add(this.label27);
            this.tabPageCustomerInfo4.Controls.Add(this.label26);
            this.tabPageCustomerInfo4.Controls.Add(this.label25);
            this.tabPageCustomerInfo4.Controls.Add(this.label24);
            this.tabPageCustomerInfo4.Controls.Add(this.label23);
            this.tabPageCustomerInfo4.Controls.Add(this.label22);
            this.tabPageCustomerInfo4.Controls.Add(this.label21);
            this.tabPageCustomerInfo4.Controls.Add(this.label20);
            this.tabPageCustomerInfo4.Controls.Add(this.ErrorMsgEmpty);
            this.tabPageCustomerInfo4.Controls.Add(this.textBoxEmail);
            this.tabPageCustomerInfo4.Controls.Add(this.textBoxAddress);
            this.tabPageCustomerInfo4.Controls.Add(this.textBoxPhone);
            this.tabPageCustomerInfo4.Controls.Add(this.textBoxName);
            this.tabPageCustomerInfo4.Controls.Add(this.label17);
            this.tabPageCustomerInfo4.Controls.Add(this.label16);
            this.tabPageCustomerInfo4.Controls.Add(this.label15);
            this.tabPageCustomerInfo4.Controls.Add(this.label14);
            this.tabPageCustomerInfo4.Controls.Add(this.label9);
            this.tabPageCustomerInfo4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCustomerInfo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPageCustomerInfo4.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomerInfo4.Name = "tabPageCustomerInfo4";
            this.tabPageCustomerInfo4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerInfo4.Size = new System.Drawing.Size(508, 267);
            this.tabPageCustomerInfo4.TabIndex = 3;
            this.tabPageCustomerInfo4.Text = "Customer Info";
            this.tabPageCustomerInfo4.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(238, 184);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(204, 23);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(238, 103);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(204, 23);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(238, 144);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(204, 23);
            this.textBoxPhone.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(238, 63);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 23);
            this.textBoxName.TabIndex = 5;
            
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(70, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Phone Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Delivery Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(147, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pizzaaaaaaaaaaaaa";
            // 
            // ErrorBoxSodaWater
            // 
            this.ErrorBoxSodaWater.AutoSize = true;
            this.ErrorBoxSodaWater.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBoxSodaWater.Location = new System.Drawing.Point(192, 251);
            this.ErrorBoxSodaWater.Name = "ErrorBoxSodaWater";
            this.ErrorBoxSodaWater.Size = new System.Drawing.Size(0, 13);
            this.ErrorBoxSodaWater.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(252, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(124, 190);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(252, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "Soda cost  is $1.75 - Water is free";
            // 
            // ErrorMsgEmpty
            // 
            this.ErrorMsgEmpty.AutoSize = true;
            this.ErrorMsgEmpty.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsgEmpty.Location = new System.Drawing.Point(242, 89);
            this.ErrorMsgEmpty.Name = "ErrorMsgEmpty";
            this.ErrorMsgEmpty.Size = new System.Drawing.Size(0, 13);
            this.ErrorMsgEmpty.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(241, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(242, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(254, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 12;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(242, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 13);
            this.label23.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(242, 168);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 13);
            this.label24.TabIndex = 14;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(241, 210);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 13);
            this.label25.TabIndex = 15;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(262, 135);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 13);
            this.label26.TabIndex = 16;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(270, 143);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 17;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(278, 151);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 13);
            this.label28.TabIndex = 18;
            // 
            // PizzaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(648, 382);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.ResetOrderButton);
            this.Controls.Add(this.tabControl);
            this.Name = "PizzaApp";
            this.Text = "Pizzaaaaaaaaaaaaa";
            this.tabControl.ResumeLayout(false);
            this.tabPagePizza1.ResumeLayout(false);
            this.tabPagePizza1.PerformLayout();
            this.tabPageBeverages2.ResumeLayout(false);
            this.tabPageBeverages2.PerformLayout();
            this.tabPageSpecialtyItems3.ResumeLayout(false);
            this.tabPageSpecialtyItems3.PerformLayout();
            this.tabPageCustomerInfo4.ResumeLayout(false);
            this.tabPageCustomerInfo4.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button ResetOrderButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePizza1;
        private System.Windows.Forms.CheckedListBox cheBoxToppings;
        private System.Windows.Forms.ComboBox ComBoxSpecialtyPizzas;
        private System.Windows.Forms.ComboBox ComBoxSauces;
        private System.Windows.Forms.ComboBox ComBoxCrust;
        private System.Windows.Forms.ComboBox ComBoxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageBeverages2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextBoxWater;
        private System.Windows.Forms.TextBox TextBoxSoda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageSpecialtyItems3;
        private System.Windows.Forms.ComboBox cmboSpeciality;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageCustomerInfo4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label ErrorBoxSodaWater;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label ErrorMsgEmpty;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
    }
}

