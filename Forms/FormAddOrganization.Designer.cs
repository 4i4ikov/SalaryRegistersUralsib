namespace SalaryRegistersUralsib
{
    partial class FormAddOrganization
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new SalaryRegistersUralsib.CueTextBox();
            this.textBox2 = new SalaryRegistersUralsib.CueTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new SalaryRegistersUralsib.CueTextBox();
            this.textBox4 = new SalaryRegistersUralsib.CueTextBox();
            this.textBox1 = new SalaryRegistersUralsib.CueTextBox();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(331, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Главный бухгалтер";
            this.toolTip1.SetToolTip(this.label6, "Бухгалтеррр");
            // 
            // textBox6
            // 
            this.textBox6.CueText = null;
            this.textBox6.Location = new System.Drawing.Point(335, 158);
            this.textBox6.Name = "textBox6";
            this.textBox6.RegEx = "^[а-яА-Я ]+$";
            this.textBox6.Required = false;
            this.textBox6.Size = new System.Drawing.Size(270, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Tag = "Главный бухгалтер";
            this.toolTip1.SetToolTip(this.textBox6, "Главный бухгалтер");
            // 
            // textBox2
            // 
            this.textBox2.CueText = "4 английских буквы";
            this.textBox2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBox2.Location = new System.Drawing.Point(335, 43);
            this.textBox2.Mask = "????";
            this.textBox2.Name = "textBox2";
            this.textBox2.RegEx = "^[A-Z]{4}$";
            this.textBox2.Required = true;
            this.textBox2.Size = new System.Drawing.Size(270, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "Код организации";
            this.toolTip1.SetToolTip(this.textBox2, "ВВЕДИТЕ 4 АНГЛИЙСКИХ БУКВЫ ПОЖАЛУЙСТА, НЕ БОЛЬШЕ НЕ МЕНЬШЕ");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(335, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(43, 20);
            this.checkBox1.TabIndex = 56;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "да";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(163, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(20, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Должность руководителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Руководитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(331, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Дескриптор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(331, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Код организации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Организация";
            // 
            // textBox5
            // 
            this.textBox5.CueText = null;
            this.textBox5.Location = new System.Drawing.Point(20, 158);
            this.textBox5.Name = "textBox5";
            this.textBox5.RegEx = "^[а-яА-Я ]+$";
            this.textBox5.Required = false;
            this.textBox5.Size = new System.Drawing.Size(270, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Tag = "Должность руководителя";
            // 
            // textBox4
            // 
            this.textBox4.CueText = null;
            this.textBox4.Location = new System.Drawing.Point(20, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.RegEx = "^[А-Яа-я ]+$";
            this.textBox4.Required = false;
            this.textBox4.Size = new System.Drawing.Size(270, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Tag = "Руководитель";
            // 
            // textBox1
            // 
            this.textBox1.CueText = "123";
            this.textBox1.HidePromptOnLeave = true;
            this.textBox1.Location = new System.Drawing.Point(20, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.RegEx = "^[A-Za-zА-Яа-я -.]+$";
            this.textBox1.Required = false;
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "Наименование организации";
            // 
            // FormAddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 249);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddOrganization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = " ";
            this.Text = "Добавление организации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddOrganization_FormClosing);
            this.Load += new System.EventHandler(this.FormAddOrganization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public CueTextBox textBox6;
        public CueTextBox textBox5;
        public CueTextBox textBox4;
        public CueTextBox textBox2;
        public CueTextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        
    }
}