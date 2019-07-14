using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopListApp
{
    public partial class DemoForm : Form
    {
        List<string> name = new List<string>();
        List<string> contact = new List<string>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();
        List<int> quantity = new List<int>();
        List<int> totalPrice = new List<int>();

        public DemoForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            name.Add(nameTextBox.Text);
            contact.Add(contactTextBox.Text);
            address.Add(addressTextBox.Text);
            order.Add(orderComboBox.Text);
            quantity.Add(Convert.ToInt32(quantityTextBox.Text));


            int price = 0;

            if (order[order.Count - 1].Equals("Math"))
            {
                price = 120;
            }

            else if (order[order.Count - 1].Equals("English"))
            {
                price = 100;
            }

            else if (order[order.Count - 1].Equals("Bangla"))
            {
                price = 90;
            }

            else if (order[order.Count - 1].Equals("Art"))
            {
                price = 80;
            }
            totalPrice.Add(price * quantity[quantity.Count - 1]);

            string message = "";
            for (int index = 0; index < name.Count; index++)
            {
                message += "Customer No: " + (index + 1) + "\n";
                message += "Customer Name: " + name[index] + "\n";
                message += "Contact No. : " + contact[index] + "\n";
                message += "Address: " + address[index] + "\n";
                message += "Order: " + order[index] + "\n";
                message += "No of Quantity : " + Convert.ToString(quantity[index]) + "\n";
                message += "Total Price is : " + Convert.ToString(totalPrice[index]) + "\n\n";

            }
            showRichTextBox.Text = message;

        }
    }
}
