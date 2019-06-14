using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * |==================================================|
 * |====This code created by K.J. Chen ( 陳冠儒 )=====|
 * |=Copyright © 2019 K.J. Chen | All Rights Reserved=|
 * |==================================================|
*/

namespace IoT_Car
{
    public partial class IoT_Car_Form : Form
    {
        private System.Drawing.Bitmap NegativeConvert(System.Drawing.Image img)
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(img);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var pixel = bitmap.GetPixel(x, y);

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(pixel.A, 255 - pixel.R, 255 - pixel.G, 255 - pixel.B);

                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }
        public IoT_Car_Form()
        {
            InitializeComponent();
        }

        private void IoT_Car_Form_Load(object sender, EventArgs e)
        {

        }

        private async void GetDirective(String url)
        {
            HttpClient client = new HttpClient();
            String server_url = "http://192.168.43.192:8080/car_run/" + url;
            HttpResponseMessage response = await client.GetAsync(server_url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
        }

        private void FormNameLebal_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdvanceButton_Click(object sender, EventArgs e)
        {
            GetDirective("advance");
        }

        private void AllStopButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SituLeftButton_Click(object sender, EventArgs e)
        {
            GetDirective("situ_left");
        }

        private void SituRightButton_Click(object sender, EventArgs e)
        {
            GetDirective("situ_right");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TurnLeftButton_Click(object sender, EventArgs e)
        {
            GetDirective("left");
        }

        private void StopRunButton_Click(object sender, EventArgs e)
        {
            GetDirective("stop_run");
        }

        private void TurnRightButton_Click(object sender, EventArgs e)
        {
            GetDirective("right");
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GetDirective("back");
        }

        private void GithubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kj-chen");
        }

        private void GithubButton_MouseEnter(object sender, EventArgs e)
        {
            GithubButton.BackColor = Color.Black/*FromArgb(128, 255, 128)*/;
            GithubButton.ForeColor = Color.White;
            GithubButton.Image = NegativeConvert(GithubButton.Image);
        }

        private void GithubButton_MouseLeave(object sender, EventArgs e)
        {
            GithubButton.BackColor = Color.Transparent;
            GithubButton.ForeColor = Color.Black;
            GithubButton.Image = NegativeConvert(GithubButton.Image);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Transparent;
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SituLeftButton_MouseEnter(object sender, EventArgs e)
        {
            //SituLeftButton.ForeColor = Color.White;
            //SituLeftButton.Image = NegativeConvert(SituLeftButton.Image);
        }

        private void SituLeftButton_MouseLeave(object sender, EventArgs e)
        {
            //SituLeftButton.ForeColor = Color.Black;
            //SituLeftButton.Image = NegativeConvert(SituLeftButton.Image);
        }
    }
}
