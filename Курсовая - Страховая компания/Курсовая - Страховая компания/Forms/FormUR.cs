using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая___Страховая_компания;
using System.Data.SqlClient;
using InsuranceCompany.Class;


namespace InsuranceCompany
{

    public partial class FormUR : Form
    {
        UrClient urClient = new UrClient("", 0, "", 0, 0, 0, "", 0, 0);
        int selectedRow;

        public FormUR()
        {
            InitializeComponent();
        }

        private void FormUR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            InsuranceCompanyMenu insuranceCompanyMenu = new InsuranceCompanyMenu();
            insuranceCompanyMenu.Show();
            this.Hide();
        }

        private void FormUR_Load(object sender, EventArgs e)
        {
            urClient.CreateColumn(dataGridView1);
            this.dataGridView1.Columns["IsNew"].Visible = false;
            urClient.RefreshDataGrid(dataGridView1);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxINN.Text = row.Cells[2].Value.ToString();
                textBoxActivity.Text = row.Cells[3].Value.ToString();
                textBoxLicenseNumber.Text = row.Cells[4].Value.ToString();
                textBoxSertifSeries.Text = row.Cells[5].Value.ToString();
                textBoxCertifNumber.Text = row.Cells[6].Value.ToString();
                textBoxDate.Text = row.Cells[7].Value.ToString();
                textBoxCapital.Text = row.Cells[8].Value.ToString();

            }
        }
        
        private void ClearFields()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxINN.Text = "";
            textBoxActivity.Text = "";
            textBoxLicenseNumber.Text = "";
            textBoxSertifSeries.Text = "";
            textBoxCertifNumber.Text = "";
            textBoxDate.Text = "";
            textBoxCapital.Text = "";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddClientUR addClientUR = new AddClientUR();
            addClientUR.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            urClient.deleteRow(textBoxId);
            ClearFields();
            urClient.RefreshDataGrid(dataGridView1);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            urClient.Change(textBoxName, textBoxINN, textBoxActivity, textBoxLicenseNumber, textBoxSertifSeries, textBoxCertifNumber, textBoxDate, textBoxCapital, textBoxId);
            ClearFields();
            urClient.RefreshDataGrid(dataGridView1);
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            urClient.Search(textBoxSearch, dataGridView1);
        }

    }
}
