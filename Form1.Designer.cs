namespace InvetPerspectiva
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инвентаризацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Button_technika = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DelButton = new System.Windows.Forms.Button();
            this.View_Button_Status = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.View_Button_Kabinet = new System.Windows.Forms.Button();
            this.Model_Button = new System.Windows.Forms.Button();
            this.SotrudnikiButton = new System.Windows.Forms.Button();
            this.Type_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Add_Job_Button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.del_otherButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(994, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Тип техники",
            "Модель",
            "Сотрудник",
            "Работы",
            "Состояние",
            "Кабинет",
            "Дата"});
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Items.AddRange(new object[] {
            "Инвентарный номер",
            "Тип техники",
            "Модель",
            "Сотрудник",
            "Состояние",
            "Кабинет"});
            this.SearchBox.Location = new System.Drawing.Point(4, 39);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(142, 21);
            this.SearchBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Параметр";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(4, 88);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(142, 20);
            this.SearchText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Значение";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1012, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инвентаризацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // инвентаризацияToolStripMenuItem
            // 
            this.инвентаризацияToolStripMenuItem.Name = "инвентаризацияToolStripMenuItem";
            this.инвентаризацияToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.инвентаризацияToolStripMenuItem.Text = "Инвентаризация";
            // 
            // Add_Button_technika
            // 
            this.Add_Button_technika.Location = new System.Drawing.Point(7, 19);
            this.Add_Button_technika.Name = "Add_Button_technika";
            this.Add_Button_technika.Size = new System.Drawing.Size(127, 23);
            this.Add_Button_technika.TabIndex = 8;
            this.Add_Button_technika.Text = "Добавить/изменить";
            this.Add_Button_technika.UseVisualStyleBackColor = true;
            this.Add_Button_technika.Click += new System.EventHandler(this.Add_Button_technika_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 317);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(994, 223);
            this.dataGridView2.TabIndex = 9;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(6, 77);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(127, 23);
            this.DelButton.TabIndex = 10;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // View_Button_Status
            // 
            this.View_Button_Status.Location = new System.Drawing.Point(10, 42);
            this.View_Button_Status.Name = "View_Button_Status";
            this.View_Button_Status.Size = new System.Drawing.Size(127, 23);
            this.View_Button_Status.TabIndex = 11;
            this.View_Button_Status.Text = "Состояние";
            this.View_Button_Status.UseVisualStyleBackColor = true;
            this.View_Button_Status.Click += new System.EventHandler(this.View_Button_Status_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(12, 19);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(127, 23);
            this.Add_Button.TabIndex = 12;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // View_Button_Kabinet
            // 
            this.View_Button_Kabinet.Location = new System.Drawing.Point(10, 17);
            this.View_Button_Kabinet.Name = "View_Button_Kabinet";
            this.View_Button_Kabinet.Size = new System.Drawing.Size(127, 23);
            this.View_Button_Kabinet.TabIndex = 13;
            this.View_Button_Kabinet.Text = "Кабинет";
            this.View_Button_Kabinet.UseVisualStyleBackColor = true;
            this.View_Button_Kabinet.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Model_Button
            // 
            this.Model_Button.Location = new System.Drawing.Point(10, 94);
            this.Model_Button.Name = "Model_Button";
            this.Model_Button.Size = new System.Drawing.Size(127, 23);
            this.Model_Button.TabIndex = 14;
            this.Model_Button.Text = "Модель";
            this.Model_Button.UseVisualStyleBackColor = true;
            this.Model_Button.Click += new System.EventHandler(this.Model_Button_Click);
            // 
            // SotrudnikiButton
            // 
            this.SotrudnikiButton.Location = new System.Drawing.Point(10, 68);
            this.SotrudnikiButton.Name = "SotrudnikiButton";
            this.SotrudnikiButton.Size = new System.Drawing.Size(127, 23);
            this.SotrudnikiButton.TabIndex = 15;
            this.SotrudnikiButton.Text = "Сотрудники";
            this.SotrudnikiButton.UseVisualStyleBackColor = true;
            this.SotrudnikiButton.Click += new System.EventHandler(this.SotrudnikiButton_Click);
            // 
            // Type_Button
            // 
            this.Type_Button.Location = new System.Drawing.Point(10, 120);
            this.Type_Button.Name = "Type_Button";
            this.Type_Button.Size = new System.Drawing.Size(127, 23);
            this.Type_Button.TabIndex = 16;
            this.Type_Button.Text = "Тип техники";
            this.Type_Button.UseVisualStyleBackColor = true;
            this.Type_Button.Click += new System.EventHandler(this.Type_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Add_Job_Button);
            this.groupBox2.Controls.Add(this.DelButton);
            this.groupBox2.Controls.Add(this.Add_Button_technika);
            this.groupBox2.Location = new System.Drawing.Point(1013, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 105);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Техника";
            // 
            // Add_Job_Button
            // 
            this.Add_Job_Button.Location = new System.Drawing.Point(7, 48);
            this.Add_Job_Button.Name = "Add_Job_Button";
            this.Add_Job_Button.Size = new System.Drawing.Size(127, 23);
            this.Add_Job_Button.TabIndex = 11;
            this.Add_Job_Button.Text = "Работа";
            this.Add_Job_Button.UseVisualStyleBackColor = true;
            this.Add_Job_Button.Click += new System.EventHandler(this.Add_Job_Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Type_Button);
            this.groupBox3.Controls.Add(this.SotrudnikiButton);
            this.groupBox3.Controls.Add(this.Model_Button);
            this.groupBox3.Controls.Add(this.View_Button_Kabinet);
            this.groupBox3.Controls.Add(this.View_Button_Status);
            this.groupBox3.Location = new System.Drawing.Point(1013, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 151);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Просмотр";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.del_otherButton);
            this.groupBox4.Controls.Add(this.Add_Button);
            this.groupBox4.Location = new System.Drawing.Point(1012, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 74);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Команды";
            // 
            // del_otherButton
            // 
            this.del_otherButton.Location = new System.Drawing.Point(12, 45);
            this.del_otherButton.Name = "del_otherButton";
            this.del_otherButton.Size = new System.Drawing.Size(127, 23);
            this.del_otherButton.TabIndex = 13;
            this.del_otherButton.Text = "Удалить";
            this.del_otherButton.UseVisualStyleBackColor = true;
            this.del_otherButton.Click += new System.EventHandler(this.del_otherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 557);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem инвентаризацияToolStripMenuItem;
        private System.Windows.Forms.Button Add_Button_technika;
        private System.Windows.Forms.Button DelButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View_Button_Status;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button View_Button_Kabinet;
        private System.Windows.Forms.Button Model_Button;
        private System.Windows.Forms.Button SotrudnikiButton;
        private System.Windows.Forms.Button Type_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Add_Job_Button;
        private System.Windows.Forms.Button del_otherButton;
        public System.Windows.Forms.DataGridView dataGridView2;
    }
}

