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
    public partial class KiralamaIstekleri : Form
    {
        List<Kiralama> istekler = new List<Kiralama>();
        public Kullanici gkullanici;
        public Arac arac;
        int kiralamaId;
        public KiralamaIstekleri()
        {
            InitializeComponent();
        }

        private async void Kiralama_Load(object sender, EventArgs e)
        {
            
            dataGridView_KiralamaIstekler.AllowUserToAddRows = false;
            dataGridView_KiralamaIstekler.AllowUserToDeleteRows = false;
            dataGridView_KiralamaIstekler.ReadOnly = true;
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
                    using (var result = await client.GetAsync("api/Kiralama"))
                    {
                        // Check the Result
                        if (result.IsSuccessStatusCode)
                        {
                            // Take the Result as a json string
                            var value = result.Content.ReadAsStringAsync().Result;

                            // Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
                                istekler =
                                  JsonConvert.DeserializeObject<ResponseContent<Kiralama>>(value).Data.ToList();
                            dataGridView_KiralamaIstekler.DataSource = istekler;
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

        private void dataGridView_KiralamaIstekler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView_KiralamaIstekler.Rows[index];
            kiralamaId = Convert.ToInt32( selectedRow.Cells[0].Value);
            arac = (Arac)selectedRow.Cells[5].Value;
        }

        private async void btnKabulEt_Click(object sender, EventArgs e)
        {
            if (kiralamaId>0)
            {
                // İsteği kabul et
                try
                {
                    bool success = false;
                    // Create a HttpClient
                    using (var client = new HttpClient())
                    {
                        // Setup basics
                        client.BaseAddress = new Uri("http://localhost:25667/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new MediaTypeWithQualityHeaderValue("application/json"));

                        Kiralama kullanici = new Kiralama()
                        {
                            Calisan = gkullanici,
                            kiralamaTarihi = DateTime.Now
                        };


                        // Serialize C# object to Json Object
                        var serializedProduct = JsonConvert.SerializeObject(kullanici);
                        // Json object to System.Net.Http content type
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                        // Post Request to the URI
                        var result = await client.PutAsync("api/Kiralama/" + kiralamaId, content);
                        // Check for result
                        if (result.IsSuccessStatusCode)
                        {
                            success = true;
                        }
                    }
                    // Set message depend on success info
                    var message = success ? "Araç Kiralandı" : "failed";
                    // Inform user
                    MessageBox.Show("" + message);
                }
                catch (Exception ex)
                {
                    // Inform user
                    MessageBox.Show("Error happened: " + ex.Message);
                }
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
                        using (var result = await client.GetAsync("api/Kiralama"))
                        {
                            // Check the Result
                            if (result.IsSuccessStatusCode)
                            {
                                // Take the Result as a json string
                                var value = result.Content.ReadAsStringAsync().Result;

                                // Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
                                istekler =
                                  JsonConvert.DeserializeObject<ResponseContent<Kiralama>>(value).Data.ToList();
                                dataGridView_KiralamaIstekler.DataSource = istekler;
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
            else
            {
                MessageBox.Show("Kiralama verisi seçiniz");
            }
           
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.gkullanici = gkullanici;
            menu.Show();
            this.Hide();
        }

        private async void btnRed_Click(object sender, EventArgs e)
        {
            if (kiralamaId>0)
            {
                //İsteği reddet
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

                        // Get Request from the URI
                        using (var result = await client.DeleteAsync("api/Kiralama/" + kiralamaId))
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
                            var message = success ? "İstek Reddedildi" : "failed";
                            // Inform user
                            MessageBox.Show("" + message);


                        }
                    }
                }
                catch (Exception ex)
                {
                    // Inform user if an error occurs
                    MessageBox.Show("Error happened: " + ex.Message);
                }
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
                        using (var result = await client.GetAsync("api/Kiralama"))
                        {
                            // Check the Result
                            if (result.IsSuccessStatusCode)
                            {
                                // Take the Result as a json string
                                var value = result.Content.ReadAsStringAsync().Result;

                                // Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
                                istekler =
                                  JsonConvert.DeserializeObject<ResponseContent<Kiralama>>(value).Data.ToList();
                                dataGridView_KiralamaIstekler.DataSource = istekler;
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
            else
            {
                MessageBox.Show("Kiralama verisi seçiniz");
            }
        }
    }
}
