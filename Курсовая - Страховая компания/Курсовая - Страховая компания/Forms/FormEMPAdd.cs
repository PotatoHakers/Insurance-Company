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

namespace InsuranceCompany
{

    public partial class FormEMPAdd : Form
    {
        //Объявление класса для подключения к базе данных
        Database dataBase = new Database();

        public FormEMPAdd()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Возврат на предыдущую форму
            FormEmployees formEmployees = new FormEmployees();
            formEmployees.Show();
            this.Hide();
        }

        private void FormEMPAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Кнопка для создания нового сотрудника
            dataBase.OpenConnection();
            //Объвление переменных для получения данных из полей
            var FIO = textBoxFIO.Text;
            var Position = textBoxPosition.Text;
            var Phone = textBoxPhone.Text;
            //Проверка на заполнение всех полей или выводит окно с ошибкой
            if (FIO == "" || Position == "" || Phone == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO TableYpr (FIO, Position, Phone) VALUES (@FIO, @Position, @Phone)", dataBase.GetConnection());
                command.Parameters.AddWithValue("@FIO", FIO);
                command.Parameters.AddWithValue("@Position", Position);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.ExecuteNonQuery();
                MessageBox.Show("Сотрудник добавлен!");
                dataBase.CloseConnection();
                ClearFields();
                
            }
            
        }

        private void ClearFields()
        {
            //метод очистки textBox-ов после заполнения
            textBoxId.Text = "";
            textBoxFIO.Text = "";
            textBoxPhone.Text = "";
            textBoxPosition.Text = "";
            
        }

    }
}
