namespace pressF.Forms
{
    partial class FormDocumPick
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
            this.Docum = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DateTime2 = new CueTextBox();
            this.Docum_Cod = new CueTextBox();
            this.Docum_Place = new CueTextBox();
            this.Docum_Num = new CueTextBox();
            this.Docum_Serial = new CueTextBox();
            this.SuspendLayout();
            // 
            // Docum
            // 
            this.Docum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Docum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Docum.BackColor = System.Drawing.SystemColors.Window;
            this.Docum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Docum.DropDownWidth = 300;
            this.Docum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Docum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Docum.FormattingEnabled = true;
            this.Docum.ItemHeight = 13;
            this.Docum.Items.AddRange(new object[] {
            "паспорт гражданина РФ ",
            "свидетельство о рождении гражданина РФ ",
            "удостоверение личности военнослужащего ",
            "паспорт моряка / удостоверение личности моряка",
            "военный билет",
            "дипломатический паспорт",
            "паспорт иностранного гражданина",
            "свидетельство ходатайстве о признании лица беженцем",
            "вид на жительство",
            "удостоверение беженца",
            "временное удостоверение личности гражданина РФ",
            "общегражданский заграничный паспорт",
            "военный билет офицера запаса",
            "свидетельство о предоставлении временного убежища"});
            this.Docum.Location = new System.Drawing.Point(4, 20);
            this.Docum.MaxDropDownItems = 14;
            this.Docum.Name = "Docum";
            this.Docum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Docum.Size = new System.Drawing.Size(303, 21);
            this.Docum.TabIndex = 95;
            this.Docum.Tag = "T";
            this.Docum.DropDown += new System.EventHandler(this.Docum_DropDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 16);
            this.label15.TabIndex = 102;
            this.label15.Text = "Код подразделения*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(154, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 103;
            this.label12.Text = "Номер док-та*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(154, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 104;
            this.label14.Text = "Кем выдан док-т*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 105;
            this.label11.Text = "Серия док-та*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(2, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 106;
            this.label7.Text = "Вид док-та*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 16);
            this.label13.TabIndex = 101;
            this.label13.Text = "Дата выдачи док-та*";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(160, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 35);
            this.button1.TabIndex = 107;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(230, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 108;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DateTime2
            // 
            this.DateTime2.BackColor = System.Drawing.SystemColors.Window;
            this.DateTime2.BeepOnError = true;
            this.DateTime2.CueText = "Дата выдачи";
            this.DateTime2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DateTime2.HideSelection = false;
            this.DateTime2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.DateTime2.Location = new System.Drawing.Point(5, 110);
            this.DateTime2.Mask = "00/00/0000";
            this.DateTime2.Name = "DateTime2";
            this.DateTime2.RegEx = "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\\d\\d";
            this.DateTime2.Required = false;
            this.DateTime2.ResetOnSpace = false;
            this.DateTime2.Size = new System.Drawing.Size(150, 20);
            this.DateTime2.TabIndex = 98;
            this.DateTime2.Tag = "Дата выдачи документа";
            this.DateTime2.Text = "01012020";
            this.DateTime2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.DateTime2.ValidatingType = typeof(System.DateTime);
            // 
            // Docum_Cod
            // 
            this.Docum_Cod.BackColor = System.Drawing.SystemColors.Window;
            this.Docum_Cod.BeepOnError = true;
            this.Docum_Cod.CueText = "000-000";
            this.Docum_Cod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Docum_Cod.HidePromptOnLeave = true;
            this.Docum_Cod.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Docum_Cod.Location = new System.Drawing.Point(4, 152);
            this.Docum_Cod.Mask = "000-000";
            this.Docum_Cod.Name = "Docum_Cod";
            this.Docum_Cod.PromptChar = ' ';
            this.Docum_Cod.RegEx = "(\\s*(\\S)\\s*){6}";
            this.Docum_Cod.Required = false;
            this.Docum_Cod.ResetOnSpace = false;
            this.Docum_Cod.Size = new System.Drawing.Size(150, 20);
            this.Docum_Cod.TabIndex = 100;
            this.Docum_Cod.Tag = "Код подразделения";
            this.Docum_Cod.Text = "123456";
            this.Docum_Cod.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Docum_Place
            // 
            this.Docum_Place.BackColor = System.Drawing.SystemColors.Window;
            this.Docum_Place.BeepOnError = true;
            this.Docum_Place.CueText = "УФМС гБирск";
            this.Docum_Place.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Docum_Place.HidePromptOnLeave = true;
            this.Docum_Place.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Docum_Place.Location = new System.Drawing.Point(157, 110);
            this.Docum_Place.Name = "Docum_Place";
            this.Docum_Place.PromptChar = ' ';
            this.Docum_Place.RegEx = "^[а-яА-Я\\. ]+$";
            this.Docum_Place.Required = false;
            this.Docum_Place.Size = new System.Drawing.Size(150, 20);
            this.Docum_Place.TabIndex = 99;
            this.Docum_Place.Tag = "Кем выдан документ";
            this.Docum_Place.Text = "мной";
            // 
            // Docum_Num
            // 
            this.Docum_Num.BackColor = System.Drawing.SystemColors.Window;
            this.Docum_Num.BeepOnError = true;
            this.Docum_Num.CueText = "000000";
            this.Docum_Num.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Docum_Num.HidePromptOnLeave = true;
            this.Docum_Num.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Docum_Num.Location = new System.Drawing.Point(157, 64);
            this.Docum_Num.Mask = "000000";
            this.Docum_Num.Name = "Docum_Num";
            this.Docum_Num.PromptChar = ' ';
            this.Docum_Num.RegEx = "\\d{6}";
            this.Docum_Num.Required = false;
            this.Docum_Num.Size = new System.Drawing.Size(150, 20);
            this.Docum_Num.TabIndex = 97;
            this.Docum_Num.Tag = "Номер документа";
            this.Docum_Num.Text = "111111";
            // 
            // Docum_Serial
            // 
            this.Docum_Serial.BackColor = System.Drawing.SystemColors.Window;
            this.Docum_Serial.BeepOnError = true;
            this.Docum_Serial.CueText = "0000";
            this.Docum_Serial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Docum_Serial.HidePromptOnLeave = true;
            this.Docum_Serial.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Docum_Serial.Location = new System.Drawing.Point(4, 64);
            this.Docum_Serial.Mask = "0000";
            this.Docum_Serial.Name = "Docum_Serial";
            this.Docum_Serial.PromptChar = ' ';
            this.Docum_Serial.RegEx = "\\d{4}";
            this.Docum_Serial.Required = false;
            this.Docum_Serial.Size = new System.Drawing.Size(150, 20);
            this.Docum_Serial.TabIndex = 96;
            this.Docum_Serial.Tag = "Серия документа";
            this.Docum_Serial.Text = "1111";
            // 
            // FormDocumPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(310, 176);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTime2);
            this.Controls.Add(this.Docum_Cod);
            this.Controls.Add(this.Docum_Place);
            this.Controls.Add(this.Docum_Num);
            this.Controls.Add(this.Docum_Serial);
            this.Controls.Add(this.Docum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Name = "FormDocumPick";
            this.Text = "Ввод документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CueTextBox DateTime2;
        public CueTextBox Docum_Cod;
        public CueTextBox Docum_Place;
        public CueTextBox Docum_Num;
        public CueTextBox Docum_Serial;
        public System.Windows.Forms.ComboBox Docum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}