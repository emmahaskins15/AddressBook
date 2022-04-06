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
    public partial class frmAddressBook : Form
    {
        public frmAddressBook()
        {
            InitializeComponent();
        }

        private void frmAddressBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.personDataSet.Person);

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            // Ensure row is selected
            if (dataGridContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No contact selected.");
            }
            else
            {
                // Get primary key of selected row
                int intID = int.Parse(dataGridContacts.CurrentRow.Cells[0].Value.ToString());

                // Create instance of Modify form
                Modify details = new Modify(intID);

                // Display form
                details.ShowDialog();

                // Fill dataset
                this.personTableAdapter.Fill(this.personDataSet.Person);
            }
        }


        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            // Clear textBoxQuery and fill dataGridContacts
            textBoxQuery.Clear();
            this.personTableAdapter.Fill(this.personDataSet.Person);
        }

        private void textBoxQuery_TextChanged(object sender, EventArgs e)
        {
            // Fill dataGridContacts by text entered from textBoxQuery
            this.personTableAdapter.FillBySearch(this.personDataSet.Person, textBoxQuery.Text);
        }
    }
}
