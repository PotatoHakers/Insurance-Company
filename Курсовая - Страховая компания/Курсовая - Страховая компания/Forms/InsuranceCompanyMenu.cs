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

namespace Курсовая___Страховая_компания
{
    public partial class InsuranceCompanyMenu : Form
    {


        public InsuranceCompanyMenu()
        {

            InitializeComponent();
            //Определение таймера для постоянного обновления lable времени
            timer.Tick += new EventHandler(RefreshLabel);
            timer.Interval = 1000;
            timer.Start();
            

        }
        //Создание переменной для хранения времени с типом timer
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        

        private void buttonExitForm2_Click(object sender, EventArgs e)
        {
            //Выохд из приложения по нажатию на красный крестик
            Application.Exit();
        }

        private void InsuranceCompanyMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Выход из приложения по закрытию формы
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Выход из приложения по нажатию на кнопку
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Возвращение на главную форму
            FormAuthorization Form1 = new FormAuthorization();
            Form1.Show();
            this.Hide();

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            //Переход на форму информации о компании
            InfoForm infoForm = new InfoForm();
            infoForm.Show();
            this.Hide();
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            //Переход на форму сотрудников
            FormEmployees formEmployees = new FormEmployees();
            formEmployees.Show();
            this.Hide();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            //Переход на форму оплаты
            Pay payForm = new Pay();
            payForm.Show();
            this.Hide();
        }
        public void RefreshLabel(object sender, EventArgs e)
        {
            //Обновление времени на форме
            labelTime.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void buttonClientsFL_Click(object sender, EventArgs e)
        {

            //Переход на форму клиентов
            FormClientFiz formWithDateBase = new FormClientFiz();
            formWithDateBase.Show();
            this.Hide();
        }

        private void buttonUL_Click(object sender, EventArgs e)
        {
            FormUR formUr = new FormUR();
            formUr.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormContract formDogovor = new FormContract();
            formDogovor.Show();
            this.Hide();
        }
    }
}

