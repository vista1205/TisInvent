namespace InvetPerspectiva
{
    partial class Add_Technika_Form
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
            this.dataGridViewTehnika = new System.Windows.Forms.DataGridView();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.dataGridViewType_tehnika = new System.Windows.Forms.DataGridView();
            this.dataGridViewModel = new System.Windows.Forms.DataGridView();
            this.dataGridViewSotrudniki = new System.Windows.Forms.DataGridView();
            this.dataGridViewStatus = new System.Windows.Forms.DataGridView();
            this.модельTableAdapter1 = new InvetPerspectiva.InvetPerspectivaDataSetTableAdapters.МодельTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.replace_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewKabinet = new System.Windows.Forms.DataGridView();
            this.replace_kabinet_button = new System.Windows.Forms.Button();
            this.replace_model_button = new System.Windows.Forms.Button();
            this.replace_type_button = new System.Windows.Forms.Button();
            this.replace_invent_button = new System.Windows.Forms.Button();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.commandGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTehnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType_tehnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotrudniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKabinet)).BeginInit();
            this.editGroupBox.SuspendLayout();
            this.commandGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTehnika
            // 
            this.dataGridViewTehnika.AllowUserToAddRows = false;
            this.dataGridViewTehnika.AllowUserToDeleteRows = false;
            this.dataGridViewTehnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTehnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTehnika.Location = new System.Drawing.Point(12, 105);
            this.dataGridViewTehnika.MultiSelect = false;
            this.dataGridViewTehnika.Name = "dataGridViewTehnika";
            this.dataGridViewTehnika.Size = new System.Drawing.Size(1012, 187);
            this.dataGridViewTehnika.TabIndex = 1;
            // 
            // Add_Button
            // 
            this.Add_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add_Button.Location = new System.Drawing.Point(20, 32);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(121, 23);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(20, 61);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(121, 23);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // dataGridViewType_tehnika
            // 
            this.dataGridViewType_tehnika.AllowUserToAddRows = false;
            this.dataGridViewType_tehnika.AllowUserToDeleteRows = false;
            this.dataGridViewType_tehnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewType_tehnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType_tehnika.Location = new System.Drawing.Point(559, 298);
            this.dataGridViewType_tehnika.MultiSelect = false;
            this.dataGridViewType_tehnika.Name = "dataGridViewType_tehnika";
            this.dataGridViewType_tehnika.Size = new System.Drawing.Size(223, 246);
            this.dataGridViewType_tehnika.TabIndex = 4;
            this.dataGridViewType_tehnika.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewType_tehnika_CellEnter);
            // 
            // dataGridViewModel
            // 
            this.dataGridViewModel.AllowUserToAddRows = false;
            this.dataGridViewModel.AllowUserToDeleteRows = false;
            this.dataGridViewModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModel.Location = new System.Drawing.Point(788, 298);
            this.dataGridViewModel.MultiSelect = false;
            this.dataGridViewModel.Name = "dataGridViewModel";
            this.dataGridViewModel.Size = new System.Drawing.Size(236, 246);
            this.dataGridViewModel.TabIndex = 5;
            this.dataGridViewModel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModel_CellEnter);
            // 
            // dataGridViewSotrudniki
            // 
            this.dataGridViewSotrudniki.AllowUserToAddRows = false;
            this.dataGridViewSotrudniki.AllowUserToDeleteRows = false;
            this.dataGridViewSotrudniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSotrudniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSotrudniki.Location = new System.Drawing.Point(12, 298);
            this.dataGridViewSotrudniki.MultiSelect = false;
            this.dataGridViewSotrudniki.Name = "dataGridViewSotrudniki";
            this.dataGridViewSotrudniki.Size = new System.Drawing.Size(303, 120);
            this.dataGridViewSotrudniki.TabIndex = 6;
            this.dataGridViewSotrudniki.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSotrudniki_CellEnter);
            // 
            // dataGridViewStatus
            // 
            this.dataGridViewStatus.AllowUserToAddRows = false;
            this.dataGridViewStatus.AllowUserToDeleteRows = false;
            this.dataGridViewStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatus.Location = new System.Drawing.Point(12, 424);
            this.dataGridViewStatus.MultiSelect = false;
            this.dataGridViewStatus.Name = "dataGridViewStatus";
            this.dataGridViewStatus.Size = new System.Drawing.Size(303, 120);
            this.dataGridViewStatus.TabIndex = 8;
            this.dataGridViewStatus.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStatus_CellEnter);
            // 
            // модельTableAdapter1
            // 
            this.модельTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // replace_button
            // 
            this.replace_button.Location = new System.Drawing.Point(20, 31);
            this.replace_button.Name = "replace_button";
            this.replace_button.Size = new System.Drawing.Size(121, 23);
            this.replace_button.TabIndex = 14;
            this.replace_button.Text = "Изменить Статус";
            this.replace_button.UseVisualStyleBackColor = true;
            this.replace_button.Click += new System.EventHandler(this.replace_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Инвентарный номер";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Серийный номер";
            // 
            // dataGridViewKabinet
            // 
            this.dataGridViewKabinet.AllowUserToAddRows = false;
            this.dataGridViewKabinet.AllowUserToDeleteRows = false;
            this.dataGridViewKabinet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKabinet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKabinet.Location = new System.Drawing.Point(321, 298);
            this.dataGridViewKabinet.MultiSelect = false;
            this.dataGridViewKabinet.Name = "dataGridViewKabinet";
            this.dataGridViewKabinet.Size = new System.Drawing.Size(232, 246);
            this.dataGridViewKabinet.TabIndex = 19;
            this.dataGridViewKabinet.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKabinet_CellEnter);
            // 
            // replace_kabinet_button
            // 
            this.replace_kabinet_button.Location = new System.Drawing.Point(20, 60);
            this.replace_kabinet_button.Name = "replace_kabinet_button";
            this.replace_kabinet_button.Size = new System.Drawing.Size(121, 23);
            this.replace_kabinet_button.TabIndex = 21;
            this.replace_kabinet_button.Text = "Изменить Кабинет";
            this.replace_kabinet_button.UseVisualStyleBackColor = true;
            this.replace_kabinet_button.Click += new System.EventHandler(this.replace_kabinet_button_Click);
            // 
            // replace_model_button
            // 
            this.replace_model_button.Location = new System.Drawing.Point(20, 89);
            this.replace_model_button.Name = "replace_model_button";
            this.replace_model_button.Size = new System.Drawing.Size(121, 23);
            this.replace_model_button.TabIndex = 22;
            this.replace_model_button.Text = "Изменить Модель";
            this.replace_model_button.UseVisualStyleBackColor = true;
            this.replace_model_button.Click += new System.EventHandler(this.replace_model_button_Click);
            // 
            // replace_type_button
            // 
            this.replace_type_button.Location = new System.Drawing.Point(20, 117);
            this.replace_type_button.Name = "replace_type_button";
            this.replace_type_button.Size = new System.Drawing.Size(121, 23);
            this.replace_type_button.TabIndex = 23;
            this.replace_type_button.Text = "Изменить Тип";
            this.replace_type_button.UseVisualStyleBackColor = true;
            this.replace_type_button.Click += new System.EventHandler(this.replace_type_button_Click);
            // 
            // replace_invent_button
            // 
            this.replace_invent_button.Location = new System.Drawing.Point(20, 146);
            this.replace_invent_button.Name = "replace_invent_button";
            this.replace_invent_button.Size = new System.Drawing.Size(121, 23);
            this.replace_invent_button.TabIndex = 24;
            this.replace_invent_button.Text = "Инвентраный номер";
            this.replace_invent_button.UseVisualStyleBackColor = true;
            this.replace_invent_button.Click += new System.EventHandler(this.replace_invent_button_Click);
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.replace_button);
            this.editGroupBox.Controls.Add(this.replace_invent_button);
            this.editGroupBox.Controls.Add(this.replace_kabinet_button);
            this.editGroupBox.Controls.Add(this.replace_type_button);
            this.editGroupBox.Controls.Add(this.replace_model_button);
            this.editGroupBox.Location = new System.Drawing.Point(1030, 13);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(166, 178);
            this.editGroupBox.TabIndex = 25;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Изменить";
            // 
            // commandGroupBox
            // 
            this.commandGroupBox.Controls.Add(this.Cancel_Button);
            this.commandGroupBox.Controls.Add(this.Add_Button);
            this.commandGroupBox.Location = new System.Drawing.Point(1030, 208);
            this.commandGroupBox.Name = "commandGroupBox";
            this.commandGroupBox.Size = new System.Drawing.Size(166, 110);
            this.commandGroupBox.TabIndex = 26;
            this.commandGroupBox.TabStop = false;
            this.commandGroupBox.Text = "Команды";
            // 
            // Add_Technika_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 593);
            this.ControlBox = false;
            this.Controls.Add(this.commandGroupBox);
            this.Controls.Add(this.editGroupBox);
            this.Controls.Add(this.dataGridViewKabinet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStatus);
            this.Controls.Add(this.dataGridViewSotrudniki);
            this.Controls.Add(this.dataGridViewModel);
            this.Controls.Add(this.dataGridViewType_tehnika);
            this.Controls.Add(this.dataGridViewTehnika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Add_Technika_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/изменение техники";
            this.Load += new System.EventHandler(this.Add_Technika_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTehnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType_tehnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotrudniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKabinet)).EndInit();
            this.editGroupBox.ResumeLayout(false);
            this.commandGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Add_Button;
        public System.Windows.Forms.Button Cancel_Button;
        private InvetPerspectivaDataSetTableAdapters.МодельTableAdapter модельTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridViewSotrudniki;
        public System.Windows.Forms.Button replace_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dataGridViewTehnika;
        public System.Windows.Forms.DataGridView dataGridViewType_tehnika;
        public System.Windows.Forms.DataGridView dataGridViewModel;
        public System.Windows.Forms.DataGridView dataGridViewStatus;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.DataGridView dataGridViewKabinet;
        public System.Windows.Forms.Button replace_kabinet_button;
        public System.Windows.Forms.Button replace_model_button;
        public System.Windows.Forms.Button replace_type_button;
        public System.Windows.Forms.Button replace_invent_button;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.GroupBox commandGroupBox;
    }
}