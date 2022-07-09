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
using Курсовая___Страховая_компания;


namespace InsuranceCompany
{
    public partial class AddformFiz : Form
    {
        readonly Database database = new Database();
        

        public AddformFiz()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Открыть соединение с базой данных
            database.OpenConnection();
            //Объувдение полей для ввода данных
            var FIO = textBoxFIO.Text;
            var Address = textBoxAddress.Text;
            var SeriaPassport = textBoxSeriaPass.Text;
            var NumberPassport = textBoxNumPass.Text;
            var Phone = textBoxPhone.Text;
            var Birthday = textBoxBirthday.Text;
            var Property = textBoxProperty.Text;
            int Price;
            //условие для проверки ввода данных
            //Если не все поля заполнены, то появляет окно с ошибкой
            if (FIO == "" || Address == "" || Phone == "" || SeriaPassport =="" || NumberPassport =="" || Birthday =="" || Property =="")
            {
                MessageBox.Show("Заполните все поля!");
            }
            //Если все поля заполнены и поле Price введено в целом, числовом формате, то создается клиент
            else if (int.TryParse(textBoxPrice.Text, out Price))
            {
                var addQuery = "INSERT INTO TableClient (FIO, Address, SeriaPassport, NumberPassport, Phone, Birthday, Property, Price) VALUES ('" + FIO + "', '" + Address + "', '" + SeriaPassport + "', '" + NumberPassport + "', '" + Phone + "', '" + Birthday + "', '" + Property + "', '" + Price + "')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Клиент добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            //Если нет то окно с ошибкой
            else
            {
                MessageBox.Show("Неверный формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Закрываем соединение с базой данных
            database.CloseConnection();
            
        }
        //При закрытии формы, приложение закрывается
        private void Addform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Кнопка выхода из приложения
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Переход на предыдущую форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormClientFiz formWithDateBase = new FormClientFiz();
            formWithDateBase.Show();
            this.Hide();
            ClearFields();
            
        }
        //Метод для очистки полей ввода
        private void ClearFields()
        {
            textBoxId.Text = "";
            textBoxFIO.Text = "";
            textBoxAddress.Text = "";
            textBoxSeriaPass.Text = "";
            textBoxNumPass.Text = "";
            textBoxPhone.Text = "";
            textBoxBirthday.Text = "";
            textBoxProperty.Text = "";
            textBoxPrice.Text = "";
        }
    }
}
