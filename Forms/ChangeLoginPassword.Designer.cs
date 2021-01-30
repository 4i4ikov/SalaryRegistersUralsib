
namespace SalaryRegistersUralsib.Forms
{
    partial class ChangeLoginPassword
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
            if ( disposing && ( components != null ) )
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.NewPasswordInput = new SalaryRegistersUralsib.CueTextBox();
            this.OldPasswordInput = new SalaryRegistersUralsib.CueTextBox();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(359, 20);
            this.MainLabel.TabIndex = 16;
            this.MainLabel.Text = "Для смены пароля введите старый и новый пароли";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePassword
            // 
            this.ChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePassword.AutoEllipsis = true;
            this.ChangePassword.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassword.Location = new System.Drawing.Point(12, 139);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(335, 26);
            this.ChangePassword.TabIndex = 3;
            this.ChangePassword.Text = "Сменить пароль";
            this.ChangePassword.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 83);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(118, 20);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Новый пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(12, 31);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(126, 20);
            this.LoginLabel.TabIndex = 12;
            this.LoginLabel.Text = "Старый пароль";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewPasswordInput
            // 
            this.NewPasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordInput.CueText = null;
            this.NewPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordInput.Location = new System.Drawing.Point(12, 107);
            this.NewPasswordInput.Name = "NewPasswordInput";
            this.NewPasswordInput.PasswordChar = '*';
            this.NewPasswordInput.RegEx = null;
            this.NewPasswordInput.Required = false;
            this.NewPasswordInput.Size = new System.Drawing.Size(335, 26);
            this.NewPasswordInput.TabIndex = 2;
            // 
            // OldPasswordInput
            // 
            this.OldPasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPasswordInput.CueText = null;
            this.OldPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPasswordInput.Location = new System.Drawing.Point(12, 54);
            this.OldPasswordInput.Name = "OldPasswordInput";
            this.OldPasswordInput.RegEx = null;
            this.OldPasswordInput.Required = false;
            this.OldPasswordInput.Size = new System.Drawing.Size(335, 26);
            this.OldPasswordInput.TabIndex = 1;
            // 
            // ChangeLoginPassword
            // 
            this.AcceptButton = this.ChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 168);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.NewPasswordInput);
            this.Controls.Add(this.OldPasswordInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeLoginPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        internal CueTextBox NewPasswordInput;
        internal CueTextBox OldPasswordInput;
    }
}