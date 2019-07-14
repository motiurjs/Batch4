using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account account;
        public AccountOperationUi()
        {
            InitializeComponent();
            account = new Account();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string accountNumber = accountNoTextBox.Text;
            string customerName = customerNameTextBox.Text;
            account.Create(accountNumber, customerName);
            accountNoTextBox.Text = "";
            customerNameTextBox.Text = "";
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountTextBox.Text);
            account.Deposite(amount);
            amountTextBox.Text = "";
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountTextBox.Text);
            account.Withdraw(amount);
            amountTextBox.Text = "";
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.GetReport());
        }
    }
}
