namespace Electronic_Store.Actions
{
    partial class Empty
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
            this.lblEmptyType = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmptyType
            // 
            this.lblEmptyType.AutoSize = true;
            this.lblEmptyType.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyType.Location = new System.Drawing.Point(47, 81);
            this.lblEmptyType.Name = "lblEmptyType";
            this.lblEmptyType.Size = new System.Drawing.Size(96, 38);
            this.lblEmptyType.TabIndex = 0;
            this.lblEmptyType.Text = "label1";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.Location = new System.Drawing.Point(49, 31);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(63, 25);
            this.lblmodel.TabIndex = 1;
            this.lblmodel.Text = "label1";
            // 
            // Empty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(683, 155);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lblEmptyType);
            this.Name = "Empty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Empty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmptyType;
        private System.Windows.Forms.Label lblmodel;
    }
}