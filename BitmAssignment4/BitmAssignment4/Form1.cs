using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmAssignment4
{
    public partial class Form1 : Form
    {    
        List<string> Names = new List<string> { };
        List<string> Contacts = new List<string> { };
        List<string> Addresses = new List<string> { };
        List<string> Orders = new List<string> { };
        List<int> Quantities = new List<int> { };
        int identify = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddCustomerInfo();
        }
        private void AddCustomerInfo()
        {
            try
            {
                if (customerNameTextBox.Text=="" || ContactNoTextBox.Text=="" || AddressTextBox.Text=="" || orderComboBox.Text=="" || quantityTextBox.Text=="" || orderComboBox.Text == "Select")
                {
                    if(customerNameTextBox.Text == "")
                    {
                        customerNameTextBox.Text = string.Empty;
                        MessageBox.Show("Customer Name Required");
                    }
                    else if(ContactNoTextBox.Text == "")
                    {
                        ContactNoTextBox.Text = string.Empty;
                        MessageBox.Show("Contact No Required");
                    }
                    else if(AddressTextBox.Text == "")
                    {
                        AddressTextBox.Text = string.Empty;
                        MessageBox.Show("Address Required");
                    }
                    else if(orderComboBox.Text == "" || orderComboBox.Text == "Select")
                    {
                        orderComboBox.Text = string.Empty;
                        MessageBox.Show("Select Your order Item");
                    }
                    else if(quantityTextBox.Text == "")
                    {
                        quantityTextBox.Text = string.Empty;
                        MessageBox.Show("Quantity Required");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Names.Add(customerNameTextBox.Text);
                    customerNameTextBox.Clear();
                    if (Contacts.Contains(ContactNoTextBox.Text) == true)
                    {
                        MessageBox.Show("This 'Contact No' have already used!");
                        return;
                    }
                    else
                    {
                        Contacts.Add(ContactNoTextBox.Text);
                        ContactNoTextBox.Clear();
                       
                    }
                   
                    Addresses.Add(AddressTextBox.Text);
                    AddressTextBox.Clear();
                    Orders.Add(orderComboBox.Text);
                    orderComboBox.Text = string.Empty;
                    Quantities.Add(Convert.ToInt32(quantityTextBox.Text));
                    quantityTextBox.Clear();
                    identify++;
                    ShowSingleCustomerInfo();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wrong Input");
                return;
            }
        }
        private void ShowSingleCustomerInfo()
        {
            try
            {
                string message = "";
                for (int i =0; i < Names.Count(); i++)
                {
                    if (i == identify - 1)
                    {
                        message += "Customer ID: "+identify+"\n"+"Customer Name: " + Names[i] + "\n" + "Contact No: " + Contacts[i] + "\n" + "Address: " + Addresses[i] + "\n" + "Order: " + Orders[i] + "\n" + "Quantity: " + Quantities[i] + "\n";
                    }
                }
                showDetailsRichTextBox.Text = message.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Single Show Wrong");
            }
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowAllCustomerInfo();
        }
        private void ShowAllCustomerInfo()
        {
            try
            {
                string message = "";
                for (int i = 0; i < Names.Count(); i++)
                {
                    message += "Customer ID: " + (i + 1) +"\n"+ "Customer Name: " + Names[i] + "\n" + "Contact No: " + Contacts[i] + "\n" + "Address: " + Addresses[i] + "\n" + "Order: " + Orders[i] + "\n" + "Quantity: " + Quantities[i] + "\n";

                }
                showDetailsRichTextBox.Text = message.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("All Show Wrong");
            }
        }
    }
}
