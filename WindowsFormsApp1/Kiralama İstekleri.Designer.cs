namespace WindowsFormsApp1
{
    partial class KiralamaIstekleri
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
            this.btnKabulEt = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.dataGridView_KiralamaIstekler = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KiralamaIstekler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKabulEt
            // 
            this.btnKabulEt.Location = new System.Drawing.Point(786, 455);
            this.btnKabulEt.Name = "btnKabulEt";
            this.btnKabulEt.Size = new System.Drawing.Size(92, 45);
            this.btnKabulEt.TabIndex = 2;
            this.btnKabulEt.Text = "Kabul Et";
            this.btnKabulEt.UseVisualStyleBackColor = true;
            this.btnKabulEt.Click += new System.EventHandler(this.btnKabulEt_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(967, 455);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(92, 45);
            this.btnRed.TabIndex = 3;
            this.btnRed.Text = "Reddet";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // dataGridView_KiralamaIstekler
            // 
            this.dataGridView_KiralamaIstekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KiralamaIstekler.Location = new System.Drawing.Point(41, 33);
            this.dataGridView_KiralamaIstekler.Name = "dataGridView_KiralamaIstekler";
            this.dataGridView_KiralamaIstekler.RowTemplate.Height = 24;
            this.dataGridView_KiralamaIstekler.Size = new System.Drawing.Size(1018, 379);
            this.dataGridView_KiralamaIstekler.TabIndex = 4;
            this.dataGridView_KiralamaIstekler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KiralamaIstekler_CellClick);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(41, 455);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(92, 45);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // KiralamaIstekleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 535);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dataGridView_KiralamaIstekler);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnKabulEt);
            this.Name = "KiralamaIstekleri";
            this.Text = "Kiralama İstekleri";
            this.Load += new System.EventHandler(this.Kiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KiralamaIstekler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKabulEt;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.DataGridView dataGridView_KiralamaIstekleri;
        private System.Windows.Forms.DataGridView dataGridView_KiralamaIstekler;
        private System.Windows.Forms.Button btnGeri;
    }
}