
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

namespace WindowsFormsApp1
{
    public partial class AracListele : Form
    {

        private int seciliAracId=0;
        private bool aracDurum=false;
        public Kullanici gkullanici;
        public AracListele()
        {
            
            InitializeComponent();
        }



        private async void AracListele_Load(object sender, EventArgs e)
        {
            dataGrid_Arac.AllowUserToAddRows = false;
            dataGrid_Arac.AllowUserToDeleteRows = false;
            dataGrid_Arac.ReadOnly = true;
            //Araları çek
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
                    using (var result = await client.GetAsync("api/Arac"))
                    {
                        // Check the Result
                        if (result.IsSuccessStatusCode)
                        {
                            // Take the Result as a json string
                            var value = result.Content.ReadAsStringAsync().Result;

                            // Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
                            dataGrid_Arac.DataSource =
                                  JsonConvert.DeserializeObject<ResponseContent<Arac>>(value).Data.ToList();
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

    

        private void dataGrid_Arac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGrid_Arac.Rows[index];
            seciliAracId = Convert.ToInt32(selectedRow.Cells[5].Value);
            aracDurum = selectedRow.Cells[3].Value.Equals(!aracDurum);
        }

        private async void btnKiralamaIstek_Click(object sender, EventArgs e)
        {
            Arac seciliArac=new Arac();

            if (seciliAracId == 0 ||aracDurum==false)
            {
                MessageBox.Show("Araç Kiralanamaz");
            }
            else
            {
                //Kiralama tablosuna insertle
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

                        // Create post body object
                        seciliArac.Id = seciliAracId;
                    

                    Kiralama kiralama = new Kiralama()
                    {
                        Arac = seciliArac,
                        Calisan=null,
                        kiralamaTarihi=DateTime.Now,
                        Musteri= gkullanici,
                        odenecekTutar=0

                    };
                        

                        // Serialize C# object to Json Object
                        var serializedProduct = JsonConvert.SerializeObject(kiralama);
                        // Json object to System.Net.Http content type
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                        // Post Request to the URI
                        var result = await client.PostAsync("api/Kiralama", content);
                        // Check for result
                        if (result.IsSuccessStatusCode)
                        {
                            success = true;
                        }
                    }
                    // Set message depend on success info
                    var message = success ? "İstek Yollandı" : "failed";
                    // Inform user
                    MessageBox.Show("" + message);
                }
                catch (Exception ex)
                {
                    // Inform user
                    MessageBox.Show("Error happened: " + ex.Message);
                }


                //Arac Durumunu güncelle
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

                        seciliArac.aracDurum = false;


                        // Serialize C# object to Json Object
                        var serializedProduct = JsonConvert.SerializeObject(seciliArac);
                        // Json object to System.Net.Http content type
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                        // Post Request to the URI
                        var result = await client.PutAsync("api/Arac/"+seciliAracId, content);
                        // Check for result
                        if (result.IsSuccessStatusCode)
                        {
                            success = true;
                        }
                    }
                    // Set message depend on success info
                    var message = success ? "Araç Durumu Güncellendi" : "failed";
                    // Inform user
                    MessageBox.Show("" + message);
                }
                catch (Exception ex)
                {
                    // Inform user
                    MessageBox.Show("Error happened: " + ex.Message);
                }
                //Araları çek
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
                        using (var result = await client.GetAsync("api/Arac"))
                        {
                            // Check the Result
                            if (result.IsSuccessStatusCode)
                            {
                                // Take the Result as a json string
                                var value = result.Content.ReadAsStringAsync().Result;

                                // Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
                                dataGrid_Arac.DataSource =
                                      JsonConvert.DeserializeObject<ResponseContent<Arac>>(value).Data.ToList();
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.gkullanici = gkullanici;
            menu.Show();
            this.Hide();
        }

    }
}
