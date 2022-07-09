using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Class
{
   public class UrClient: Person
    {
        public string Name { get; set; }
        public int INN { get; set; }
        public string Activity { get; set; }
        public int LicenseNumber { get; set; }
        public int CertificateSeries { get; set; }
        public int CertificateNumber { get; set; }
        public string Date { get; set; }
        public int AutorizedCapital { get; set; }
        public int ClientId { get; set; }

        public UrClient(string name, int inn, string activity, int licenseNumber, int certificateSeries, int certificateNumber, string date, int autorizedCapital, int clientId) : base (name)
        {
            Name = name;
            INN = inn;
            Activity = activity;
            LicenseNumber = licenseNumber;
            CertificateSeries = certificateSeries;
            CertificateNumber = certificateNumber;
            Date = date;
            AutorizedCapital = autorizedCapital;
            ClientId = clientId;
        }

        Database dataBase = new Database();

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
            dgv.Columns.Add("Id", "ID");
            dgv.Columns.Add("Name", "Наименование");
            dgv.Columns.Add("INN", "ИНН");
            dgv.Columns.Add("Activity", "Вид деятельности");
            dgv.Columns.Add("LicenseNumber", "Номер лицензии");
            dgv.Columns.Add("СertificateSeries", "Серия свидетельства");
            dgv.Columns.Add("CertificateNumber", "Номер свидетельства");
            dgv.Columns.Add("Date", "Дата выдачи");
            dgv.Columns.Add("AuthorizedCapital", "Уставной капитал");
            dgv.Columns.Add("IsNew", String.Empty);
            
        }
        public void Search(TextBox textBox, DataGridView dgv)
        {
            string queryString = $"select * from ClientUR where concat (Id, Name, INN, Activity, LicenseNumber, СertificateSeries, CertificateNumber, Date, AuthorizedCapital)like '%{textBox.Text}%'";

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
        public void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetString(8), RowState.ModifieldNew);
        }

        public void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"select * from ClientUR";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);

            }
            reader.Close();
        }
        public void deleteRow(TextBox textBox)
        {
            string queryString = $"delete from ClientUR where id = {textBox.Text}";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            command.ExecuteNonQuery();
        }

        public new void Update(DataGridView dgv)
        {
            dataBase.OpenConnection();
            for (int index = 0; index < dgv.Rows.Count; index++)
            {
                var rowState = (RowState)dgv.Rows[index].Cells[8].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dgv.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from ClientUR where Id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modifield)
                {
                    var id = dgv.Rows[index].Cells[0].Value.ToString();
                    var name = dgv.Rows[index].Cells[1].Value.ToString();
                    var inn = dgv.Rows[index].Cells[2].Value.ToString();
                    var activity = dgv.Rows[index].Cells[3].Value.ToString();
                    var licenseNumber = dgv.Rows[index].Cells[4].Value.ToString();
                    var certificateSeries = dgv.Rows[index].Cells[5].Value.ToString();
                    var certificateNumber = dgv.Rows[index].Cells[6].Value.ToString();
                    var date = dgv.Rows[index].Cells[7].Value.ToString();
                    var authorizedCapital = dgv.Rows[index].Cells[8].Value.ToString();

                    var ChangeQuery = $"update ClientUR set Name = '{name}', INN = '{inn}', Activity = '{activity}', LicenseNumber = '{licenseNumber}', СertificateSeries = '{certificateSeries}', CertificateNumber = '{certificateNumber}', Date = '{date}', AuthorizedCapital = '{authorizedCapital}' where Id = {id}";

                    var command = new SqlCommand(ChangeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

            }
            dataBase.CloseConnection();
        }

       public void Change(TextBox textBoxName, TextBox textBoxINN, TextBox textBoxActivity, TextBox textBoxLicenseNumber, TextBox textBoxSertifSeries, TextBox textBoxCertifNumber, TextBox textBoxDate, TextBox textBoxCapital, TextBox textBoxId)
        {

            string queryString = $"update ClientUR set Name = '{textBoxName.Text}', INN = '{textBoxINN.Text}', Activity = '{textBoxActivity.Text}', LicenseNumber = '{textBoxLicenseNumber.Text}', СertificateSeries = '{textBoxSertifSeries.Text}', CertificateNumber = '{textBoxCertifNumber.Text}', Date = '{textBoxDate.Text}', AuthorizedCapital = '{textBoxCapital.Text}' where Id = {textBoxId.Text}";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            command.ExecuteNonQuery();

        }        
    }
}
