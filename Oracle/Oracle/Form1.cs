using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Documents;

namespace Oracle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("Customers.txt"))
            {
                sw.WriteLine(customer_name_textbox.Text + "\t" +
                             customer_contact_person_textbox.Text + "\t" +
                             customer_office_phone_textbox.Text + "\t" +
                             customer_cell_phone_textbox.Text + "\t" +
                             customer_email_address_textbox.Text + "\t" +
                             customer_physical_address_textbox.Text);               
            }
            CB_Customer.Items.Clear();
            comboBox1.Items.Clear();

            string[] lines = File.ReadAllLines("Customers.txt");

            foreach (string line in lines)
            {
                string sep = "\t";                                            //HW
                string[] splitContent = line.Split(sep.ToCharArray());       //Ha

                CB_Customer.Items.Add(splitContent[0]);
                comboBox1.Items.Add(splitContent[0]);
            }

            //customer_name_textbox.Text = "";
            MessageBox.Show("Customer saved.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CB_Customer.Items.Clear();
            comboBox1.Items.Clear();

            string[] lines1 = File.ReadAllLines("Customers.txt");

            foreach (string line in lines1)
            {
                string sep = "\t";                                            //HW
                string[] splitContent = line.Split(sep.ToCharArray());       //Ha
                if (line != " ")
                {
                    CB_Customer.Items.Add(splitContent[0]);
                    comboBox1.Items.Add(splitContent[0]);
                }
            }


            CB_Product.Items.Clear();
            comboBox2.Items.Clear();

            string[] lines2 = File.ReadAllLines("Product.txt");

            foreach (string line in lines2)
            {
                if (line != " ")
                {
                    CB_Product.Items.Add(line);
                    comboBox2.Items.Add(line);
                }
            }

            string[] lines3 = File.ReadAllLines("MainDB.txt");

            foreach (string lineDB in lines3)
            {
                string[] info = lineDB.Split(new char[]{'\t'});
                if (info[0] != "")
                {
                    CB_Ref.Items.Add(info[0]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("Product.txt"))
            {
                sw.WriteLine(textBox2.Text);
            }
            CB_Product.Items.Clear();
            comboBox2.Items.Clear();

            string[] lines = File.ReadAllLines("Product.txt");

            foreach (string line in lines)
            {
                CB_Product.Items.Add(line);
                comboBox2.Items.Add(line);
            }

            textBox2.Text = "";
            MessageBox.Show("Product saved.");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        string cur = "";
        string sign = "";

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("MainDB.txt"))
            {
                if (RBZAR.Checked) { cur = "ZAR"; } else { cur = "USD"; }
                if (signed.Checked) { sign = "Yes"; } else { sign = "NO"; }
                sw.WriteLine(CB_Ref.Text + "\t" + 
                             CB_Customer.Text +"\t"+ 
                             edit_order_number.Text +"\t"+
                             order_date.Text.ToString()+"\t"+
                             del_date.Text.ToString()+"\t"+
                             edit_invoice_value.Text+"\t"+
                             edit_invoice_cost.Text+"\t"+
                             CB_Product.Text+"\t"+
                             del_note_path.Text+"\t"+
                             cur+"\t"+
                             sign);
            }
            MessageBox.Show("Transaction captured");

            string[] lines3 = File.ReadAllLines("MainDB.txt");
            CB_Ref.Items.Clear();

            foreach (string lineDB in lines3)
            {
                string[] info = lineDB.Split(new char[] { '\t' });
                if (info[0] != "")
                {
                    CB_Ref.Items.Add(info[0]);
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e, string fileName, string word, string replacement, string saveFileName)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sSelectedFile;

            OpenFileDialog findfile = new OpenFileDialog();
            findfile.Filter = "All Files (*.*)|*.*";
            findfile.FilterIndex = 1;
            findfile.Multiselect = false;

            if (findfile.ShowDialog() == DialogResult.OK)
                sSelectedFile = findfile.FileName;
            else
                sSelectedFile = string.Empty;

            del_note_path.Text = sSelectedFile;
        }
        int pointer = 0;
        int counter = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("Customers.txt");
            
            foreach (string entry in lines)
                {
                    if (entry == comboBox1.Text)
                    {
                        pointer = counter;
                    }
                    counter++;
                }
            lines[pointer] = " ";
            File.WriteAllLines("Customers.txt", lines);
            MessageBox.Show("Customer deleted");

            CB_Customer.Items.Clear();
            comboBox1.Items.Clear();
            

            string[] lines2 = File.ReadAllLines("Customers.txt");

            foreach (string line in lines2)
            {
                if (line != " ")
                {
                    CB_Customer.Items.Add(line);
                    comboBox1.Items.Add(line);
                }
            }
            comboBox1.Text = "";
            CB_Customer.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("Product.txt");

            foreach (string entry in lines)
            {
                if (entry == comboBox2.Text)
                {
                    pointer = counter;
                }
                counter++;
            }
            lines[pointer] = " ";
            File.WriteAllLines("Product.txt", lines);
            MessageBox.Show("Product deleted");

            CB_Product.Items.Clear();
            comboBox2.Items.Clear();


            string[] lines2 = File.ReadAllLines("Product.txt");

            foreach (string line in lines2)
            {
                if (line != " ")
                {
                    CB_Product.Items.Add(line);
                    comboBox2.Items.Add(line);
                }
            }
            comboBox2.Text = "";
            CB_Product.Text = "";
        }

        int Update_Trans_Pointer = 0;                                                //HW
        int Update_Trans_Counter = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            var mainlines = File.ReadAllLines("MainDB.txt");

            foreach (string entry in mainlines)
            {
                string sep = "\t";                                            //HW
                string[] splitContent = entry.Split(sep.ToCharArray());       //Ha

                if (splitContent[0] == CB_Ref.Text)
                {
                    Update_Trans_Pointer = Update_Trans_Counter;
                    break;
                }
                Update_Trans_Counter++;
            }
            if (RBZAR.Checked) { cur = "ZAR"; } else { cur = "USD"; }
            if (signed.Checked) { sign = "Yes"; } else { sign = "NO"; }

            mainlines[Update_Trans_Pointer] = CB_Ref.Text + "\t" +
                             CB_Customer.Text + "\t" +
                             edit_order_number.Text + "\t" +
                             order_date.Text.ToString() + "\t" +
                             del_date.Text.ToString() + "\t" +
                             edit_invoice_value.Text + "\t" +
                             edit_invoice_cost.Text + "\t" +
                             CB_Product.Text + "\t" +
                             del_note_path.Text + "\t" +
                             cur + "\t" +
                             sign;
            File.WriteAllLines("MainDB.txt", mainlines);
            MessageBox.Show("Transaction Updated");

            //HW

            CB_Ref.Items.Clear();
            string[] lines3 = File.ReadAllLines("MainDB.txt");

            foreach (string lineDB in lines3)
            {
                string[] info = lineDB.Split(new char[] { '\t' });
                if (info[0] != "")
                {
                    CB_Ref.Items.Add(info[0]);
                }
            }
             Update_Trans_Pointer = 0;                                            
             Update_Trans_Counter = 0;
            //HW


        }

        private void CB_Ref_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = false;         //HW
            button7.Visible = true;          //HW
            string[] records = File.ReadAllLines("MainDB.txt");
            var customerRef = "";
            var customer = "";
            var customerOrder = "";
            var orderDate = "";
            var deliveryDate = "";
            var invoiceVal = "";
            var invoiceCost = "";
            var productSold = "";
            var deliveryNotePath = "";
            var currency = "";
            var deliveryNotesSigned = "";

            foreach (string entry in records)
            {
                string[] info = entry.Split(new char[] { '\t' });
                if (info[0] != "")
                {
                    customerRef = info[0];
                }

                customer = info[1];
                customerOrder = info[2];
                orderDate = info[3];
                deliveryDate = info[4];
                invoiceVal = info[5];
                invoiceCost = info[6];
                productSold = info[7];
                deliveryNotePath = info[8];
                currency = info[9];
                deliveryNotesSigned = info[10];

                if (customerRef == CB_Ref.Text)
                {
                    pointer = counter;
                    CB_Customer.Text = customer;
                    edit_order_number.Text = customerOrder;
                    order_date.Text = orderDate;
                    del_date.Text = deliveryDate;
                    edit_invoice_value.Text = invoiceVal;
                    edit_invoice_cost.Text = invoiceCost;
                    CB_Product.Text = productSold;
                    del_note_path.Text = deliveryNotePath;
                    
                    if (currency == "ZAR")
                     {
                        RBZAR.Checked = true;
                        RBUSD.Checked = false;
                     }
                     else
                     {
                        RBUSD.Checked = true;
                        RBZAR.Checked = false;
                     }

                     if (deliveryNotesSigned == "Yes")
                     {
                        signed.Checked = true;
                     }
                     else
                     {
                      
                            signed.Checked = false;
                        
                        
                     }
                    
                }
                counter++;
                
            }
            
        }

        private void CB_Product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //HW
            CB_Ref.Text = "";
            CB_Customer.Text = "";
            edit_order_number.Text = "";
            edit_invoice_value.Text = "0.00";
            edit_invoice_cost.Text = "0.00";
            CB_Product.Text = "";
            del_note_path.Text = "";
            RBZAR.Checked = false;
            RBUSD.Checked = false;
            signed.Checked = false;
            button1.Visible = true;
            button7.Visible = false;
            //HW
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Visible = false;
            button9.Visible = true;
            string[] lines1 = File.ReadAllLines("Customers.txt");

            

            foreach (string line in lines1)
            {
                string sep = "\t";                                            //HW
                string[] splitContent = line.Split(sep.ToCharArray());       //Ha

                if (splitContent[0] == comboBox1.Text)
                {
                    customer_name_textbox.Text = splitContent[0];
                    customer_contact_person_textbox.Text = splitContent[1];
                    customer_office_phone_textbox.Text = splitContent[2];
                    customer_cell_phone_textbox.Text = splitContent[3];
                    customer_email_address_textbox.Text = splitContent[4];
                    customer_physical_address_textbox.Text = splitContent[5];
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customer_name_textbox.Text = "";
            customer_contact_person_textbox.Text = "";
            customer_office_phone_textbox.Text = "";
            customer_cell_phone_textbox.Text = "";
            customer_email_address_textbox.Text = "";
            customer_physical_address_textbox.Text = "";
            button3.Visible = true;
            button9.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var mainlines = File.ReadAllLines("Customers.txt");

            foreach (string entry in mainlines)
            {
                string sep = "\t";                                            //HW
                string[] splitContent = entry.Split(sep.ToCharArray());       //Ha

                if (splitContent[0] == comboBox1.Text)
                {
                    Update_Trans_Pointer = Update_Trans_Counter;
                    break;
                }
                Update_Trans_Counter++;
            }
        

            mainlines[Update_Trans_Pointer] = customer_name_textbox.Text + "\t" +
                             customer_contact_person_textbox.Text + "\t" +
                             customer_office_phone_textbox.Text + "\t" +
                             customer_cell_phone_textbox.Text + "\t" +
                             customer_email_address_textbox.Text + "\t" +
                             customer_physical_address_textbox.Text;
            File.WriteAllLines("Customers.txt", mainlines);
            MessageBox.Show("Customer Updated");

            //HW
            CB_Customer.Items.Clear();
            comboBox1.Items.Clear();

            string[] lines1 = File.ReadAllLines("Customers.txt");

            foreach (string line in lines1)
            {
                string sep = "\t";                                            //HW
                string[] splitContent = line.Split(sep.ToCharArray());       //Ha
                if (line != " ")
                {
                    CB_Customer.Items.Add(splitContent[0]);
                    comboBox1.Items.Add(splitContent[0]);
                }
            }

            Update_Trans_Pointer = 0;
            Update_Trans_Counter = 0;
            //HW

        }
    }
}
