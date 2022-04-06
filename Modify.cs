using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program9
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personDataSet);
            MessageBox.Show("Entry saved.");
            this.Close();

        }

        private void Modify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.personDataSet.Person);

        }


        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void streetLabel_Click(object sender, EventArgs e)
        {

        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stateLabel_Click(object sender, EventArgs e)
        {

        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipcodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void zipcodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
