using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InsuranceCompany
{
    //Класс для подключения базы данных к проекту
     class Database
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-MFCNCQ9\SQLEXPRESS; Initial Catalog = ВatabaseСoursework; Integrated Security = True");

        //метод для открытия подключения к базе данных
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        //метод для закрытия подключения к базе данных
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        //Возвращает значение sqlConnection
        public SqlConnection GetConnection() => sqlConnection;
    }
}
