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


namespace InsuranceCompany
{
    public partial class AddClientUR : Form
    {
        //Вызов класса Database
        Database db = new Database();
        public AddClientUR()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Открываем подключение к базе данных
            db.OpenConnection();
            //Объвление переменных для создания столбцов в dgv          
            var Name = textBoxName.Text;
            var INN = textBoxINN.Text;
            var Activity = textBoxActivity.Text;
            var LicenseNumber = textBoxLicenseNumber.Text;
            var СertificateSeries = textBoxСertifSeries.Text;
            var CertificateNumber = textBoxCertificateNumber.Text;
            var Date = textBoxDate.Text;
            var AuthorizedCapital = textBoxCapital.Text;

            //Проверка на заполнение всех полей, для избежания ошибки
            try
            {
                if (Name == "" || INN == "" || Activity == "" || LicenseNumber == "" || СertificateSeries == "" || CertificateNumber == "" || Date == "" || AuthorizedCapital == "")
                {
                    MessageBox.Show("Заполните все поля!");
                }

                else
                {
                    var addQuery = "INSERT INTO ClientUR (Name, INN, Activity, LicenseNumber, СertificateSeries, CertificateNumber, Date, AuthorizedCapital) VALUES ('" + Name + "', '" + INN + "', '" + Activity + "','" + LicenseNumber + "', '" + СertificateSeries + "', '" + CertificateNumber + "', '" + Date + "', '" + AuthorizedCapital + "')";
                    var command = new SqlCommand(addQuery, db.GetConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Клиент добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.CloseConnection();
                    ClearFields();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
             
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Кнопка для закрытия приложения
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Кнопка возврата на предыдущую форму
            FormUR formUR = new FormUR();
            formUR.Show();
            this.Close();

        }

        private void ClearFields()
        {
            //Метод для очистки текст боксов
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxINN.Text = "";
            textBoxActivity.Text = "";
            textBoxLicenseNumber.Text = "";
            textBoxСertifSeries.Text = "";
            textBoxCertificateNumber.Text = "";
            textBoxDate.Text = "";
            textBoxCapital.Text = "";
        }
    }
}
