using Newtonsoft.Json;
using RentCar.Entities;
using RentCar.RestApi;
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

namespace WindowsFormsApp1
{
    public partial class AracTeslim : Form
    {
        public Kullanici gkullanici;
        public AracTeslim()
        {
            InitializeComponent();
        }
        
        private async void btnTeslimEt_Click(object sender, EventArgs e)
        {
            List<Kiralama> kiralama = new List<Kiralama>();
            //İstekleri çek
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
                    using (var result = await client.GetAsync("api/Kiralama/"+Convert.ToInt32( txtMusteriId.Text)))
                    {

                            // Take the Result as a json string
                            var value = result.Content.ReadAsStringAsync().Result;

                            // Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
                            kiralama =
                              JsonConvert.DeserializeObject<ResponseContent<Kiralama>>(value).Data.ToList();
                       
                    }
                }
            }
            catch (Exception ex)
            {
                // Inform user if an error occurs
                MessageBox.Show("Error happened: " + ex.Message);
            }
            //Teslim Et
            try
            {
                // Create a HttpClient
                using (var client = new HttpClient())
                {
                    bool success = false;
                    // Setup basics
                    client.BaseAddress = new Uri("http://localhost:25667/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (kiralama[0] == null)
                    {
                        MessageBox.Show("Bu müşteriId'yle kayıtlı kiralama yok.");
                    }
                    else
                    {
                        // Get Request from the URI
                        using (var result = await client.DeleteAsync("api/Kiralama/" + kiralama[0].Id))
                        {
                            // Check the Result
                            if (result.IsSuccessStatusCode)
                            {
                                // Take the Result as a json string
                                var value = result.Content.ReadAsStringAsync().Result;
                                if (result.IsSuccessStatusCode)
                                {
                                    success = true;
                                }
                            }
                            // Set message depend on success info
                            var message = success ? "Teslim Edildi" : "failed";
                            // Inform user
                            MessageBox.Show("" + message);


                        }
                        txtbFatura.Text = "Tutar :" + kiralama[0].odenecekTutar;
                    }
                   
                }
            }
            catch (Exception ex)
            {
                // Inform user if an error occurs
                MessageBox.Show("Error happened: " + ex.Message);
            }
            
            

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.gkullanici = gkullanici;
            menu.Show();
            this.Hide();
        }
    }
}
