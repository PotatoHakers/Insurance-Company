using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using InsuranceCompany.Class;
using InsuranceCompany;

namespace Курсовая___Страховая_компания
{
    
    public partial class FormClientFiz : Form
    {
        FizClient fizClient = new FizClient("", 0, "", "", 0, "", "", "", 0);
        int selectedRow;

        public FormClientFiz()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormWithDateBase_Load(object sender, EventArgs e)
        {
            fizClient.CreateColumn(dataGridView1);
            this.dataGridView1.Columns["IsNew"].Visible = false;
            fizClient.RefreshDataGrid(dataGridView1);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxFIO.Text = row.Cells[1].Value.ToString();
                textBoxAddress.Text = row.Cells[2].Value.ToString();
                textBoxSeriaPass.Text = row.Cells[3].Value.ToString();
                textBoxNumberPass.Text = row.Cells[4].Value.ToString();
                textBoxPhone.Text = row.Cells[5].Value.ToString();
                textBoxBirthday.Text = row.Cells[6].Value.ToString();
                textBoxProperty.Text = row.Cells[7].Value.ToString();
                textBoxPrice.Text = row.Cells[8].Value.ToString();
            }
        }

        
       
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            fizClient.Search(textBoxSearch, dataGridView1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            InsuranceCompanyMenu insuranceCompanyMenu = new InsuranceCompanyMenu();
            insuranceCompanyMenu.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddformFiz addform = new AddformFiz();
            addform.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            fizClient.deleteRow(textBoxId);
            ClearFields();
            fizClient.RefreshDataGrid(dataGridView1);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            fizClient.Change(textBoxFIO, textBoxAddress, textBoxSeriaPass, textBoxNumberPass, textBoxPhone, textBoxBirthday, textBoxProperty, textBoxPrice, textBoxId);
            ClearFields();
            fizClient.RefreshDataGrid(dataGridView1);
        }

        private void FormWithDateBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClearFields()
        {
            textBoxId.Text = "";
            textBoxFIO.Text = "";
            textBoxAddress.Text = "";
            textBoxSeriaPass.Text = "";
            textBoxNumberPass.Text = "";
            textBoxPhone.Text = "";
            textBoxBirthday.Text = "";
            textBoxProperty.Text = "";
            textBoxPrice.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            fizClient.RefreshDataGrid(dataGridView1);
        }
    }
}
