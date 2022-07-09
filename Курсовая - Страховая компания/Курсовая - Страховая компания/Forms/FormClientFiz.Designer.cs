namespace Курсовая___Страховая_компания
{
    partial class FormClientFiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientFiz));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxSeriaPass = new System.Windows.Forms.TextBox();
            this.textBoxNumberPass = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxProperty = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSerPass = new System.Windows.Forms.Label();
            this.labelNumPass = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelProperty = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(1314, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Image = global::InsuranceCompany.Properties.Resources.button_NqpDK;
            this.buttonExit.Location = new System.Drawing.Point(12, 601);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 38);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(1178, 491);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 34);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить клиента";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(369, 494);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(231, 23);
            this.textBoxId.TabIndex = 3;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(369, 535);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(231, 23);
            this.textBoxFIO.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(369, 576);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(231, 23);
            this.textBoxAddress.TabIndex = 5;
            // 
            // textBoxSeriaPass
            // 
            this.textBoxSeriaPass.Location = new System.Drawing.Point(748, 494);
            this.textBoxSeriaPass.Name = "textBoxSeriaPass";
            this.textBoxSeriaPass.Size = new System.Drawing.Size(135, 23);
            this.textBoxSeriaPass.TabIndex = 6;
            // 
            // textBoxNumberPass
            // 
            this.textBoxNumberPass.Location = new System.Drawing.Point(748, 535);
            this.textBoxNumberPass.Name = "textBoxNumberPass";
            this.textBoxNumberPass.Size = new System.Drawing.Size(135, 23);
            this.textBoxNumberPass.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(748, 576);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(135, 23);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(1021, 491);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(100, 23);
            this.textBoxBirthday.TabIndex = 9;
            // 
            // textBoxProperty
            // 
            this.textBoxProperty.Location = new System.Drawing.Point(1021, 532);
            this.textBoxProperty.Name = "textBoxProperty";
            this.textBoxProperty.Size = new System.Drawing.Size(100, 23);
            this.textBoxProperty.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(1021, 573);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrice.TabIndex = 11;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(325, 497);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(17, 15);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "Id";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(325, 543);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 15);
            this.labelFIO.TabIndex = 14;
            this.labelFIO.Text = "ФИО";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(325, 579);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(40, 15);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Адрес";
            // 
            // labelSerPass
            // 
            this.labelSerPass.AutoSize = true;
            this.labelSerPass.Location = new System.Drawing.Point(643, 497);
            this.labelSerPass.Name = "labelSerPass";
            this.labelSerPass.Size = new System.Drawing.Size(95, 15);
            this.labelSerPass.TabIndex = 16;
            this.labelSerPass.Text = "Серия паспорта";
            // 
            // labelNumPass
            // 
            this.labelNumPass.AutoSize = true;
            this.labelNumPass.Location = new System.Drawing.Point(643, 538);
            this.labelNumPass.Name = "labelNumPass";
            this.labelNumPass.Size = new System.Drawing.Size(99, 15);
            this.labelNumPass.TabIndex = 17;
            this.labelNumPass.Text = "Номер паспорта";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(643, 579);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 15);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Телефон";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(926, 494);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(90, 15);
            this.labelBirthday.TabIndex = 19;
            this.labelBirthday.Text = "Дата рождения";
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Location = new System.Drawing.Point(926, 535);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(72, 15);
            this.labelProperty.TabIndex = 20;
            this.labelProperty.Text = "Имущество";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(926, 576);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 15);
            this.labelPrice.TabIndex = 21;
            this.labelPrice.Text = "Цена";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(12, 480);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(36, 36);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(54, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(96, 483);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(199, 29);
            this.textBoxSearch.TabIndex = 23;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(1178, 535);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 34);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Удалить клиента";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Image = global::InsuranceCompany.Properties.Resources.exit;
            this.buttonBack.Location = new System.Drawing.Point(54, 601);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 38);
            this.buttonBack.TabIndex = 26;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChange.Location = new System.Drawing.Point(1178, 580);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(148, 34);
            this.buttonChange.TabIndex = 27;
            this.buttonChange.Text = "Изменить клиента";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // FormWithDateBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 647);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProperty);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelNumPass);
            this.Controls.Add(this.labelSerPass);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProperty);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxNumberPass);
            this.Controls.Add(this.textBoxSeriaPass);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWithDateBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список физических лиц";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWithDateBase_FormClosed);
            this.Load += new System.EventHandler(this.FormWithDateBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonExit;
        private Button buttonAdd;
        private TextBox textBoxId;
        private TextBox textBoxFIO;
        private TextBox textBoxAddress;
        private TextBox textBoxSeriaPass;
        private TextBox textBoxNumberPass;
        private TextBox textBoxPhone;
        private TextBox textBoxBirthday;
        private TextBox textBoxProperty;
        private TextBox textBoxPrice;
        private Label labelID;
        private Label labelFIO;
        private Label labelAddress;
        private Label labelSerPass;
        private Label labelNumPass;
        private Label labelPhone;
        private Label labelBirthday;
        private Label labelProperty;
        private Label labelPrice;
        private Button buttonUpdate;
        private Button button1;
        private TextBox textBoxSearch;
        private Button buttonDelete;
        private Button buttonBack;
        private Button buttonChange;
    }
}