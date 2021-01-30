namespace SalaryRegistersUralsib
{
    partial class FormAddWorker
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Table_num = new SalaryRegistersUralsib.CueTextBox();
            this.Bill_Num = new SalaryRegistersUralsib.CueTextBox();
            this.Middlename = new SalaryRegistersUralsib.CueTextBox();
            this.Name_Worker = new SalaryRegistersUralsib.CueTextBox();
            this.BithDate = new SalaryRegistersUralsib.CueTextBox();
            this.Surname = new SalaryRegistersUralsib.CueTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(320, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "Номер счёта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "Дата рождения*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(320, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Имя*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "Фамилия*";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(154, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 35);
            this.button2.TabIndex = 96;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 95;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(164, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 101;
            this.label5.Text = "Табельный номер";
            // 
            // Table_num
            // 
            this.Table_num.BeepOnError = true;
            this.Table_num.CueText = "до 12 символов";
            this.Table_num.HidePromptOnLeave = true;
            this.Table_num.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Table_num.Location = new System.Drawing.Point(167, 72);
            this.Table_num.Mask = "000000000000";
            this.Table_num.Name = "Table_num";
            this.Table_num.PromptChar = ' ';
            this.Table_num.RegEx = "^[0-9]+$";
            this.Table_num.Required = false;
            this.Table_num.Size = new System.Drawing.Size(150, 20);
            this.Table_num.TabIndex = 5;
            this.Table_num.Tag = "Табельный номер";
            // 
            // Bill_Num
            // 
            this.Bill_Num.BeepOnError = true;
            this.Bill_Num.CueText = "20 символов";
            this.Bill_Num.HidePromptOnLeave = true;
            this.Bill_Num.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Bill_Num.Location = new System.Drawing.Point(323, 71);
            this.Bill_Num.Mask = "00000000000000000000";
            this.Bill_Num.Name = "Bill_Num";
            this.Bill_Num.PromptChar = ' ';
            this.Bill_Num.RegEx = "\\d{20}";
            this.Bill_Num.Required = false;
            this.Bill_Num.ResetOnSpace = false;
            this.Bill_Num.Size = new System.Drawing.Size(150, 20);
            this.Bill_Num.TabIndex = 6;
            this.Bill_Num.Tag = "Номер счёта";
            this.Bill_Num.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Middlename
            // 
            this.Middlename.BeepOnError = true;
            this.Middlename.CueText = "Отчество";
            this.Middlename.HidePromptOnLeave = true;
            this.Middlename.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Middlename.Location = new System.Drawing.Point(323, 27);
            this.Middlename.Name = "Middlename";
            this.Middlename.PromptChar = ' ';
            this.Middlename.RegEx = "^[а-яА-Я]+$";
            this.Middlename.Required = false;
            this.Middlename.Size = new System.Drawing.Size(150, 20);
            this.Middlename.TabIndex = 3;
            this.Middlename.Tag = "Отчество";
            // 
            // Name_Worker
            // 
            this.Name_Worker.BackColor = System.Drawing.SystemColors.Window;
            this.Name_Worker.BeepOnError = true;
            this.Name_Worker.CueText = "Имя";
            this.Name_Worker.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name_Worker.HidePromptOnLeave = true;
            this.Name_Worker.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Name_Worker.Location = new System.Drawing.Point(167, 27);
            this.Name_Worker.Name = "Name_Worker";
            this.Name_Worker.PromptChar = ' ';
            this.Name_Worker.RegEx = "^[а-яА-Я]+$";
            this.Name_Worker.Required = true;
            this.Name_Worker.Size = new System.Drawing.Size(150, 20);
            this.Name_Worker.TabIndex = 2;
            this.Name_Worker.Tag = "Имя";
            // 
            // BithDate
            // 
            this.BithDate.BackColor = System.Drawing.SystemColors.Window;
            this.BithDate.BeepOnError = true;
            this.BithDate.CueText = "Дата рождения";
            this.BithDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BithDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.BithDate.Location = new System.Drawing.Point(11, 71);
            this.BithDate.Mask = "00/00/0000";
            this.BithDate.Name = "BithDate";
            this.BithDate.RegEx = "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\\d\\d";
            this.BithDate.Required = true;
            this.BithDate.ResetOnPrompt = false;
            this.BithDate.ResetOnSpace = false;
            this.BithDate.Size = new System.Drawing.Size(150, 20);
            this.BithDate.TabIndex = 4;
            this.BithDate.Tag = "Дата рождения";
            this.BithDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.BithDate.ValidatingType = typeof(System.DateTime);
            // 
            // Surname
            // 
            this.Surname.BackColor = System.Drawing.SystemColors.Window;
            this.Surname.BeepOnError = true;
            this.Surname.CueText = "Фамилия";
            this.Surname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Surname.HidePromptOnLeave = true;
            this.Surname.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Surname.Location = new System.Drawing.Point(11, 27);
            this.Surname.Name = "Surname";
            this.Surname.PromptChar = ' ';
            this.Surname.RegEx = "^[а-яА-Я]+$";
            this.Surname.Required = true;
            this.Surname.ResetOnPrompt = false;
            this.Surname.ResetOnSpace = false;
            this.Surname.Size = new System.Drawing.Size(150, 20);
            this.Surname.TabIndex = 1;
            this.Surname.Tag = "Фамилия";
            // 
            // FormAddWorker
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(483, 149);
            this.ControlBox = false;
            this.Controls.Add(this.Table_num);
            this.Controls.Add(this.Bill_Num);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.Name_Worker);
            this.Controls.Add(this.BithDate);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = " ";
            this.Text = "Добавление Сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddWorker_FormClosing);
            this.Load += new System.EventHandler(this.FormAddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        public CueTextBox Table_num;
        public CueTextBox Bill_Num;
        public CueTextBox Middlename;
        public CueTextBox Name_Worker;
        public CueTextBox Surname;
        public CueTextBox BithDate;
    }
}