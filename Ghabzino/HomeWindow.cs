using Ghabzino.Store;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghabzino
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enabled = false;
            new Thread(() => { Check(); }).Start();

        }
        private void Check()
        {
            while (true)
            {

                var stores = GetStores();
                var foundStores = new StringBuilder();
                foreach (var store in stores)
                {
                    var client = new HttpClient();
                    var request = new HttpRequestMessage(HttpMethod.Post, "https://dokan.khodropay.com/api/v2/cartGetProduct");
                    request.Headers.Add("sec-ch-ua", "\"Not A(Brand\";v=\"99\", \"Google Chrome\";v=\"121\", \"Chromium\";v=\"121\"");
                    request.Headers.Add("Accept", "application/json, text/plain, */*");
                    request.Headers.Add("sec-ch-ua-mobile", "?0");
                    request.Headers.Add("Authorization", txtToken.Text);
                    request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/121.0.0.0 Safari/537.36");
                    request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
                    request.Headers.Add("Sec-Fetch-Site", "same-site");
                    request.Headers.Add("Sec-Fetch-Mode", "cors");
                    request.Headers.Add("Sec-Fetch-Dest", "empty");
                    request.Headers.Add("host", "dokan.khodropay.com");
                    var storeParam = "{\"Parameters\":{\"sku\":\"\",\"warehouseId\":\"" + store.id + "\"}}";
                    var content = new StringContent(storeParam, null, "application/json");
                    request.Content = content;
                    var response = client.Send(request);
                    //response.EnsureSuccessStatusCode();
                    var st = response.Content.ReadAsStream();
                    using var reader = new StreamReader(st, Encoding.UTF8);
                    var myJsonResponse = reader.ReadToEnd();
                    Root r = JsonConvert.DeserializeObject<Root>(myJsonResponse);
                    var foundItem = r.Parameters.Where(
                        x =>
                        Int32.Parse(x.totalQty) > 1 &&
                        x.sellPrice < Int32.Parse(txtPrice.Text) &&
                        x.productName.Contains(txtCriteria.Text)
                        );
                    if (foundItem.Count() > 0)
                    {
                        //MessageBox.Show(store.name);
                        foundStores.AppendLine(store.name + "======" + store.address);
                    }


                }
                if (foundStores.Length > 0)
                {
                    //using (var soundPlayer = new SoundPlayer(@"D:\alarm2.wav"))
                    //{
                    //    soundPlayer.Play();
                    MessageBox.Show(foundStores.ToString());

                    //}
                }
                Thread.Sleep(2000);
            }
        }
        private List<Ghabzino.Store.List> GetStores()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://dokan.khodropay.com/api/v2/getAllStoreInCity");
            request.Headers.Add("sec-ch-ua", "\"Not A(Brand\";v=\"99\", \"Google Chrome\";v=\"121\", \"Chromium\";v=\"121\"");
            request.Headers.Add("Accept", "application/json, text/plain, */*");
            request.Headers.Add("sec-ch-ua-mobile", "?0");
            request.Headers.Add("Authorization", txtToken.Text);
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/121.0.0.0 Safari/537.36");
            request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            request.Headers.Add("Sec-Fetch-Site", "same-site");
            request.Headers.Add("Sec-Fetch-Mode", "cors");
            request.Headers.Add("Sec-Fetch-Dest", "empty");
            request.Headers.Add("host", "dokan.khodropay.com");
            var content = new StringContent("{\"Parameters\":{\"province\":\"زنجان\",\"city\":\"زنجان\"}}", null, "application/json");
            request.Content = content;
            var response = client.Send(request);

            var st = response.Content.ReadAsStream();
            using var reader = new StreamReader(st, Encoding.UTF8);
            var myJsonResponse = reader.ReadToEnd();
            Store.Root r = JsonConvert.DeserializeObject<Store.Root>(myJsonResponse);

            return r.Parameters.List;

        }

    }
}
