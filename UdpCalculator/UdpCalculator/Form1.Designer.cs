namespace UdpCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.cmbOp = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(220, 150);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 25);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "Sayı 1 giriniz";
            this.txtA.ForeColor = System.Drawing.Color.Gray;
            this.txtA.Enter += new System.EventHandler(this.txtA_Enter);
            this.txtA.Leave += new System.EventHandler(this.txtA_Leave);

            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(400, 150);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(150, 25);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "Sayı 2 giriniz";
            this.txtB.ForeColor = System.Drawing.Color.Gray;
            this.txtB.Enter += new System.EventHandler(this.txtB_Enter);
            this.txtB.Leave += new System.EventHandler(this.txtB_Leave);

            // 
            // cmbOp
            // 
            this.cmbOp.FormattingEnabled = true;
            this.cmbOp.Items.AddRange(new object[] { "+", "-", "*", "/" });
            this.cmbOp.Location = new System.Drawing.Point(580, 150);
            this.cmbOp.Name = "cmbOp";
            this.cmbOp.Size = new System.Drawing.Size(60, 25);
            this.cmbOp.TabIndex = 3;

            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(280, 220);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 40);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Navy;
            this.lblResult.Location = new System.Drawing.Point(420, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(95, 25);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Sonuç: --";

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(250, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 28);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "UDP Hesap Makinesi Arayüzü";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cmbOp);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "UDP Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.ComboBox cmbOp;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTitle;
    }
}
