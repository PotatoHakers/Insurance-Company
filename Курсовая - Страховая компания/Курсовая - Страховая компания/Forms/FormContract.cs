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
using InsuranceCompany.Class;

namespace InsuranceCompany
{
    public partial class FormContract : Form
    {
        ClasDogovor dogovor = new ClasDogovor();
        FileReader fileReader = new FileReader();

        public FormContract()
        {
            InitializeComponent();

            //Создание таймера для отображения времени на форме и обновления формы
            timer.Tick += new EventHandler(RefreshLabel);
            //Интервал минимальный (1000 - 1 сек)
            timer.Interval = 1;
            timer.Start();

        }
        //Объявление таймера
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        
        private void FormDogovor_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Приложение закрывается по закрытию формы
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Возвращение на предыдущую форму
            InsuranceCompanyMenu insuranceCompanyMenu = new InsuranceCompanyMenu();
            insuranceCompanyMenu.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Закрытие приложения по нажатию на кнопку
            Application.Exit();
        }

        private void FormDogovor_Load(object sender, EventArgs e)
        {
            fileReader.FileRead(@"E:\1234.txt", comboBoxEmp);

        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            dogovor.CalculationSystemLife(radioButtonLife, rb6Month, rb12month, rb18month, rb24month, rb32month, rb36month, textBoxPrice);

            dogovor.CalculationSystemProperty(radioButtonProperty, rb6Month, rb12month, rb18month, rb24month, rb32month, rb36month, textBoxPrice, numericUpDown1);
        }

        public void RefreshLabel(object sender, EventArgs e)
        {
            //Обновление времени на форме
            labelTime.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();

            //Условие, что если кнопка Имущество нажата, то label и numericUpDown
            if (radioButtonProperty.Checked == true)
            {
                labelMoney.Visible = true;
                numericUpDown1.Visible = true;
            }
            //Если условие не выполняется, то label и numericUpDown скрыты
            else
            {
                labelMoney.Visible = false;
                numericUpDown1.Visible = false;
            }

            if (rb6Month.Checked)
            {
                textBoxTerm.Text = "6 месяцев";
            }
            else if (rb12month.Checked)
            {
                textBoxTerm.Text = "12 месяцев";
            }
            else if (rb18month.Checked)
            {
                textBoxTerm.Text = "18 месяцев";
            }
            else if (rb24month.Checked)
            {
                textBoxTerm.Text = "24 месяцев";
            }
            else if (rb32month.Checked)
            {
                textBoxTerm.Text = "32 месяцев";
            }
            else if (rb36month.Checked)
            {
                textBoxTerm.Text = "36 месяцев";
            }


        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var print = new WordHelp("FIO.docx");

            var item = new Dictionary<string, string>
            {
              {"<FIO>", textBoxFIOClient.Text},
              {"<CASHIER>", comboBoxEmp.Text},
              {"TYPE", textBoxType.Text},
              { "TERM", textBoxTerm.Text},
              {"<NUMBER>", textBoxNumber.Text},
              {"<SERIA>", textBoxSeria.Text},
              { "<DATE>", dateTimePicker1.Text},
              { "<PRICEPROPERTY>", numericUpDown1.Text},
              { "<PRICE>", textBoxPrice.Text},

            };
            print.Process(item);
        }

        private void radioButtonLife_CheckedChanged(object sender, EventArgs e)
        {
            textBoxType.Text = radioButtonLife.Text;
        }

        private void radioButtonProperty_CheckedChanged(object sender, EventArgs e)
        {
            textBoxType.Text = radioButtonProperty.Text;
        }
    }
}
