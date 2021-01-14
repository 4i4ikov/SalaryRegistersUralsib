namespace SalaryRegistersUralsib.Forms
{
    partial class FormDOS
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
            this.components = new System.ComponentModel.Container();
            this.cardTableAdapter = new SalaryRegistersUralsib.DbDataSetTableAdapters.CardTableAdapter();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new SalaryRegistersUralsib.DbDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablenumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documserialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regioncodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNILSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgkeyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FireButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardTableAdapter
            // 
            this.cardTableAdapter.ClearBeforeFill = true;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "Card";
            this.cardBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "DbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.tablenumDataGridViewTextBoxColumn1,
            this.documDataGridViewTextBoxColumn,
            this.documserialDataGridViewTextBoxColumn,
            this.documnumDataGridViewTextBoxColumn,
            this.documdateDataGridViewTextBoxColumn,
            this.documplaceDataGridViewTextBoxColumn,
            this.documcodDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.regioncodDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.blockDataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.placeOfBirthDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.sNILSDataGridViewTextBoxColumn,
            this.homephoneDataGridViewTextBoxColumn,
            this.iNNworkerDataGridViewTextBoxColumn,
            this.fullNameCardDataGridViewTextBoxColumn,
            this.codeWordDataGridViewTextBoxColumn,
            this.bankCodeDataGridViewTextBoxColumn,
            this.cardtypeDataGridViewTextBoxColumn,
            this.employmentDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.orgkeyDataGridViewTextBoxColumn1,
            this.codeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cardBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 404);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.TabStop = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 81;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middlenameDataGridViewTextBoxColumn.Width = 79;
            // 
            // tablenumDataGridViewTextBoxColumn1
            // 
            this.tablenumDataGridViewTextBoxColumn1.DataPropertyName = "Table_num";
            this.tablenumDataGridViewTextBoxColumn1.HeaderText = "Табельный №";
            this.tablenumDataGridViewTextBoxColumn1.Name = "tablenumDataGridViewTextBoxColumn1";
            this.tablenumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tablenumDataGridViewTextBoxColumn1.Width = 95;
            // 
            // documDataGridViewTextBoxColumn
            // 
            this.documDataGridViewTextBoxColumn.DataPropertyName = "Docum";
            this.documDataGridViewTextBoxColumn.HeaderText = "Документ";
            this.documDataGridViewTextBoxColumn.Name = "documDataGridViewTextBoxColumn";
            this.documDataGridViewTextBoxColumn.ReadOnly = true;
            this.documDataGridViewTextBoxColumn.Width = 83;
            // 
            // documserialDataGridViewTextBoxColumn
            // 
            this.documserialDataGridViewTextBoxColumn.DataPropertyName = "Docum_serial";
            this.documserialDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.documserialDataGridViewTextBoxColumn.Name = "documserialDataGridViewTextBoxColumn";
            this.documserialDataGridViewTextBoxColumn.ReadOnly = true;
            this.documserialDataGridViewTextBoxColumn.Width = 63;
            // 
            // documnumDataGridViewTextBoxColumn
            // 
            this.documnumDataGridViewTextBoxColumn.DataPropertyName = "Docum_num";
            this.documnumDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.documnumDataGridViewTextBoxColumn.Name = "documnumDataGridViewTextBoxColumn";
            this.documnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.documnumDataGridViewTextBoxColumn.Width = 66;
            // 
            // documdateDataGridViewTextBoxColumn
            // 
            this.documdateDataGridViewTextBoxColumn.DataPropertyName = "Docum_date";
            this.documdateDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.documdateDataGridViewTextBoxColumn.Name = "documdateDataGridViewTextBoxColumn";
            this.documdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.documdateDataGridViewTextBoxColumn.Width = 90;
            // 
            // documplaceDataGridViewTextBoxColumn
            // 
            this.documplaceDataGridViewTextBoxColumn.DataPropertyName = "Docum_place";
            this.documplaceDataGridViewTextBoxColumn.HeaderText = "Место выдачи";
            this.documplaceDataGridViewTextBoxColumn.Name = "documplaceDataGridViewTextBoxColumn";
            this.documplaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.documplaceDataGridViewTextBoxColumn.Width = 96;
            // 
            // documcodDataGridViewTextBoxColumn
            // 
            this.documcodDataGridViewTextBoxColumn.DataPropertyName = "Docum_cod";
            this.documcodDataGridViewTextBoxColumn.HeaderText = "Код подр.";
            this.documcodDataGridViewTextBoxColumn.Name = "documcodDataGridViewTextBoxColumn";
            this.documcodDataGridViewTextBoxColumn.ReadOnly = true;
            this.documcodDataGridViewTextBoxColumn.Width = 75;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 62;
            // 
            // regioncodDataGridViewTextBoxColumn
            // 
            this.regioncodDataGridViewTextBoxColumn.DataPropertyName = "Region_cod";
            this.regioncodDataGridViewTextBoxColumn.HeaderText = "Код региона";
            this.regioncodDataGridViewTextBoxColumn.Name = "regioncodDataGridViewTextBoxColumn";
            this.regioncodDataGridViewTextBoxColumn.ReadOnly = true;
            this.regioncodDataGridViewTextBoxColumn.Width = 87;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "Район";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.ReadOnly = true;
            this.districtDataGridViewTextBoxColumn.Width = 63;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Width = 64;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Width = 55;
            // 
            // blockDataGridViewTextBoxColumn
            // 
            this.blockDataGridViewTextBoxColumn.DataPropertyName = "Block";
            this.blockDataGridViewTextBoxColumn.HeaderText = "Корпус";
            this.blockDataGridViewTextBoxColumn.Name = "blockDataGridViewTextBoxColumn";
            this.blockDataGridViewTextBoxColumn.ReadOnly = true;
            this.blockDataGridViewTextBoxColumn.Width = 68;
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "Квартира";
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            this.apartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.apartmentDataGridViewTextBoxColumn.Width = 80;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            this.indexDataGridViewTextBoxColumn.Width = 70;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDataGridViewTextBoxColumn.Width = 102;
            // 
            // placeOfBirthDataGridViewTextBoxColumn
            // 
            this.placeOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Place_Of_Birth";
            this.placeOfBirthDataGridViewTextBoxColumn.HeaderText = "Место рождения";
            this.placeOfBirthDataGridViewTextBoxColumn.Name = "placeOfBirthDataGridViewTextBoxColumn";
            this.placeOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.placeOfBirthDataGridViewTextBoxColumn.Width = 107;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 52;
            // 
            // sNILSDataGridViewTextBoxColumn
            // 
            this.sNILSDataGridViewTextBoxColumn.DataPropertyName = "SNILS";
            this.sNILSDataGridViewTextBoxColumn.HeaderText = "СНИЛС";
            this.sNILSDataGridViewTextBoxColumn.Name = "sNILSDataGridViewTextBoxColumn";
            this.sNILSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNILSDataGridViewTextBoxColumn.Width = 70;
            // 
            // homephoneDataGridViewTextBoxColumn
            // 
            this.homephoneDataGridViewTextBoxColumn.DataPropertyName = "Home_phone";
            this.homephoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.homephoneDataGridViewTextBoxColumn.Name = "homephoneDataGridViewTextBoxColumn";
            this.homephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.homephoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // iNNworkerDataGridViewTextBoxColumn
            // 
            this.iNNworkerDataGridViewTextBoxColumn.DataPropertyName = "INN_worker";
            this.iNNworkerDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.iNNworkerDataGridViewTextBoxColumn.Name = "iNNworkerDataGridViewTextBoxColumn";
            this.iNNworkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNNworkerDataGridViewTextBoxColumn.Width = 56;
            // 
            // fullNameCardDataGridViewTextBoxColumn
            // 
            this.fullNameCardDataGridViewTextBoxColumn.DataPropertyName = "Full_Name_Card";
            this.fullNameCardDataGridViewTextBoxColumn.HeaderText = "ФамилияИмя на карте";
            this.fullNameCardDataGridViewTextBoxColumn.Name = "fullNameCardDataGridViewTextBoxColumn";
            this.fullNameCardDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameCardDataGridViewTextBoxColumn.Width = 111;
            // 
            // codeWordDataGridViewTextBoxColumn
            // 
            this.codeWordDataGridViewTextBoxColumn.DataPropertyName = "Code_Word";
            this.codeWordDataGridViewTextBoxColumn.HeaderText = "Кодовое слово";
            this.codeWordDataGridViewTextBoxColumn.Name = "codeWordDataGridViewTextBoxColumn";
            this.codeWordDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeWordDataGridViewTextBoxColumn.Width = 99;
            // 
            // bankCodeDataGridViewTextBoxColumn
            // 
            this.bankCodeDataGridViewTextBoxColumn.DataPropertyName = "Bank_Code";
            this.bankCodeDataGridViewTextBoxColumn.HeaderText = "Код подр. банка";
            this.bankCodeDataGridViewTextBoxColumn.Name = "bankCodeDataGridViewTextBoxColumn";
            this.bankCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankCodeDataGridViewTextBoxColumn.Width = 105;
            // 
            // cardtypeDataGridViewTextBoxColumn
            // 
            this.cardtypeDataGridViewTextBoxColumn.DataPropertyName = "Card_type";
            this.cardtypeDataGridViewTextBoxColumn.HeaderText = "Тип карты";
            this.cardtypeDataGridViewTextBoxColumn.Name = "cardtypeDataGridViewTextBoxColumn";
            this.cardtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardtypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.DataPropertyName = "Employment_Date";
            this.employmentDateDataGridViewTextBoxColumn.HeaderText = "Дата зачисления";
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            this.employmentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.employmentDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "ЗП";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 47;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // orgkeyDataGridViewTextBoxColumn1
            // 
            this.orgkeyDataGridViewTextBoxColumn1.DataPropertyName = "Org_key";
            this.orgkeyDataGridViewTextBoxColumn1.HeaderText = "Org_key";
            this.orgkeyDataGridViewTextBoxColumn1.Name = "orgkeyDataGridViewTextBoxColumn1";
            this.orgkeyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orgkeyDataGridViewTextBoxColumn1.Visible = false;
            this.orgkeyDataGridViewTextBoxColumn1.Width = 72;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Visible = false;
            this.codeDataGridViewTextBoxColumn.Width = 57;
            // 
            // FireButton
            // 
            this.FireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FireButton.Location = new System.Drawing.Point(233, 12);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(105, 28);
            this.FireButton.TabIndex = 14;
            this.FireButton.Text = "Удалить";
            this.FireButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(8, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 28);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(119, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Правка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(678, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(553, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Экспорт в DOS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(428, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 28);
            this.button4.TabIndex = 14;
            this.button4.Text = "Импорт из DOS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FireButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDOS";
            this.Text = "Преобразование данных зарплатных карт";
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DbDataSetTableAdapters.CardTableAdapter cardTableAdapter;
        internal System.Windows.Forms.BindingSource cardBindingSource;
        private DbDataSet dbDataSet;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn documDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documserialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regioncodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNILSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgkeyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}