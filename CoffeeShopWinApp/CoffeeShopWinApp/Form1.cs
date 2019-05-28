using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWinApp
{
    public partial class CoffeeShopForm : Form
    {
        const int size = 10;
        int count = 0;

        string[] name = new string[size];
        string[] contact = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        int[] totalPrice = new int[size];

        public CoffeeShopForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int price = 0;
            name[count] = nameTextBox.Text;
            contact[count] = contactTextBox.Text;
            address[count] = addressTextBox.Text;
            order[count] = orderComboBox.Text;
            quantity[count] = Convert.ToInt32(quantityTextBox.Text);

            if(order[count].Equals("Black"))
            {
                price = 120;
            }
            else if (order[count].Equals("Cold"))
            {
                price = 100;
            }
            else if (order[count].Equals("Hot"))
            {
                price = 90;
            }
            else if (order[count].Equals("Regular"))
            {
                price = 80;
            }

            totalPrice[count] = quantity[count]*price;
            count++;

            string message = "";
            for(int index=0;index<count;index++)
            {
                message += "Customer Information No:" + (index + 1) + "\n";
                message += "Customer Name: " + name[index] + "\n";
                message += "Contact No: " + contact[index] + "\n";
                message += "Address: " + address[index] + "\n";
                message += "Order: " + order[index] + "\n";
                message += "Quantity: " + quantity[index] + "\n";
                message += "Total Price: " + totalPrice[index] + "\n\n";


            }
            showRichTextBox.Text = message;

        }
    }
}
