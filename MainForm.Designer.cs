namespace pressF
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.зарплатныйПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зарплатныйПроектToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зарплатныйПроектToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.MenuStrip1_MenuActivate);
            // 
            // зарплатныйПроектToolStripMenuItem
            // 
            this.зарплатныйПроектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.зарплатныйПроектToolStripMenuItem1,
            this.платежиToolStripMenuItem,
            this.toolStripSeparator1,
            this.закрытьВсёToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.зарплатныйПроектToolStripMenuItem.Name = "зарплатныйПроектToolStripMenuItem";
            this.зарплатныйПроектToolStripMenuItem.Size = new System.Drawing.Size(27, 20);
            this.зарплатныйПроектToolStripMenuItem.Text = "|||";
            this.зарплатныйПроектToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripComboBox1.DoubleClickEnabled = true;
            this.toolStripComboBox1.Enabled = false;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(183, 22);
            this.toolStripComboBox1.Text = "Выберите";
            // 
            // зарплатныйПроектToolStripMenuItem1
            // 
            this.зарплатныйПроектToolStripMenuItem1.Name = "зарплатныйПроектToolStripMenuItem1";
            this.зарплатныйПроектToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.зарплатныйПроектToolStripMenuItem1.Text = "Зарплатный проект";
            this.зарплатныйПроектToolStripMenuItem1.Click += new System.EventHandler(this.ЗарплатныйПроектToolStripMenuItem1_Click);
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.платежиToolStripMenuItem.Text = "Платежи";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // закрытьВсёToolStripMenuItem
            // 
            this.закрытьВсёToolStripMenuItem.Name = "закрытьВсёToolStripMenuItem";
            this.закрытьВсёToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.закрытьВсёToolStripMenuItem.Text = "Закрыть всё";
            this.закрытьВсёToolStripMenuItem.Click += new System.EventHandler(this.ЗакрытьВсёToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.debugToolStripMenuItem.Text = "debuggin";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кликните по меню для начала работы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Бухгалтерия";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem зарплатныйПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарплатныйПроектToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
    }
}