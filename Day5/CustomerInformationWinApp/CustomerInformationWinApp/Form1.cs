using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInformationWinApp
{
    public partial class CustomerForm : Form
    {
        List<string> userNames = new List<string>();
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<int> contactNos = new List<int>();
        List<string> emails = new List<string>();
        List<string> addresss = new List<string>();
        List<int> accountNos = new List<int>();
        List<int> balances = new List<int>();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userName;
                string firstName;
                string lastName;
                int contactNo;
                string email;
                string address;
                int accountNo;

                userName = userNameTextBox.Text;

                if(String.IsNullOrEmpty(userName))
                {
                    MessageBox.Show ("Please Enter a User Name");
                    return;
                }

                userNamelabel.Text = "";
                if(IsUserDuplicateExists(userName))
                {
                    userNamelabel.Text = "Duplicate User Name Found";
                    return;
                }
                
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;

                if(System.Text.RegularExpressions.Regex.IsMatch(contactNoTextBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("please enter only numbers");
                    return;
                }

                if (contactNoTextBox.TextLength != 11)
                {
                    MessageBox.Show("Enter 11 digit numeric number");
                    return;
                }

              

                if (String.IsNullOrEmpty(contactNoTextBox.Text))
                {
                    MessageBox.Show("Please Enter a Contact No");
                    return;
                }

                contactNo = Convert.ToInt32(contactNoTextBox.Text);
                contactNoLabel.Text = "";

                if (IsContactNoDuplicateExists(contactNo))
                {
                    contactNoLabel.Text = "Duplicate Contact No Found";
                    return;
                }

                email = emailTextBox.Text;
                
                if (String.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please Enter a Email");
                    return;
                }

                if(!email.Contains("@"))
                {
                    MessageBox.Show("Please Enter Email That Contains @");
                    return;
                }

                emailLabel.Text = "";
                if (IsEmailDuplicateExists(email))
                {
                    emailLabel.Text = "Duplicate Email Found";
                    return;
                }

                address = addressTextBox.Text;

                accountNo = Convert.ToInt32(accountNoTextBox.Text);

                if (String.IsNullOrEmpty(accountNoTextBox.Text))
                {
                    MessageBox.Show("Please Enter a Account No");
                    return;
                }

                accountNoLabel.Text = "";

                if (IsAccountNoExists(accountNo))
                {
                    accountNoLabel.Text = "Duplicate Account No Found";
                    return;
                }

                if(accountNoTextBox.TextLength!=9)
                {
                    MessageBox.Show("Please Enter 9 Digit Account No");
                    return;
                }







                userNames.Add(userName);
                firstNames.Add(firstName);
                lastNames.Add(lastName);
                contactNos.Add(contactNo);
                emails.Add(email);
                addresss.Add(address);
                accountNos.Add(accountNo);
                balances.Add(0);

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Text = Display();
        }

        private string Display()
        {
            string message = "";
            message = "SI\t| User Name\t| First Name\t| Last Name\t| Contact No\t| Email\t| Address\t| Account No\n";

            for(int index=0;index<userNames.Count;index++)
            {
                message = message + (index + 1) + "\t" + userNames[index] + "\t" + firstNames[index] + "\t" + lastNames[index] + "\t" + contactNos[index] + "\t" + emails[index] +"\t"+ addresss[index] + "\t" + accountNos[index]+"\n";

             
            }
            return message;
        }

        private bool IsUserDuplicateExists(string userName)
        {
            bool isExist = false;
            foreach(string checkUserName in userNames)
            {
                if (checkUserName == userName)
                {
                    isExist = true;
                }
                    
            }
            return isExist;

        }

        private bool IsContactNoDuplicateExists(int contactNo)
        {
            bool isExist = false;
            foreach(int checkContactNo in contactNos)
            {
                if (checkContactNo==contactNo)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        private bool IsEmailDuplicateExists(string email)
        {
            bool isExist = false;
            foreach(string checkEmail in emails)
            {
                if(checkEmail==email)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        private bool IsAccountNoExists(int accountNo)
        {
            bool isExist = false;

            foreach( int checkAccountNo in accountNos)
            {
                if(checkAccountNo==accountNo)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void DepositeButton_Click(object sender, EventArgs e)
        {
            int amount;
            int index;
            index = IsValidAccountNumber();
            if (index < 0)
            {
                if (index == -1)
                {
                    MessageBox.Show("Account No. is not valid, Enter a correct Account");
                    return;
                }
                else
                {
                    return;
                }

            }
            else
            {
                amount = Convert.ToInt32(amountTextBox.Text);
                balances[index] += amount;
            }

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int amount;
            int index;
            index = IsValidAccountNumber();
            if (index < 0)
            {
                if (index == -1)
                {
                    MessageBox.Show("Account No. is not valid, Enter a correct Account");
                    return;
                }
                else
                {
                    return;
                }

            }
            else
            {
                amount = Convert.ToInt32(amountTextBox.Text);
                balances[index] -= amount;
            }
        }
        private int IsValidAccountNumber()
        {
            int accountNumber;
            int index;
            if (String.IsNullOrEmpty(accountNumberTextBox.Text))
            {
                MessageBox.Show("Enter Account Number!");
                return -2;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(accountNumberTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numeric Account Number.");
                return -2;
            }
            accountNumber = Convert.ToInt32(accountNumberTextBox.Text);
            index = AccountNumberToIndex(accountNumber);
            return index;
        }
        private int AccountNumberToIndex(int accountNumber)
        {

            for (int index = 0; index < accountNos.Count; index++)
            {
                if (accountNos[index] == accountNumber)
                {
                    return index;
                }
            }
            return -1;

        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {
            int index;
            index = IsValidAccountNumber();
            if (index < 0)
            {
                if (index == -1)
                {
                    MessageBox.Show("Account No. is not valid, Enter a correct Account");
                    return;
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Balance is: " + balances[index]);
            }
        }
    }
}
