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
    public partial class FormRegistration : Form
    {
        Database db = new Database();        
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuthorization Form1 = new FormAuthorization();
            Form1.Show();
            this.Hide();
        }

        private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            

            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            String querystring = $"insert into register (login_user, password_user ) values ('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
                FormAuthorization Fomr1 = new FormAuthorization();
                Fomr1.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Ошибка при регистрации!");
            }
            db.CloseConnection();
        }


        private Boolean checkurser()
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"Select id_user, login_user , passrod_user from registration where login_user = '{login}' and password_user = '{password}'";

            SqlCommand command = new SqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
               MessageBox.Show("Пользователь уже зарегестрирован");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
