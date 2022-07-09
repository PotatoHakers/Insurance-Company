namespace Курсовая___Страховая_компания
{
    partial class Pay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.PaymentLable = new System.Windows.Forms.Label();
            this.textBoxTypePay = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelMoney = new System.Windows.Forms.Label();
            this.numericUpDownMoney = new System.Windows.Forms.NumericUpDown();
            this.labelFIOK = new System.Windows.Forms.Label();
            this.labelFIOP = new System.Windows.Forms.Label();
            this.textBoxFIOP = new System.Windows.Forms.TextBox();
            this.labelSeriaPassport = new System.Windows.Forms.Label();
            this.comboBoxSeriaPas = new System.Windows.Forms.ComboBox();
            this.labelIdPassport = new System.Windows.Forms.Label();
            this.textBoxIdPas = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxFIOK = new System.Windows.Forms.ComboBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentLable
            // 
            this.PaymentLable.AutoSize = true;
            this.PaymentLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentLable.Location = new System.Drawing.Point(37, 26);
            this.PaymentLable.Name = "PaymentLable";
            this.PaymentLable.Size = new System.Drawing.Size(93, 20);
            this.PaymentLable.TabIndex = 0;
            this.PaymentLable.Text = "Тип оплаты:";
            // 
            // textBoxTypePay
            // 
            this.textBoxTypePay.Location = new System.Drawing.Point(193, 27);
            this.textBoxTypePay.Name = "textBoxTypePay";
            this.textBoxTypePay.Size = new System.Drawing.Size(347, 23);
            this.textBoxTypePay.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(37, 72);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(99, 20);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Дата оплаты:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 15, 21, 7, 31, 0);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMoney.Location = new System.Drawing.Point(37, 118);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(58, 20);
            this.labelMoney.TabIndex = 4;
            this.labelMoney.Text = "Сумма:";
            // 
            // numericUpDownMoney
            // 
            this.numericUpDownMoney.Location = new System.Drawing.Point(193, 115);
            this.numericUpDownMoney.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownMoney.Name = "numericUpDownMoney";
            this.numericUpDownMoney.Size = new System.Drawing.Size(347, 23);
            this.numericUpDownMoney.TabIndex = 5;
            // 
            // labelFIOK
            // 
            this.labelFIOK.AutoSize = true;
            this.labelFIOK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFIOK.Location = new System.Drawing.Point(37, 163);
            this.labelFIOK.Name = "labelFIOK";
            this.labelFIOK.Size = new System.Drawing.Size(100, 20);
            this.labelFIOK.TabIndex = 6;
            this.labelFIOK.Text = "Фио кассира:";
            // 
            // labelFIOP
            // 
            this.labelFIOP.AutoSize = true;
            this.labelFIOP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFIOP.Location = new System.Drawing.Point(37, 212);
            this.labelFIOP.Name = "labelFIOP";
            this.labelFIOP.Size = new System.Drawing.Size(142, 20);
            this.labelFIOP.TabIndex = 8;
            this.labelFIOP.Text = "ФИО Плательщика:";
            // 
            // textBoxFIOP
            // 
            this.textBoxFIOP.Location = new System.Drawing.Point(193, 212);
            this.textBoxFIOP.Name = "textBoxFIOP";
            this.textBoxFIOP.Size = new System.Drawing.Size(347, 23);
            this.textBoxFIOP.TabIndex = 9;
            // 
            // labelSeriaPassport
            // 
            this.labelSeriaPassport.AutoSize = true;
            this.labelSeriaPassport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeriaPassport.Location = new System.Drawing.Point(37, 254);
            this.labelSeriaPassport.Name = "labelSeriaPassport";
            this.labelSeriaPassport.Size = new System.Drawing.Size(124, 20);
            this.labelSeriaPassport.TabIndex = 10;
            this.labelSeriaPassport.Text = "Серия паспорта:";
            // 
            // comboBoxSeriaPas
            // 
            this.comboBoxSeriaPas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeriaPas.FormattingEnabled = true;
            this.comboBoxSeriaPas.Location = new System.Drawing.Point(193, 255);
            this.comboBoxSeriaPas.Name = "comboBoxSeriaPas";
            this.comboBoxSeriaPas.Size = new System.Drawing.Size(347, 23);
            this.comboBoxSeriaPas.TabIndex = 11;
            // 
            // labelIdPassport
            // 
            this.labelIdPassport.AutoSize = true;
            this.labelIdPassport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdPassport.Location = new System.Drawing.Point(37, 303);
            this.labelIdPassport.Name = "labelIdPassport";
            this.labelIdPassport.Size = new System.Drawing.Size(129, 20);
            this.labelIdPassport.TabIndex = 12;
            this.labelIdPassport.Text = "Номер паспорта:";
            // 
            // textBoxIdPas
            // 
            this.textBoxIdPas.Location = new System.Drawing.Point(193, 304);
            this.textBoxIdPas.Name = "textBoxIdPas";
            this.textBoxIdPas.Size = new System.Drawing.Size(347, 23);
            this.textBoxIdPas.TabIndex = 13;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBack.Image = global::InsuranceCompany.Properties.Resources.button_NqpDK;
            this.buttonBack.Location = new System.Drawing.Point(738, 394);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(50, 46);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxFIOK
            // 
            this.comboBoxFIOK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFIOK.FormattingEnabled = true;
            this.comboBoxFIOK.Location = new System.Drawing.Point(193, 160);
            this.comboBoxFIOK.Name = "comboBoxFIOK";
            this.comboBoxFIOK.Size = new System.Drawing.Size(347, 23);
            this.comboBoxFIOK.TabIndex = 15;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.Window;
            this.buttonPrint.Image = global::InsuranceCompany.Properties.Resources.printer;
            this.buttonPrint.Location = new System.Drawing.Point(12, 392);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(56, 46);
            this.buttonPrint.TabIndex = 16;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::InsuranceCompany.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(74, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 46);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.comboBoxFIOK);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxIdPas);
            this.Controls.Add(this.labelIdPassport);
            this.Controls.Add(this.comboBoxSeriaPas);
            this.Controls.Add(this.labelSeriaPassport);
            this.Controls.Add(this.textBoxFIOP);
            this.Controls.Add(this.labelFIOP);
            this.Controls.Add(this.labelFIOK);
            this.Controls.Add(this.numericUpDownMoney);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTypePay);
            this.Controls.Add(this.PaymentLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pay_FormClosed);
            this.Load += new System.EventHandler(this.Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PaymentLable;
        private TextBox textBoxTypePay;
        private Label labelTime;
        private DateTimePicker dateTimePicker1;
        private Label labelMoney;
        private NumericUpDown numericUpDownMoney;
        private Label labelFIOK;
        private Label labelFIOP;
        private TextBox textBoxFIOP;
        private Label labelSeriaPassport;
        private ComboBox comboBoxSeriaPas;
        private Label labelIdPassport;
        private TextBox textBoxIdPas;
        private Button buttonBack;
        private ComboBox comboBoxFIOK;
        private Button buttonPrint;
        private Button button1;
    }
}