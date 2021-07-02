namespace InvetPerspectiva
{
    partial class Edit_Tehnika
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
            this.kabinetComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.invetPerspectivaDataSet = new InvetPerspectiva.InvetPerspectivaDataSet();
            this.кабинетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кабинетTableAdapter = new InvetPerspectiva.InvetPerspectivaDataSetTableAdapters.КабинетTableAdapter();
            this.модельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.модельTableAdapter = new InvetPerspectiva.InvetPerspectivaDataSetTableAdapters.МодельTableAdapter();
            this.состяниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.состяниеTableAdapter = new InvetPerspectiva.InvetPerspectivaDataSetTableAdapters.СостяниеTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invetPerspectivaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кабинетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.модельBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.состяниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kabinetComboBox
            // 
            this.kabinetComboBox.DataSource = this.кабинетBindingSource;
            this.kabinetComboBox.DisplayMember = "Номер кабинета";
            this.kabinetComboBox.FormattingEnabled = true;
            this.kabinetComboBox.Location = new System.Drawing.Point(98, 31);
            this.kabinetComboBox.Name = "kabinetComboBox";
            this.kabinetComboBox.Size = new System.Drawing.Size(121, 21);
            this.kabinetComboBox.TabIndex = 0;
            // 
            // modelComboBox
            // 
            this.modelComboBox.DataSource = this.модельBindingSource;
            this.modelComboBox.DisplayMember = "Название модели";
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(98, 58);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(121, 21);
            this.modelComboBox.TabIndex = 1;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataSource = this.состяниеBindingSource;
            this.statusComboBox.DisplayMember = "Название состояния";
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(98, 85);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 2;
            // 
            // invetPerspectivaDataSet
            // 
            this.invetPerspectivaDataSet.DataSetName = "InvetPerspectivaDataSet";
            this.invetPerspectivaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кабинетBindingSource
            // 
            this.кабинетBindingSource.DataMember = "Кабинет";
            this.кабинетBindingSource.DataSource = this.invetPerspectivaDataSet;
            // 
            // кабинетTableAdapter
            // 
            this.кабинетTableAdapter.ClearBeforeFill = true;
            // 
            // модельBindingSource
            // 
            this.модельBindingSource.DataMember = "Модель";
            this.модельBindingSource.DataSource = this.invetPerspectivaDataSet;
            // 
            // модельTableAdapter
            // 
            this.модельTableAdapter.ClearBeforeFill = true;
            // 
            // состяниеBindingSource
            // 
            this.состяниеBindingSource.DataMember = "Состяние";
            this.состяниеBindingSource.DataSource = this.invetPerspectivaDataSet;
            // 
            // состяниеTableAdapter
            // 
            this.состяниеTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edit_Tehnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.kabinetComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Edit_Tehnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование техники";
            this.Load += new System.EventHandler(this.Edit_Tehnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invetPerspectivaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кабинетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.модельBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.состяниеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox kabinetComboBox;
        public System.Windows.Forms.ComboBox modelComboBox;
        public System.Windows.Forms.ComboBox statusComboBox;
        private InvetPerspectivaDataSet invetPerspectivaDataSet;
        private System.Windows.Forms.BindingSource кабинетBindingSource;
        private InvetPerspectivaDataSetTableAdapters.КабинетTableAdapter кабинетTableAdapter;
        private System.Windows.Forms.BindingSource модельBindingSource;
        private InvetPerspectivaDataSetTableAdapters.МодельTableAdapter модельTableAdapter;
        private System.Windows.Forms.BindingSource состяниеBindingSource;
        private InvetPerspectivaDataSetTableAdapters.СостяниеTableAdapter состяниеTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}