
using RentCar.RestApi;
using Newtonsoft.Json;
using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BankAppForm.RestApi;
//using Newtonsoft.Json;
//using RentCar.Entities;
//using RentCar.Business;

namespace WindowsFormsApp1
{
    public partial class Giris : Form
    {
        
        public Giris()
        {
            InitializeComponent();
        }

        private  void Giris_Load(object sender, EventArgs e)
        {

            


       }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a HttpClient
                using (var client = new HttpClient())
                {
                    // Setup basics
                    client.BaseAddress = new Uri("http://localhost:25667/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Get Request from the URI
                    using (var result = await client.GetAsync("api/Kullanici"))
                    {
                        // Check the Result
                        if (result.IsSuccessStatusCode)
                        {
                            // Take the Result as a json string
                            var value = result.Content.ReadAsStringAsync().Result;

                            // Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
                            List<Kullanici> kullanici =
                                    JsonConvert.DeserializeObject<ResponseContent<Kullanici>>(value).Data.ToList();
                            foreach (var item in kullanici)
                            {
                                if (txtKullaniciAdi.Text==item.kullaniciAdi&&txtSifre.Text==item.sifre)
                                {
                                    
                                    Menu m = new Menu();
                                    m.gkullanici = item;
                                    m.Show();
                                    this.Hide();
                                }
                            }
                        }
                        
                    }
                    
                }
            }
            catch (Exception ex)
            {
                // Inform user if an error occurs
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }
    }
}