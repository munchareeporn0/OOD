namespace bookstore
{
    partial class P_receive
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
            this.head = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.head.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.head.Controls.Add(this.txtName);
            this.head.Location = new System.Drawing.Point(14, 10);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(908, 103);
            this.head.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtName.Location = new System.Drawing.Point(227, 3);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(478, 17);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "ร้านขายหนังสือวรรณกรรม";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P_receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(934, 531);
            this.Controls.Add(this.head);
            this.Name = "P_receive";
            this.Text = "P_receive";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.TextBox txtName;
    }
}