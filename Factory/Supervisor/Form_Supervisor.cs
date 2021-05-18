using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form_Supervisor : Form
    {
        public Form_Supervisor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form_Supervisor_Load(object sender, EventArgs e)
        {

        }

        private void ViewWorkersRecordButton_Click(object sender, EventArgs e)
        {
            new Sup_ViewWorkersRecord().Show();
        }
    }
}
