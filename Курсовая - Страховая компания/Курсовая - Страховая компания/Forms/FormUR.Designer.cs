namespace InsuranceCompany
{
    partial class FormUR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUR));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCertifNumber = new System.Windows.Forms.Label();
            this.labelCertifSeries = new System.Windows.Forms.Label();
            this.labelLicenseNumber = new System.Windows.Forms.Label();
            this.labelActivity = new System.Windows.Forms.Label();
            this.labelINN = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxCertifNumber = new System.Windows.Forms.TextBox();
            this.textBoxSertifSeries = new System.Windows.Forms.TextBox();
            this.textBoxLicenseNumber = new System.Windows.Forms.TextBox();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBack.Image = global::InsuranceCompany.Properties.Resources.exit;
            this.buttonBack.Location = new System.Drawing.Point(1075, 598);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 38);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.TabStop = false;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Image = global::InsuranceCompany.Properties.Resources.button_NqpDK;
            this.buttonExit.Location = new System.Drawing.Point(1121, 598);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 38);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.TabStop = false;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 382);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChange.Location = new System.Drawing.Point(1013, 538);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(148, 38);
            this.buttonChange.TabIndex = 30;
            this.buttonChange.Text = "Изменить клиента";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(1013, 479);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 38);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Удалить клиента";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(1013, 416);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 38);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Добавить клиента";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(656, 551);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(105, 15);
            this.labelCapital.TabIndex = 48;
            this.labelCapital.Text = "Уставной капитал";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(656, 510);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 15);
            this.labelDate.TabIndex = 47;
            this.labelDate.Text = "Дата выдачи";
            // 
            // labelCertifNumber
            // 
            this.labelCertifNumber.AutoSize = true;
            this.labelCertifNumber.Location = new System.Drawing.Point(656, 469);
            this.labelCertifNumber.Name = "labelCertifNumber";
            this.labelCertifNumber.Size = new System.Drawing.Size(126, 15);
            this.labelCertifNumber.TabIndex = 46;
            this.labelCertifNumber.Text = "Номер свидетельства";
            // 
            // labelCertifSeries
            // 
            this.labelCertifSeries.AutoSize = true;
            this.labelCertifSeries.Location = new System.Drawing.Point(364, 551);
            this.labelCertifSeries.Name = "labelCertifSeries";
            this.labelCertifSeries.Size = new System.Drawing.Size(122, 15);
            this.labelCertifSeries.TabIndex = 45;
            this.labelCertifSeries.Text = "Серия свидетельства";
            // 
            // labelLicenseNumber
            // 
            this.labelLicenseNumber.AutoSize = true;
            this.labelLicenseNumber.Location = new System.Drawing.Point(364, 510);
            this.labelLicenseNumber.Name = "labelLicenseNumber";
            this.labelLicenseNumber.Size = new System.Drawing.Size(101, 15);
            this.labelLicenseNumber.TabIndex = 44;
            this.labelLicenseNumber.Text = "Номер лицензии";
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Location = new System.Drawing.Point(364, 469);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(104, 15);
            this.labelActivity.TabIndex = 43;
            this.labelActivity.Text = "Вид деятельности";
            // 
            // labelINN
            // 
            this.labelINN.AutoSize = true;
            this.labelINN.Location = new System.Drawing.Point(12, 551);
            this.labelINN.Name = "labelINN";
            this.labelINN.Size = new System.Drawing.Size(34, 15);
            this.labelINN.TabIndex = 42;
            this.labelINN.Text = "ИНН";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 510);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 15);
            this.labelName.TabIndex = 41;
            this.labelName.Text = "Наименование";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 469);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(17, 15);
            this.labelID.TabIndex = 40;
            this.labelID.Text = "Id";
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(788, 548);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(135, 23);
            this.textBoxCapital.TabIndex = 39;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(788, 507);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(135, 23);
            this.textBoxDate.TabIndex = 38;
            // 
            // textBoxCertifNumber
            // 
            this.textBoxCertifNumber.Location = new System.Drawing.Point(788, 466);
            this.textBoxCertifNumber.Name = "textBoxCertifNumber";
            this.textBoxCertifNumber.Size = new System.Drawing.Size(135, 23);
            this.textBoxCertifNumber.TabIndex = 37;
            // 
            // textBoxSertifSeries
            // 
            this.textBoxSertifSeries.Location = new System.Drawing.Point(494, 548);
            this.textBoxSertifSeries.Name = "textBoxSertifSeries";
            this.textBoxSertifSeries.Size = new System.Drawing.Size(135, 23);
            this.textBoxSertifSeries.TabIndex = 36;
            // 
            // textBoxLicenseNumber
            // 
            this.textBoxLicenseNumber.Location = new System.Drawing.Point(494, 507);
            this.textBoxLicenseNumber.Name = "textBoxLicenseNumber";
            this.textBoxLicenseNumber.Size = new System.Drawing.Size(135, 23);
            this.textBoxLicenseNumber.TabIndex = 35;
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Location = new System.Drawing.Point(494, 466);
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.Size = new System.Drawing.Size(135, 23);
            this.textBoxActivity.TabIndex = 34;
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(108, 548);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(231, 23);
            this.textBoxINN.TabIndex = 33;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 507);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(231, 23);
            this.textBoxName.TabIndex = 32;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(108, 466);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(231, 23);
            this.textBoxId.TabIndex = 31;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(106, 406);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(145, 29);
            this.textBoxSearch.TabIndex = 49;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(54, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(12, 403);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(36, 36);
            this.buttonUpdate.TabIndex = 50;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // FormUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCertifNumber);
            this.Controls.Add(this.labelCertifSeries);
            this.Controls.Add(this.labelLicenseNumber);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.labelINN);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxCertifNumber);
            this.Controls.Add(this.textBoxSertifSeries);
            this.Controls.Add(this.textBoxLicenseNumber);
            this.Controls.Add(this.textBoxActivity);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUR";
            this.Text = "Список юридических лиц";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUR_FormClosed);
            this.Load += new System.EventHandler(this.FormUR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBack;
        private Button buttonExit;
        private DataGridView dataGridView1;
        private Button buttonChange;
        private Button buttonDelete;
        private Button buttonAdd;
        private Label labelCapital;
        private Label labelDate;
        private Label labelCertifNumber;
        private Label labelCertifSeries;
        private Label labelLicenseNumber;
        private Label labelActivity;
        private Label labelINN;
        private Label labelName;
        private Label labelID;
        private TextBox textBoxCapital;
        private TextBox textBoxDate;
        private TextBox textBoxCertifNumber;
        private TextBox textBoxSertifSeries;
        private TextBox textBoxLicenseNumber;
        private TextBox textBoxActivity;
        private TextBox textBoxINN;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private TextBox textBoxSearch;
        private Button button1;
        private Button buttonUpdate;
    }
}