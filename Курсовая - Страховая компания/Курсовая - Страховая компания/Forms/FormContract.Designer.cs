namespace InsuranceCompany
{
    partial class FormContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContract));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelEmp = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxFIOClient = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelSeria = new System.Windows.Forms.Label();
            this.textBoxSeria = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.radioButtonLife = new System.Windows.Forms.RadioButton();
            this.radioButtonProperty = new System.Windows.Forms.RadioButton();
            this.groupBoxTypeInc = new System.Windows.Forms.GroupBox();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.rb36month = new System.Windows.Forms.RadioButton();
            this.rb32month = new System.Windows.Forms.RadioButton();
            this.rb24month = new System.Windows.Forms.RadioButton();
            this.rb18month = new System.Windows.Forms.RadioButton();
            this.rb12month = new System.Windows.Forms.RadioButton();
            this.rb6Month = new System.Windows.Forms.RadioButton();
            this.labelMoney = new System.Windows.Forms.Label();
            this.comboBoxEmp = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.labelTerm = new System.Windows.Forms.Label();
            this.groupBoxTypeInc.SuspendLayout();
            this.groupBoxPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Image = global::InsuranceCompany.Properties.Resources.exit;
            this.buttonBack.Location = new System.Drawing.Point(721, 542);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 38);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Image = global::InsuranceCompany.Properties.Resources.button_NqpDK;
            this.buttonExit.Location = new System.Drawing.Point(781, 542);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 38);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(13, 295);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(146, 15);
            this.labelDate.TabIndex = 29;
            this.labelDate.Text = "Дата принятия заявления";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 23);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // labelEmp
            // 
            this.labelEmp.AutoSize = true;
            this.labelEmp.Location = new System.Drawing.Point(12, 58);
            this.labelEmp.Name = "labelEmp";
            this.labelEmp.Size = new System.Drawing.Size(66, 15);
            this.labelEmp.TabIndex = 31;
            this.labelEmp.Text = "Сотрудник";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 23);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(81, 15);
            this.labelClient.TabIndex = 37;
            this.labelClient.Text = "ФИО клиента";
            // 
            // textBoxFIOClient
            // 
            this.textBoxFIOClient.Location = new System.Drawing.Point(293, 20);
            this.textBoxFIOClient.Name = "textBoxFIOClient";
            this.textBoxFIOClient.Size = new System.Drawing.Size(239, 23);
            this.textBoxFIOClient.TabIndex = 38;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 258);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(45, 15);
            this.labelNumber.TabIndex = 39;
            this.labelNumber.Text = "Номер";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(89, 255);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumber.TabIndex = 40;
            // 
            // labelSeria
            // 
            this.labelSeria.AutoSize = true;
            this.labelSeria.Location = new System.Drawing.Point(219, 258);
            this.labelSeria.Name = "labelSeria";
            this.labelSeria.Size = new System.Drawing.Size(95, 15);
            this.labelSeria.TabIndex = 41;
            this.labelSeria.Text = "Серия договора";
            // 
            // textBoxSeria
            // 
            this.textBoxSeria.Location = new System.Drawing.Point(346, 255);
            this.textBoxSeria.Name = "textBoxSeria";
            this.textBoxSeria.Size = new System.Drawing.Size(187, 23);
            this.textBoxSeria.TabIndex = 42;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(13, 364);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(83, 20);
            this.labelPrice.TabIndex = 47;
            this.labelPrice.Text = "Стоимость";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(115, 365);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(143, 23);
            this.textBoxPrice.TabIndex = 48;
            // 
            // buttonPrice
            // 
            this.buttonPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrice.Location = new System.Drawing.Point(72, 409);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(104, 37);
            this.buttonPrice.TabIndex = 49;
            this.buttonPrice.Text = "Рассчитать";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.Window;
            this.buttonPrint.Image = global::InsuranceCompany.Properties.Resources.printer;
            this.buttonPrint.Location = new System.Drawing.Point(12, 529);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(66, 51);
            this.buttonPrint.TabIndex = 50;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // radioButtonLife
            // 
            this.radioButtonLife.AutoSize = true;
            this.radioButtonLife.Location = new System.Drawing.Point(6, 25);
            this.radioButtonLife.Name = "radioButtonLife";
            this.radioButtonLife.Size = new System.Drawing.Size(77, 19);
            this.radioButtonLife.TabIndex = 51;
            this.radioButtonLife.TabStop = true;
            this.radioButtonLife.Text = "Здоровье";
            this.radioButtonLife.UseVisualStyleBackColor = true;
            this.radioButtonLife.CheckedChanged += new System.EventHandler(this.radioButtonLife_CheckedChanged);
            // 
            // radioButtonProperty
            // 
            this.radioButtonProperty.AutoSize = true;
            this.radioButtonProperty.Location = new System.Drawing.Point(6, 62);
            this.radioButtonProperty.Name = "radioButtonProperty";
            this.radioButtonProperty.Size = new System.Drawing.Size(90, 19);
            this.radioButtonProperty.TabIndex = 52;
            this.radioButtonProperty.TabStop = true;
            this.radioButtonProperty.Text = "Имущество";
            this.radioButtonProperty.UseVisualStyleBackColor = true;
            this.radioButtonProperty.CheckedChanged += new System.EventHandler(this.radioButtonProperty_CheckedChanged);
            // 
            // groupBoxTypeInc
            // 
            this.groupBoxTypeInc.Controls.Add(this.radioButtonLife);
            this.groupBoxTypeInc.Controls.Add(this.radioButtonProperty);
            this.groupBoxTypeInc.Location = new System.Drawing.Point(12, 98);
            this.groupBoxTypeInc.Name = "groupBoxTypeInc";
            this.groupBoxTypeInc.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTypeInc.TabIndex = 53;
            this.groupBoxTypeInc.TabStop = false;
            this.groupBoxTypeInc.Text = "Тип страхования";
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.rb36month);
            this.groupBoxPeriod.Controls.Add(this.rb32month);
            this.groupBoxPeriod.Controls.Add(this.rb24month);
            this.groupBoxPeriod.Controls.Add(this.rb18month);
            this.groupBoxPeriod.Controls.Add(this.rb12month);
            this.groupBoxPeriod.Controls.Add(this.rb6Month);
            this.groupBoxPeriod.Location = new System.Drawing.Point(332, 98);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(200, 100);
            this.groupBoxPeriod.TabIndex = 54;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Срок страхования";
            // 
            // rb36month
            // 
            this.rb36month.AutoSize = true;
            this.rb36month.Location = new System.Drawing.Point(106, 75);
            this.rb36month.Name = "rb36month";
            this.rb36month.Size = new System.Drawing.Size(86, 19);
            this.rb36month.TabIndex = 5;
            this.rb36month.TabStop = true;
            this.rb36month.Text = "36 месяцев";
            this.rb36month.UseVisualStyleBackColor = true;
            // 
            // rb32month
            // 
            this.rb32month.AutoSize = true;
            this.rb32month.Location = new System.Drawing.Point(106, 50);
            this.rb32month.Name = "rb32month";
            this.rb32month.Size = new System.Drawing.Size(80, 19);
            this.rb32month.TabIndex = 4;
            this.rb32month.TabStop = true;
            this.rb32month.Text = "32 месяца";
            this.rb32month.UseVisualStyleBackColor = true;
            // 
            // rb24month
            // 
            this.rb24month.AutoSize = true;
            this.rb24month.Location = new System.Drawing.Point(106, 25);
            this.rb24month.Name = "rb24month";
            this.rb24month.Size = new System.Drawing.Size(80, 19);
            this.rb24month.TabIndex = 3;
            this.rb24month.TabStop = true;
            this.rb24month.Text = "24 месяца";
            this.rb24month.UseVisualStyleBackColor = true;
            // 
            // rb18month
            // 
            this.rb18month.AutoSize = true;
            this.rb18month.Location = new System.Drawing.Point(6, 75);
            this.rb18month.Name = "rb18month";
            this.rb18month.Size = new System.Drawing.Size(86, 19);
            this.rb18month.TabIndex = 2;
            this.rb18month.TabStop = true;
            this.rb18month.Text = "18 месяцев";
            this.rb18month.UseVisualStyleBackColor = true;
            // 
            // rb12month
            // 
            this.rb12month.AutoSize = true;
            this.rb12month.Location = new System.Drawing.Point(6, 50);
            this.rb12month.Name = "rb12month";
            this.rb12month.Size = new System.Drawing.Size(86, 19);
            this.rb12month.TabIndex = 1;
            this.rb12month.TabStop = true;
            this.rb12month.Text = "12 месяцев";
            this.rb12month.UseVisualStyleBackColor = true;
            // 
            // rb6Month
            // 
            this.rb6Month.AutoSize = true;
            this.rb6Month.Location = new System.Drawing.Point(6, 25);
            this.rb6Month.Name = "rb6Month";
            this.rb6Month.Size = new System.Drawing.Size(80, 19);
            this.rb6Month.TabIndex = 0;
            this.rb6Month.TabStop = true;
            this.rb6Month.Text = "6 месяцев";
            this.rb6Month.UseVisualStyleBackColor = true;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(13, 331);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(132, 15);
            this.labelMoney.TabIndex = 55;
            this.labelMoney.Text = "Стоимость имущества";
            this.labelMoney.Visible = false;
            // 
            // comboBoxEmp
            // 
            this.comboBoxEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmp.FormattingEnabled = true;
            this.comboBoxEmp.Location = new System.Drawing.Point(293, 55);
            this.comboBoxEmp.Name = "comboBoxEmp";
            this.comboBoxEmp.Size = new System.Drawing.Size(239, 23);
            this.comboBoxEmp.TabIndex = 57;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(670, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(42, 20);
            this.labelTime.TabIndex = 58;
            this.labelTime.Text = "Time";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(397, 329);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(136, 23);
            this.numericUpDown1.TabIndex = 59;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 218);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(99, 15);
            this.labelType.TabIndex = 60;
            this.labelType.Text = "Тип страхования";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(117, 215);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 23);
            this.textBoxType.TabIndex = 61;
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(432, 215);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(100, 23);
            this.textBoxTerm.TabIndex = 62;
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(319, 218);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(107, 15);
            this.labelTerm.TabIndex = 63;
            this.labelTerm.Text = "Срок страхования";
            // 
            // FormContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 592);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.comboBoxEmp);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.groupBoxPeriod);
            this.Controls.Add(this.groupBoxTypeInc);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxSeria);
            this.Controls.Add(this.labelSeria);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxFIOClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelEmp);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDogovor_FormClosed);
            this.Load += new System.EventHandler(this.FormDogovor_Load);
            this.groupBoxTypeInc.ResumeLayout(false);
            this.groupBoxTypeInc.PerformLayout();
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBack;
        private Button buttonExit;
        private Label labelDate;
        private DateTimePicker dateTimePicker1;
        private Label labelEmp;
        private Label labelClient;
        private TextBox textBoxFIOClient;
        private Label labelNumber;
        private TextBox textBoxNumber;
        private Label labelSeria;
        private TextBox textBoxSeria;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Button buttonPrice;
        private Button buttonPrint;
        private RadioButton radioButtonLife;
        private RadioButton radioButtonProperty;
        private GroupBox groupBoxTypeInc;
        private GroupBox groupBoxPeriod;
        private RadioButton rb36month;
        private RadioButton rb32month;
        private RadioButton rb24month;
        private RadioButton rb18month;
        private RadioButton rb12month;
        private RadioButton rb6Month;
        private Label labelMoney;
        private ComboBox comboBoxEmp;
        private Label labelTime;
        private NumericUpDown numericUpDown1;
        private Label labelType;
        private TextBox textBoxType;
        private TextBox textBoxTerm;
        private Label labelTerm;
    }
}