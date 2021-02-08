
namespace Clock2
{
    partial class Clock
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblZeit = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDay.Location = new System.Drawing.Point(451, 288);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(177, 60);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Sunday";
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZeit.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeit.ForeColor = System.Drawing.SystemColors.Control;
            this.lblZeit.Location = new System.Drawing.Point(212, 107);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(268, 119);
            this.lblZeit.TabIndex = 0;
            this.lblZeit.Text = "22:22";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(12, 288);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(349, 60);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "January 24 2021";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(829, 514);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.lblDay);
            this.Name = "Clock";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer;
    }
}

