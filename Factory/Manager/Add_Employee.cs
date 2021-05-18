using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory.Manager
{
    public partial class Add_Employee : Form
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            { 
            }

        }

        private bool isDataValid()
        {
            if (!fname.Text.All(char.IsLetter))
            {
                MessageBox.Show("First name is not valid, it might contains non letters, please fix it and try again");
                return false;
            }
            if (!lname.Text.All(char.IsLetter))
            {
                MessageBox.Show("Last name is not valid, it might contains non letters, please fix it and try again");
                return false;
            }
            
            if (!salary.Text.All(char.IsDigit))
            {
                MessageBox.Show("Salary is not valid, it might contains non numbers, please fix it and try again");
                return false;
            }
            if (!id.Text.All(char.IsDigit))
            {
                MessageBox.Show("Id is not valid, it might contains non numbers, please fix it and try again");
                return false;
            }
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Id is not valid, It's empty, please fix it and try again");
                return false;
            }
            if (string.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("password is not valid, It's empty! , please fix it and try again");
                return false;
            }
            if (pass.Text.Length <8)
            {
                MessageBox.Show("password is not valid, it's less thatn 8 chars, please fix it and try again");
                return false;
            }
            return true;
        }

        public void  ifCondTVisible(bool condition,Label label)
        {
            if (condition)
                label.Visible = true;
            else
                label.Visible = false;

        }

        private void highlightNotValid()
        {
            ifCondTVisible(!fname.Text.All(char.IsLetter), fnameunderline);
            ifCondTVisible(!lname.Text.All(char.IsLetter), lnameunderline);
            ifCondTVisible(!salary.Text.All(char.IsDigit), salaryunderline);
            ifCondTVisible(!id.Text.All(char.IsDigit), idunderline);
            ifCondTVisible(string.IsNullOrEmpty(id.Text), idunderline);
            ifCondTVisible(string.IsNullOrEmpty(pass.Text), passunderline);
            ifCondTVisible(pass.Text.Length < 8, passunderline);



        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();

        }

        private void salary_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            highlightNotValid();

        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();

        }
    }
}
