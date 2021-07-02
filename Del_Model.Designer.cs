namespace InvetPerspectiva
{
    partial class Del_Model
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
            this.delLabel = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delLabel
            // 
            this.delLabel.AutoSize = true;
            this.delLabel.Location = new System.Drawing.Point(99, 48);
            this.delLabel.Name = "delLabel";
            this.delLabel.Size = new System.Drawing.Size(35, 13);
            this.delLabel.TabIndex = 35;
            this.delLabel.Text = "label2";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(19, 13);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(183, 26);
            this.infolabel.TabIndex = 34;
            this.infolabel.Text = "Вы действительно хотите удалить \r\nданную модель?";
            // 
            // ButtonNo
            // 
            this.ButtonNo.Location = new System.Drawing.Point(127, 82);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(75, 23);
            this.ButtonNo.TabIndex = 33;
            this.ButtonNo.Text = "Отмена";
            this.ButtonNo.UseVisualStyleBackColor = true;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(33, 82);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 32;
            this.ButtonOk.Text = "Удалить";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // Del_Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 118);
            this.ControlBox = false;
            this.Controls.Add(this.delLabel);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Del_Model";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление модели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label delLabel;
        private System.Windows.Forms.Label infolabel;
        public System.Windows.Forms.Button ButtonNo;
        public System.Windows.Forms.Button ButtonOk;
    }
}