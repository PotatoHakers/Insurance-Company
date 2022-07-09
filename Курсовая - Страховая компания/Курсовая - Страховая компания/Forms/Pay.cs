using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Word = Microsoft.Office.Interop.Word;
using System.Data.SqlClient;
using InsuranceCompany;
using InsuranceCompany.Class;

namespace Курсовая___Страховая_компания
{
    public partial class Pay : Form
    {
        FileReader fileReader = new FileReader();

        public Pay()
        {
            InitializeComponent();
            
            //Добавление элементов в комбобокс
            comboBoxSeriaPas.Items.Add("AB");
            comboBoxSeriaPas.Items.Add("BM");
            comboBoxSeriaPas.Items.Add("HB");
            comboBoxSeriaPas.Items.Add("KH");
            comboBoxSeriaPas.Items.Add("MP");
            comboBoxSeriaPas.Items.Add("MC");
            comboBoxSeriaPas.Items.Add("KB");
            comboBoxSeriaPas.Items.Add("PP");


        }

        private void Pay_Load(object sender, EventArgs e)
        {
            fileReader.FileRead(@"E:\1234.txt", comboBoxFIOK);
        }   
        private void Pay_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Выход из программы при закрытии формы
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Печать документа
            //Создание объекта для печати, конструктор WordHelp + название документа
            var print = new WordHelp("TYPEPAY.docx");
            //Тут каждому элементу будет соответствовать свой текст бокс с текстом
            var item = new Dictionary<string, string>
            {
                //Присваиваем теги текст боксам
                { "<TYPEPAY>", textBoxTypePay.Text },
                { "<TIME>", dateTimePicker1.Text},
                { "<CASHIER>", comboBoxFIOK.Text},
                { "<PAYERS>", textBoxFIOP.Text},
                { "<NUM>", comboBoxSeriaPas.Text},
                { "<ID>", textBoxIdPas.Text},
                { "<SUM>", numericUpDownMoney.Text},
            };
            
            print.Process(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsuranceCompanyMenu insuranceCompanyMenu = new InsuranceCompanyMenu();
            insuranceCompanyMenu.Show();
            this.Hide();
        }
    }
    }

    
    

