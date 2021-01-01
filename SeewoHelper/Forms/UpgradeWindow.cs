using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using SeewoHelper.Models;

namespace SeewoHelper.Forms
{
    public partial class UpgradeWindow : Form
    {
        private string ReleaseLink = "";

        private string PreReleaseLink = "";

        public UpgradeWindow()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CheckRelease()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.50 Safari/537.36 Edg/88.0.705.29");
            try
            {
                HttpResponseMessage responseLatest = await client.GetAsync(Constants.ReleaseLatestLink);
                responseLatest.EnsureSuccessStatusCode();//用来抛异常的
                string getLatestJson = await responseLatest.Content.ReadAsStringAsync();
                Release release = JsonConvert.DeserializeObject<Release>(getLatestJson);
                if (release.name != "")
                {
                    linkLabelRelease.Text = release.name;
                }
                else
                {
                    linkLabelRelease.Text = release.tag_name;
                }
                ReleaseLink = release.html_url;
            }
            catch { }
            try
            {
                HttpResponseMessage responsePre = await client.GetAsync(Constants.ReleaseAllLink);
                responsePre.EnsureSuccessStatusCode();//用来抛异常的
                string getPreJson = await responsePre.Content.ReadAsStringAsync();
                Release[] release = JsonConvert.DeserializeObject<Release[]>(getPreJson);
                if (release.Length != 0)
                {
                    if (release[0].name != "")
                    {
                        linkLabelPreRelease.Text = release[0].name;
                    }
                    else
                    {
                        linkLabelPreRelease.Text = release[0].tag_name;
                    }
                    PreReleaseLink = release[0].html_url;
                }
            }
            catch { }
            if (ReleaseLink == "")
                linkLabelRelease.Enabled = false;
            if (PreReleaseLink == "")
                linkLabelPreRelease.Enabled = false;
        }

        private void UpgradeWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 UpgradeWindow");
            CheckRelease();
            Program.Logger.Add("UpgradeWindow 加载完成");
        }

        private void linkLabelRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(ReleaseLink);
        }

        private void linkLabelPreRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(PreReleaseLink);
        }
    }
}
