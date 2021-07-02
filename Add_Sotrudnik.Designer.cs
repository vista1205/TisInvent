namespace InvetPerspectiva
{
    partial class Add_Sotrudnik
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
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.invetPerspectivaDataSet = new InvetPerspectiva.InvetPerspectivaDataSet();
            this.invetPerspectivaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.состяниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.состяниеTableAdapter = new InvetPerspectiva.InvetPerspectivaDataSetTableAdapters.СостяниеTableAdapter();
            this.кабинетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кабинетTableAdapter = new InvetPerspectiva.InvetPerspectivaDataSetTableAdapters.КабинетTableAdapter();
            this.sotrudnikTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.invetPerspectivaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetPerspectivaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.состяниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кабинетBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonNo
            // 
            this.ButtonNo.Location = new System.Drawing.Point(128, 76);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(75, 23);
            this.ButtonNo.TabIndex = 22;
            this.ButtonNo.Text = "Отмена";
            this.ButtonNo.UseVisualStyleBackColor = true;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(31, 76);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 21;
            this.ButtonOk.Text = "Добавить";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // invetPerspectivaDataSet
            // 
            this.invetPerspectivaDataSet.DataSetName = "InvetPerspectivaDataSet";
            this.invetPerspectivaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invetPerspectivaDataSetBindingSource
            // 
            this.invetPerspectivaDataSetBindingSource.DataSource = this.invetPerspectivaDataSet;
            this.invetPerspectivaDataSetBindingSource.Position = 0;
            // 
            // состяниеBindingSource
            // 
            this.состяниеBindingSource.DataMember = "Состяние";
            this.состяниеBindingSource.DataSource = this.invetPerspectivaDataSetBindingSource;
            // 
            // состяниеTableAdapter
            // 
            this.состяниеTableAdapter.ClearBeforeFill = true;
            // 
            // кабинетBindingSource
            // 
            this.кабинетBindingSource.DataMember = "Кабинет";
            this.кабинетBindingSource.DataSource = this.invetPerspectivaDataSetBindingSource;
            // 
            // кабинетTableAdapter
            // 
            this.кабинетTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikTextBox
            // 
            this.sotrudnikTextBox.Location = new System.Drawing.Point(47, 35);
            this.sotrudnikTextBox.Name = "sotrudnikTextBox";
            this.sotrudnikTextBox.Size = new System.Drawing.Size(138, 20);
            this.sotrudnikTextBox.TabIndex = 23;
            // 
            // Add_Sotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 118);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.sotrudnikTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Add_Sotrudnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.invetPerspectivaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetPerspectivaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.состяниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кабинетBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ButtonNo;
        public System.Windows.Forms.Button ButtonOk;
        private InvetPerspectivaDataSet invetPerspectivaDataSet;
        private System.Windows.Forms.BindingSource invetPerspectivaDataSetBindingSource;
        private System.Windows.Forms.BindingSource состяниеBindingSource;
        private InvetPerspectivaDataSetTableAdapters.СостяниеTableAdapter состяниеTableAdapter;
        private System.Windows.Forms.BindingSource кабинетBindingSource;
        private InvetPerspectivaDataSetTableAdapters.КабинетTableAdapter кабинетTableAdapter;
        public System.Windows.Forms.TextBox sotrudnikTextBox;
    }
}