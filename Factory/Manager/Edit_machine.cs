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
    public partial class Edit_machine : Form
    {
        public Edit_machine()
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
            //ID of mahice could be letter and numbers 
            //so as name, so i didn't put any constraints
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
            ifCondTVisible(string.IsNullOrEmpty(id.Text), idunderline);

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();
        }
    }
}
