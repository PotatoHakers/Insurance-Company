using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Class
{
    public class FizClient : Person
    {
        public string Name { get; set; }
        public int ClientId { get; set; }
        public string Address { get; set; }
        public string SeriaPassport { get; set; }
        public int NumberPassport { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }
        public string Property { get; set; }
        public int Price { get; set; }

        public FizClient(string name, int clientId, string address, string seriaPassport, int numberPassport, string phone, string birthday, string property, int price) : base (name)
        {
            Name = name;
            ClientId = clientId;
            Address = address;
            SeriaPassport = seriaPassport;
            NumberPassport = numberPassport;
            Phone = phone;
            Birthday = birthday;
            Property = property;
            Price = price;
        }

        enum RowState
        {
            Existed,
            New,
            Modifield,
            ModifieldNew,
            Deleted
        }

        Database dataBase = new Database();

        public void CreateColumn(DataGridView dgv)
        {
            dgv.Columns.Add("Id", "ID");
            dgv.Columns.Add("FIO", "ФИО");
            dgv.Columns.Add("Address", "Адрес");
            dgv.Columns.Add("SeriaPassport", "Серия паспорта");
            dgv.Columns.Add("NumberPassport", "Номер паспорта");
            dgv.Columns.Add("Phone", "Телефон");
            dgv.Columns.Add("Birthday", "Дата рождения");
            dgv.Columns.Add("Property", "Имущество");
            dgv.Columns.Add("Price", "Стоимость");
            dgv.Columns.Add("IsNew", String.Empty);
            
        }

        public void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetInt32(8), RowState.ModifieldNew);
        }

        public void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"select * from TableClient";
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
            string queryString = $"select * from TableClient where concat (id, FIO, Address, SeriaPassport, NumberPassport, Phone, Birthday, Property, Price)like '%{textBox.Text}%'";

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
            string queryString = $"delete from TableClient where id = {textBox.Text}";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            command.ExecuteNonQuery();
        }
        
        public new void Update(DataGridView dgv)
        {
            dataBase.OpenConnection();
            for (int index = 0; index < dgv.Rows.Count; index++)
            {
                var rowState = (RowState)dgv.Rows[index].Cells[9].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dgv.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from TableClient where Id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modifield)
                {
                    var id = dgv.Rows[index].Cells[0].Value.ToString();
                    var fio = dgv.Rows[index].Cells[1].Value.ToString();
                    var address = dgv.Rows[index].Cells[2].Value.ToString();
                    var seriaPass = dgv.Rows[index].Cells[3].Value.ToString();
                    var numberPass = dgv.Rows[index].Cells[4].Value.ToString();
                    var phone = dgv.Rows[index].Cells[5].Value.ToString();
                    var birthday = dgv.Rows[index].Cells[6].Value.ToString();
                    var property = dgv.Rows[index].Cells[7].Value.ToString();
                    var price = dgv.Rows[index].Cells[8].Value.ToString();

                    var ChangeQuery = $"update TableClient set FIO = '{fio}', Address = '{address}', SeriaPassport = '{seriaPass}', NumberPassport = '{numberPass}', Phone = '{phone}', Birthday = '{birthday}', Property = '{property}', Price = '{price}' where Id = {id}";

                    var command = new SqlCommand(ChangeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.CloseConnection();
        }

        public void Change(TextBox textBoxFIO, TextBox textBoxAddress, TextBox textBoxSeriaPass, TextBox textBoxNumberPass, TextBox textBoxPhone, TextBox textBoxBirthday, TextBox textBoxProperty, TextBox textBoxPrice, TextBox textBoxId)  
        {
            string queryString = $"update TableClient set FIO = '{textBoxFIO.Text}', Address = '{textBoxAddress.Text}', SeriaPassport = '{textBoxSeriaPass.Text}', NumberPassport = '{textBoxNumberPass.Text}', Phone = '{textBoxPhone.Text}', Birthday = '{textBoxBirthday.Text}', Property = '{textBoxProperty.Text}', Price = '{textBoxPrice.Text}' where Id = {textBoxId.Text}";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            command.ExecuteNonQuery();

        }

    }
}
