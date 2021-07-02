namespace InvetPerspectiva
{
    partial class Add_Type
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
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.add_typeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonNo
            // 
            this.ButtonNo.Location = new System.Drawing.Point(116, 68);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(75, 23);
            this.ButtonNo.TabIndex = 25;
            this.ButtonNo.Text = "Отмена";
            this.ButtonNo.UseVisualStyleBackColor = true;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(19, 68);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 24;
            this.ButtonOk.Text = "Добавить";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // add_typeTextBox
            // 
            this.add_typeTextBox.Location = new System.Drawing.Point(35, 27);
            this.add_typeTextBox.Name = "add_typeTextBox";
            this.add_typeTextBox.Size = new System.Drawing.Size(138, 20);
            this.add_typeTextBox.TabIndex = 26;
            // 
            // Add_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 118);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.add_typeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Add_Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление типа техники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ButtonNo;
        public System.Windows.Forms.Button ButtonOk;
        public System.Windows.Forms.TextBox add_typeTextBox;
    }
}