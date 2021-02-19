namespace Oracle
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Ref = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Customer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_order_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.order_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.del_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.edit_invoice_value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.signed = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edit_invoice_cost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_Product = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.del_note_path = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.RBUSD = new System.Windows.Forms.RadioButton();
            this.RBZAR = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ref Number";
            // 
            // CB_Ref
            // 
            this.CB_Ref.FormattingEnabled = true;
            this.CB_Ref.Location = new System.Drawing.Point(171, 30);
            this.CB_Ref.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Ref.Name = "CB_Ref";
            this.CB_Ref.Size = new System.Drawing.Size(212, 24);
            this.CB_Ref.Sorted = true;
            this.CB_Ref.TabIndex = 2;
            this.CB_Ref.SelectedIndexChanged += new System.EventHandler(this.CB_Ref_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "RE / B / U Number";
            // 
            // CB_Customer
            // 
            this.CB_Customer.FormattingEnabled = true;
            this.CB_Customer.Location = new System.Drawing.Point(171, 63);
            this.CB_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Customer.Name = "CB_Customer";
            this.CB_Customer.Size = new System.Drawing.Size(212, 24);
            this.CB_Customer.Sorted = true;
            this.CB_Customer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer";
            // 
            // edit_order_number
            // 
            this.edit_order_number.Location = new System.Drawing.Point(171, 96);
            this.edit_order_number.Margin = new System.Windows.Forms.Padding(4);
            this.edit_order_number.Name = "edit_order_number";
            this.edit_order_number.Size = new System.Drawing.Size(212, 22);
            this.edit_order_number.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer order number";
            // 
            // order_date
            // 
            this.order_date.Location = new System.Drawing.Point(171, 128);
            this.order_date.Margin = new System.Windows.Forms.Padding(4);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(212, 22);
            this.order_date.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order date";
            // 
            // del_date
            // 
            this.del_date.Location = new System.Drawing.Point(171, 160);
            this.del_date.Margin = new System.Windows.Forms.Padding(4);
            this.del_date.Name = "del_date";
            this.del_date.Size = new System.Drawing.Size(212, 22);
            this.del_date.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Delivery date";
            // 
            // edit_invoice_value
            // 
            this.edit_invoice_value.Location = new System.Drawing.Point(171, 192);
            this.edit_invoice_value.Margin = new System.Windows.Forms.Padding(4);
            this.edit_invoice_value.Name = "edit_invoice_value";
            this.edit_invoice_value.Size = new System.Drawing.Size(212, 22);
            this.edit_invoice_value.TabIndex = 12;
            this.edit_invoice_value.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Invoice value excl VAT";
            // 
            // signed
            // 
            this.signed.AutoSize = true;
            this.signed.Location = new System.Drawing.Point(171, 332);
            this.signed.Margin = new System.Windows.Forms.Padding(4);
            this.signed.Name = "signed";
            this.signed.Size = new System.Drawing.Size(18, 17);
            this.signed.TabIndex = 14;
            this.signed.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 332);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Delivery note signed ?";
            // 
            // edit_invoice_cost
            // 
            this.edit_invoice_cost.Location = new System.Drawing.Point(171, 224);
            this.edit_invoice_cost.Margin = new System.Windows.Forms.Padding(4);
            this.edit_invoice_cost.Name = "edit_invoice_cost";
            this.edit_invoice_cost.Size = new System.Drawing.Size(212, 22);
            this.edit_invoice_cost.TabIndex = 16;
            this.edit_invoice_cost.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Invoice cost";
            // 
            // CB_Product
            // 
            this.CB_Product.FormattingEnabled = true;
            this.CB_Product.Location = new System.Drawing.Point(171, 256);
            this.CB_Product.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Product.Name = "CB_Product";
            this.CB_Product.Size = new System.Drawing.Size(212, 24);
            this.CB_Product.Sorted = true;
            this.CB_Product.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // del_note_path
            // 
            this.del_note_path.Location = new System.Drawing.Point(171, 289);
            this.del_note_path.Margin = new System.Windows.Forms.Padding(4);
            this.del_note_path.Name = "del_note_path";
            this.del_note_path.Size = new System.Drawing.Size(212, 22);
            this.del_note_path.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 298);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Delivery note location";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 289);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 25);
            this.button2.TabIndex = 23;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.RBUSD);
            this.groupBox1.Controls.Add(this.RBZAR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CB_Ref);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.del_note_path);
            this.groupBox1.Controls.Add(this.CB_Customer);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.edit_order_number);
            this.groupBox1.Controls.Add(this.CB_Product);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.order_date);
            this.groupBox1.Controls.Add(this.edit_invoice_cost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.del_date);
            this.groupBox1.Controls.Add(this.signed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edit_invoice_value);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(548, 417);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture Transaction";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(296, 370);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 28);
            this.button7.TabIndex = 28;
            this.button7.Text = "Update transaction";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // RBUSD
            // 
            this.RBUSD.AutoSize = true;
            this.RBUSD.Location = new System.Drawing.Point(457, 198);
            this.RBUSD.Margin = new System.Windows.Forms.Padding(4);
            this.RBUSD.Name = "RBUSD";
            this.RBUSD.Size = new System.Drawing.Size(58, 21);
            this.RBUSD.TabIndex = 27;
            this.RBUSD.TabStop = true;
            this.RBUSD.Text = "USD";
            this.RBUSD.UseVisualStyleBackColor = true;
            // 
            // RBZAR
            // 
            this.RBZAR.AutoSize = true;
            this.RBZAR.Location = new System.Drawing.Point(392, 198);
            this.RBZAR.Margin = new System.Windows.Forms.Padding(4);
            this.RBZAR.Name = "RBZAR";
            this.RBZAR.Size = new System.Drawing.Size(57, 21);
            this.RBZAR.TabIndex = 26;
            this.RBZAR.TabStop = true;
            this.RBZAR.Text = "ZAR";
            this.RBZAR.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Yellow;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(572, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(496, 185);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clients";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 142);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(480, 28);
            this.button4.TabIndex = 26;
            this.button4.Text = "Delete customer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 108);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(364, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Customer name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 73);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(480, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Save customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Customer name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 22);
            this.textBox1.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Yellow;
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(572, 207);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(496, 225);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 145);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(480, 28);
            this.button6.TabIndex = 29;
            this.button6.Text = "Delete product";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 112);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(364, 24);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 73);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(480, 28);
            this.button5.TabIndex = 27;
            this.button5.Text = "Save product";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 122);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Product name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Product name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 31);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 22);
            this.textBox2.TabIndex = 29;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox4.Location = new System.Drawing.Point(16, 439);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1052, 350);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1077, 804);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Ref;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edit_order_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker order_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker del_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edit_invoice_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox signed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edit_invoice_cost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_Product;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox del_note_path;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RBUSD;
        private System.Windows.Forms.RadioButton RBZAR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
    }
}

