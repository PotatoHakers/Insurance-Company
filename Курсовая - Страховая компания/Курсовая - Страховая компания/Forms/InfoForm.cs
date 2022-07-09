using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая___Страховая_компания
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            InsuranceCompanyMenu InsuranceCompanyMenu = new InsuranceCompanyMenu();
            InsuranceCompanyMenu.Show();
            this.Hide();
        }
    }
}
