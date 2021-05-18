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
    public partial class Add_product : Form
    {
        public Add_product()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                
            }
        }
        private bool isDataValid()
        {
            //name could contain letters and number so no constraint on it.

            if (!cost.Text.All(char.IsDigit))
            {
                MessageBox.Show("Cost is not valid, it might contains non numbers, please fix it and try again");
                return false;
            }
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Id is not valid, It's empty, please fix it and try again");
                return false;
            }

            return true;
        }
        public void ifCondTVisible(bool condition, Label label)
        {
            if (condition)
                label.Visible = true;
            else
                label.Visible = false;

        }

        private void highlightNotValid()
        {
            ifCondTVisible(!cost.Text.All(char.IsDigit) ,costunderline);
            ifCondTVisible(string.IsNullOrEmpty(id.Text), idunderline);

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();
        }

        private void cost_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();
        }
    }
}
