using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Class
{
    public class Employee : Person
    {
        //Вызов метода для работы с базой данных
        Database dataBase = new Database();


        public int EmployeeID { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }

        public Employee(int employeeID, string position, string name) : base (name)
        {
            EmployeeID = employeeID;
            Position = position;
            Name = name;
        }

        enum RowState
        {
            Existed,
            New,
            Modifield,
            ModifieldNew,
            Deleted
        }

        public void CreateColumn(DataGridView dgv)
        {
            //Метод создания столбцов в таблице, для того, чтобы в таблице коректно и на русском языке отображались названия полей
            dgv.Columns.Add("id", "ID");
            dgv.Columns.Add("FIO", "ФИО");
            dgv.Columns.Add("Position", "Должность");
            dgv.Columns.Add("Phone", "Телефон");
            dgv.Columns.Add("IsNew", String.Empty);

        }


        public void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            //Считывание одной строки с определенным типом данных из базы данных и заполнение таблицы
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifieldNew);
           
        }

        public void RefreshDataGrid(DataGridView dgv)
        {
            //Обновление таблицы при изменении данных в базе данных
            dgv.Rows.Clear();
            string queryString = $"select * from TableYpr";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        public void Search(TextBox textBox, DataGridView dgv)
        {
            //Поиск по базе данных по заданному запросу

            string queryString = $"select * from TableYpr where FIO like '%{textBox.Text}%'";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            dgv.Rows.Clear();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        public void deleteRow(TextBox textBox)
        {
            //Метод удаления строки из таблицы
            string queryString = $"delete from TableYpr where id = {textBox.Text}";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            command.ExecuteNonQuery();

            dataBase.CloseConnection();
        }


        public void Change(TextBox textBoxFIO, TextBox textBoxPosition, TextBox textBoxPhone, TextBox textBoxId)
        {
            //Метод изменения данных в таблице
            string queryString = $"update TableYpr set FIO = '{textBoxFIO.Text}', Position = '{textBoxPosition.Text}', Phone = '{textBoxPhone.Text}' where id = {textBoxId.Text}";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();
            
            command.ExecuteNonQuery();
            
            dataBase.CloseConnection();

        }

    }

}

