using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceCompany;
using System.Data.SqlClient;
using InsuranceCompany.Class;


namespace Курсовая___Страховая_компания
{
    public partial class FormEmployees : Form
    {
       
        int selectedRow;
        Employee employee = new Employee(1, null, null);
        
        public FormEmployees()
        {
            InitializeComponent();

        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            
            employee.CreateColumn(dataGridView2);
            this.dataGridView2.Columns["IsNew"].Visible = false;
            employee.RefreshDataGrid(dataGridView2);
            
        }


        private void FormEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Выход из приложения при закрытии формы
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Возвращения на предыдущую форму при нажатии кнопки
            InsuranceCompanyMenu InsuranceCompanyMenu = new InsuranceCompanyMenu();
            InsuranceCompanyMenu.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            employee.RefreshDataGrid(dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Свойство выделения строки в таблице при нажатии на нее
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxFIO.Text = row.Cells[1].Value.ToString();
                textBoxPosition.Text = row.Cells[2].Value.ToString();
                textBoxPhone.Text = row.Cells[3].Value.ToString();

            }
        }

        private void ClearFields()
        {
            //Метод очистки textBox-ов 
            textBoxId.Text = "";
            textBoxFIO.Text = "";
            textBoxPosition.Text = "";
            textBoxPhone.Text = "";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Форма для создания новых клиентов
            FormEMPAdd formEMPAdd = new FormEMPAdd();
            formEMPAdd.Show();
            this.Hide();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Объявления метода в конпке поиска по введенному значению
            employee.Search(textBoxSearch, dataGridView2);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Кнопка удаления выбранной строки из таблицы со свойствами обновления и очстки textBox-ов
            employee.deleteRow(textBoxId);
            employee.RefreshDataGrid(dataGridView2);
            ClearFields();
            

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //Кнопка для изменения данных в таблице со свойством автоматического обновления таблицы после нажатия на нее и очистки textBox-ов
            employee.Change(textBoxFIO, textBoxPosition, textBoxPhone, textBoxId);
            employee.RefreshDataGrid(dataGridView2);
            ClearFields();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            employee.RefreshDataGrid(dataGridView2);
        }
    }
}


