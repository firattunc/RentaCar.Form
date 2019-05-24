namespace WindowsFormsApp1
{
    partial class Menu
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
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnKiralamaIstegi = new System.Windows.Forms.Button();
            this.btnAracTeslimEt = new System.Windows.Forms.Button();
            this.btnAraclar = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(198, 85);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(132, 64);
            this.btnGrafik.TabIndex = 0;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            // 
            // btnKiralamaIstegi
            // 
            this.btnKiralamaIstegi.Location = new System.Drawing.Point(557, 265);
            this.btnKiralamaIstegi.Name = "btnKiralamaIstegi";
            this.btnKiralamaIstegi.Size = new System.Drawing.Size(132, 64);
            this.btnKiralamaIstegi.TabIndex = 1;
            this.btnKiralamaIstegi.Text = "Kiralama İstekleri";
            this.btnKiralamaIstegi.UseVisualStyleBackColor = true;
            this.btnKiralamaIstegi.Click += new System.EventHandler(this.btnKiralamaIstegi_Click);
            // 
            // btnAracTeslimEt
            // 
            this.btnAracTeslimEt.Location = new System.Drawing.Point(198, 265);
            this.btnAracTeslimEt.Name = "btnAracTeslimEt";
            this.btnAracTeslimEt.Size = new System.Drawing.Size(132, 64);
            this.btnAracTeslimEt.TabIndex = 2;
            this.btnAracTeslimEt.Text = "Araç Teslim Et";
            this.btnAracTeslimEt.UseVisualStyleBackColor = true;
            this.btnAracTeslimEt.Click += new System.EventHandler(this.btnAracTeslimEt_Click);
            // 
            // btnAraclar
            // 
            this.btnAraclar.Location = new System.Drawing.Point(557, 85);
            this.btnAraclar.Name = "btnAraclar";
            this.btnAraclar.Size = new System.Drawing.Size(132, 64);
            this.btnAraclar.TabIndex = 4;
            this.btnAraclar.Text = "Araclar";
            this.btnAraclar.UseVisualStyleBackColor = true;
            this.btnAraclar.Click += new System.EventHandler(this.btnAraclar_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(734, 403);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(132, 64);
            this.btnCikisYap.TabIndex = 5;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 512);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnAraclar);
            this.Controls.Add(this.btnAracTeslimEt);
            this.Controls.Add(this.btnKiralamaIstegi);
            this.Controls.Add(this.btnGrafik);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnKiralamaIstegi;
        private System.Windows.Forms.Button btnAracTeslimEt;
        private System.Windows.Forms.Button btnAraclar;
        private System.Windows.Forms.Button btnCikisYap;
    }
}