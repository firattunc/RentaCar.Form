namespace WindowsFormsApp1
{
    partial class AracListele
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
            this.btnKiralamaIstek = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGrid_Arac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Arac)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKiralamaIstek
            // 
            this.btnKiralamaIstek.Location = new System.Drawing.Point(1166, 463);
            this.btnKiralamaIstek.Name = "btnKiralamaIstek";
            this.btnKiralamaIstek.Size = new System.Drawing.Size(118, 64);
            this.btnKiralamaIstek.TabIndex = 30;
            this.btnKiralamaIstek.Text = "Kiralama İsteği Yolla";
            this.btnKiralamaIstek.UseVisualStyleBackColor = true;
            this.btnKiralamaIstek.Click += new System.EventHandler(this.btnKiralamaIstek_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(46, 463);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(118, 64);
            this.btnGeri.TabIndex = 32;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGrid_Arac
            // 
            this.dataGrid_Arac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Arac.Location = new System.Drawing.Point(46, 34);
            this.dataGrid_Arac.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_Arac.Name = "dataGrid_Arac";
            this.dataGrid_Arac.Size = new System.Drawing.Size(1262, 387);
            this.dataGrid_Arac.TabIndex = 36;
            // 
            // AracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 539);
            this.Controls.Add(this.dataGrid_Arac);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKiralamaIstek);
            this.Name = "AracListele";
            this.Text = "Araclar";
            this.Load += new System.EventHandler(this.AracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Arac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKiralamaIstek;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGrid_Arac;
    }
}

