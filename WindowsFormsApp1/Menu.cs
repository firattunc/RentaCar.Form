using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Kullanici gkullanici;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (gkullanici.role.Id==1)
            {
                btnAraclar.Enabled = false;
                btnAracTeslimEt.Enabled = false;
                btnKiralamaIstegi.Enabled = false;
            }
            else if (gkullanici.role.Id == 2)
            {
                btnGrafik.Enabled = false;
                btnAracTeslimEt.Enabled = false;
                btnKiralamaIstegi.Enabled = false;
            }
            else if (gkullanici.role.Id == 3)
            {
                btnAraclar.Enabled = false;
                btnGrafik.Enabled = false;
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.Show();
            this.Hide();
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            AracListele g = new AracListele();
            g.gkullanici = gkullanici;            
            g.Show();
            this.Hide();
        }

        private void btnKiralamaIstegi_Click(object sender, EventArgs e)
        {
            KiralamaIstekleri g = new KiralamaIstekleri();
            g.gkullanici = gkullanici;
            g.Show();
            this.Hide();
        }

        private void btnAracTeslimEt_Click(object sender, EventArgs e)
        {
            AracTeslim g = new AracTeslim();
            g.gkullanici = gkullanici;
            g.Show();
            this.Hide();
        }
    }
}
