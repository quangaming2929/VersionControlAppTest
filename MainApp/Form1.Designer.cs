namespace MainApp
{
    partial class Form1
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
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnCheckForUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(338, 79);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(45, 29);
            this.lbVersion.TabIndex = 0;
            this.lbVersion.Text = "1.0";
            // 
            // btnCheckForUpdate
            // 
            this.btnCheckForUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckForUpdate.Location = new System.Drawing.Point(239, 187);
            this.btnCheckForUpdate.Name = "btnCheckForUpdate";
            this.btnCheckForUpdate.Size = new System.Drawing.Size(295, 121);
            this.btnCheckForUpdate.TabIndex = 1;
            this.btnCheckForUpdate.Text = "Check For Update";
            this.btnCheckForUpdate.UseVisualStyleBackColor = true;
            this.btnCheckForUpdate.Click += new System.EventHandler(this.btnCheckForUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckForUpdate);
            this.Controls.Add(this.lbVersion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnCheckForUpdate;
    }
}

