using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Class
{
    public class ClasDogovor
    {
        public void CalculationSystemLife(RadioButton radioButtonLife, RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4, RadioButton radioButton5, RadioButton radioButton6, TextBox textBox)
        {
            if (radioButtonLife.Checked)
            {
                if (radioButton1.Checked)
                {
                    textBox.Text = (60).ToString();
                }
                else if (radioButton2.Checked)
                {
                    textBox.Text = (110).ToString();
                }
                else if (radioButton3.Checked)
                {
                    textBox.Text = (160).ToString();
                }
                else if (radioButton4.Checked)
                {
                    textBox.Text = (210).ToString();
                }
                else if (radioButton5.Checked)
                {
                    textBox.Text = (260).ToString();
                }
                else if (radioButton6.Checked)
                {
                    textBox.Text = (300).ToString();
                }

                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false)
                {
                    MessageBox.Show("Выберите период действия договора");
                }
            }

        }

        public void CalculationSystemProperty(RadioButton radioButtonProperty, RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4, RadioButton radioButton5, RadioButton radioButton6, TextBox textBox, NumericUpDown numericUpDown1)
        {
            if (radioButtonProperty.Checked == true)
            {
                if (radioButton1.Checked)
                {
                    textBox.Text = (Convert.ToInt32(numericUpDown1.Text) * 0.06).ToString();
                }
                else if (radioButton2.Checked)
                {
                    textBox.Text = (Convert.ToInt32(numericUpDown1.Text) * 0.11).ToString();
                }
                else if (radioButton3.Checked)
                {
                    textBox.Text = (Convert.ToInt32(numericUpDown1.Text) * 0.15).ToString();
                }
                else if (radioButton4.Checked)
                {
                    textBox.Text = (Convert.ToInt32(numericUpDown1.Text) * 0.20).ToString();
                }
                else if (radioButton5.Checked)
                {
                    textBox.Text = (Convert.ToInt32(numericUpDown1.Text) * 0.26).ToString();
                }
                else if (radioButton6.Checked)
                {
                    textBox.Text = (Convert.ToInt16(numericUpDown1.Text) * 0.30).ToString();
                }
            }
        }
    }
}
