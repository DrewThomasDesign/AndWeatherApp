using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormsWeatherApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiURL = txtApiUrl.Text;
            var currentFeelsLike = getApiResponse.DeserializedForecast_FeelsLike(apiURL);
            lblRealFeelDegrees.Text = currentFeelsLike;
            PictureBox weatherBox = new PictureBox();
          
            //Get Gif URL to load
           // weatherBox.LoadAsync(getApiResponse.GetWeatherImage(txtApiUrl.Text));
           weatherBox.ImageLocation = getApiResponse.GetWeatherImage(url: apiURL);

            
        }
    }
}
