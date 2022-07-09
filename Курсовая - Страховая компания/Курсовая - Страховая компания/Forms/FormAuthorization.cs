using InsuranceCompany;
using System.Data;
using System.Data.SqlClient;

    
namespace Курсовая___Страховая_компания
{
   
    public partial class FormAuthorization : Form
    {
        //Объявление класса для подключения к базе данных
        Database dataBase = new Database();
        public FormAuthorization()
        {
            InitializeComponent();
            //Условия для ввода данных в полях логина и пароля (максимально кол-во символов 50)
            textBoxLogin.MaxLength = 50;
            textBoxPassword.MaxLength = 50;

        }
        
        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            //если checkBox активен, то поле ввода пароля показывается
            if (checkBoxPassword.Checked)

            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            //если нет, то пароль скрыт
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //выход из прилодения по кнопке выход
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Объвление переменных для получения данных из полей логина и пароля
            var loginuser = textBoxLogin.Text;
            var passworduser = textBoxPassword.Text;
            //Обявлние переменных для получения данных из базы данных
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            //считывание информации из бд
            string sql = $"select id_user, login_user, password_user from register where login_user = '{loginuser}' and password_user = '{passworduser}'";
            SqlCommand command = new SqlCommand(sql, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            //Если в базе данных нет данных с таким логином и паролем, то выводится сообщение об ошибке
            if (table.Rows.Count == 1)
            {
               
                MessageBox.Show("Вы вошли в систему");
                InsuranceCompanyMenu insuranceCompanyMenu = new InsuranceCompanyMenu();
                insuranceCompanyMenu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //По нажанию кнопки появляется форма регистрации
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            this.Hide();
        }
    }
}