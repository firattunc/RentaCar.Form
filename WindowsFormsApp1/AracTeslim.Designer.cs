namespace WindowsFormsApp1
{
    partial class AracTeslim
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
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.txtbFatura = new System.Windows.Forms.TextBox();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri Id :";
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(175, 62);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(285, 22);
            this.txtMusteriId.TabIndex = 7;
            // 
            // txtbFatura
            // 
            this.txtbFatura.Location = new System.Drawing.Point(175, 166);
            this.txtbFatura.Multiline = true;
            this.txtbFatura.Name = "txtbFatura";
            this.txtbFatura.Size = new System.Drawing.Size(449, 203);
            this.txtbFatura.TabIndex = 11;
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Location = new System.Drawing.Point(646, 59);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(119, 51);
            this.btnTeslimEt.TabIndex = 12;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(25, 389);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 51);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // AracTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 469);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.txtbFatura);
            this.Controls.Add(this.txtMusteriId);
            this.Controls.Add(this.label1);
            this.Name = "AracTeslim";
            this.Text = "Araç_Teslim_Et";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.TextBox txtbFatura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.Button btnGeri;
    }
}