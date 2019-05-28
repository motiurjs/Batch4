using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopWinApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        const int size = 10;
        int count = 0;
        string[] name = new string[size];
        string[] contact = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        int[] totalPrice = new int[size];
        public Form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void Save_Click(object sender, EventArgs e)
        {

            int price=0;
            name[count] = NameTextBox.Text;
            contact[count] = ContactTextBox.Text;
            address[count] = AddressTextBox.Text;
            order[count] = OrderComboBox.Text;
            quantity[count] = Convert.ToInt32(QuantityTextBox.Text);
            
             

           

            if(order[count].Equals("Math"))
            {
                price = 120;
            }
            else if(order[count].Equals("English"))
            {
                price = 100;
            }
            else if(order[count].Equals("Bangla"))
            {
                price = 90;
            }
            else if (order[count].Equals("Art"))
            {
                price = 80;
            }

            totalPrice[count] = quantity[count] * price;

            count++;
            string message = "";
            for(int index=0;index<count;index++)
            {
                message += "Customer No: "+ (index + 1) + "\n";
                message += "Customer Name:" +name[index]+"\n";
                message += "Contact No:" +contact[index] + "\n";
                message += "Address:" +address[index] + "\n";
                message += "Order:" +order[index] + "\n";
                message += "Quantity:" +quantity[index] + "\n";
                message += "Total Price: " + totalPrice[index] + "\n\n";
            }
            showRichTextBox.Text = message;
        
            

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowRichTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
