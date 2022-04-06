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
        int _id;
        public Modify(int id)
        {
            _id = id;
            InitializeComponent();
        }
        private void Modify_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'personDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.FillById(this.personDataSet.Person, _id);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate data
            if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a last name.");
                lastNameTextBox.Focus();
            }
            else if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a first name.");
                firstNameTextBox.Focus();
            }
            else
            {
                // Save changes; close form
                this.Validate();
                this.personBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.personDataSet);
                MessageBox.Show("Entry saved.");
                this.Close();
            }
        }
    }
}
