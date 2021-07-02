namespace InvetPerspectiva
{
    partial class Del_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.NameType = new System.Windows.Forms.Label();
            this.NameModel = new System.Windows.Forms.Label();
            this.Invent = new System.Windows.Forms.Label();
            this.Kabinet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите удалить данное оборудование из списка?";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(12, 109);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "Да";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NoButton.Location = new System.Drawing.Point(187, 109);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "Отмена";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // NameType
            // 
            this.NameType.AutoSize = true;
            this.NameType.Location = new System.Drawing.Point(131, 39);
            this.NameType.Name = "NameType";
            this.NameType.Size = new System.Drawing.Size(31, 13);
            this.NameType.TabIndex = 3;
            this.NameType.Text = "Type";
            // 
            // NameModel
            // 
            this.NameModel.AutoSize = true;
            this.NameModel.Location = new System.Drawing.Point(132, 56);
            this.NameModel.Name = "NameModel";
            this.NameModel.Size = new System.Drawing.Size(36, 13);
            this.NameModel.TabIndex = 4;
            this.NameModel.Text = "Model";
            // 
            // Invent
            // 
            this.Invent.AutoSize = true;
            this.Invent.Location = new System.Drawing.Point(132, 69);
            this.Invent.Name = "Invent";
            this.Invent.Size = new System.Drawing.Size(44, 13);
            this.Invent.TabIndex = 5;
            this.Invent.Text = "Invent#";
            // 
            // Kabinet
            // 
            this.Kabinet.AutoSize = true;
            this.Kabinet.Location = new System.Drawing.Point(132, 82);
            this.Kabinet.Name = "Kabinet";
            this.Kabinet.Size = new System.Drawing.Size(43, 13);
            this.Kabinet.TabIndex = 6;
            this.Kabinet.Text = "Kabinet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип техники:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Модель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Инвентарный номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кабинет:";
            // 
            // Del_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 140);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kabinet);
            this.Controls.Add(this.Invent);
            this.Controls.Add(this.NameModel);
            this.Controls.Add(this.NameType);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Del_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление оборудования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.Button NoButton;
        public System.Windows.Forms.Label NameType;
        public System.Windows.Forms.Label NameModel;
        public System.Windows.Forms.Label Invent;
        public System.Windows.Forms.Label Kabinet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}