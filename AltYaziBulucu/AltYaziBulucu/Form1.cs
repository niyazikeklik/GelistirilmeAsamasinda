using Newtonsoft.Json;

using System.Net;

using Topdev.OpenSubtitles.Client;

namespace AltYaziBulucu
{
    public partial class Form1 : Form
    {
        OpenSubTitlesAPI openSubTitlesAPI = new OpenSubTitlesAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            
            var x = openSubTitlesAPI.GetSubtitles(movieName.Text,int.Parse(Episoed.Text), int.Parse(Season.Text), "tr");

            dataGridView1.DataSource = x.data.Select(y=> new { y.id , y.attributes.download_count , y.attributes.fps, y.attributes.language, y.attributes.upload_date, y.attributes.points, y.attributes.ratings, y.attributes.files[0].file_id, y.attributes.files[0].file_name}).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fileýd = int.Parse(Season.Text);
            var file = openSubTitlesAPI.DowloandSubtitle(fileýd);
            using (var client = new WebClient())
            {
                client.DownloadFile(file.link, "altyazi.str"); ;
            }
        }
    }
}