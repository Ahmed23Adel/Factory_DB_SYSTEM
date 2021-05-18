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
    public partial class Add_production_line : Form
    {
        public Add_production_line()
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

            //Location can contain numbers and letters, so no constraints.
            //id can contain non numbers but can't be null
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

        private void location_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();
        }

        private void Add_production_line_Load(object sender, EventArgs e)
        {
            highlightNotValid();

        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            highlightNotValid();

        }
    }
}
