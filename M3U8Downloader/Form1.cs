using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Threading;

namespace M3U8Downloader
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr window, int message, int wparam, int lparam);

        private const int SbBottom = 0x7;
        private const int WmVscroll = 0x115;

        public string URLlink { get; private set; }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        string str_Source, cmd_Source = "";
        string str_vtv, str_kenh14, str_vnexpress, str_shopee, str_custom = "";
        string Referer, m3u8, Title = "";
        string DownloadFolder, DownloadFile = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            const int kNotFound = -1;

            var startIdx = strSource.IndexOf(strStart);
            if (startIdx != kNotFound)
            {
                startIdx += strStart.Length;
                var endIdx = strSource.IndexOf(strEnd, startIdx);
                if (endIdx > startIdx)
                {
                    return strSource.Substring(startIdx, endIdx - startIdx);
                }
            }
            return String.Empty;
        }

        public void ExecuteCommand(string command)
        {

            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "CMD.exe";
            pProcess.StartInfo.Arguments = command;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            // Set event handler
            pProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            pProcess.Start();

            // Start the asynchronous read
            pProcess.BeginOutputReadLine();

            pProcess.WaitForExit();
            pProcess.Close();
        }

        void SortOutputHandler(object sender, DataReceivedEventArgs e)
        {
            Trace.WriteLine(e.Data);
            this.BeginInvoke(new MethodInvoker(() =>
            {
                rtb1.AppendText(e.Data + Environment.NewLine ?? string.Empty);
                SendMessage(rtb1.Handle, WmVscroll, SbBottom, 0x0);
            }));
        }

        private void cbbSource_Click(object sender, EventArgs e)
        {
            cbbSource.DroppedDown = true;
            lblProcess.Visible = false;
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            lblProcess.Visible = false;
        }

        private void lblProcess_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", DownloadFile);
        }

        private void txtURL_MouseClick(object sender, MouseEventArgs e)
        {
            txtURL.SelectAll();
        }

        private void txtM3U8_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(cbbSource.Text == "")
            {
                MessageBox.Show("Please select Source first.", "M3U8 Downloader", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //widthStart = "";
                //widthEnd = "";
                //site = cbbSource.Text;
                //url = txtURL.Text;

                //switch (site)
                //{
                //    case "VNEXPRESS.VN":
                //        widthStart = "contentUrl\": \"";
                //        widthEnd = "master.m3u8\"";
                //        break;

                //}

                ////Get Source

                //var html = txtURL.Text;
                //HtmlWeb web = new HtmlWeb();
                //var htmlDoc = web.Load(html);
                //var node = htmlDoc.DocumentNode.SelectSingleNode("//head");

                //rtb1.Text = ("Node Name: " + node.Name + "\n" + node.OuterHtml);

                //totalLines = rtb1.Lines.Length;
                //foreach (var line in rtb1.Lines)
                //{

                //    if (line.Contains(widthEnd))
                //    {
                //        data = getBetween(line, widthStart, widthEnd);
                //        m3u8 = data + "master.m3u8";
                //    }

                //}
                rtb1.Text = "";
                btnDownload.Text = "Downloading...";
                bgDownload.RunWorkerAsync();
            }
            
        }

        public void reSoure()
        {


            //
            m3u8 = txtM3U8.Text;
            Referer = txtURL.Text;
            Title = "Video_" + DateTime.Now.ToString("yyyyddMM_hhmmss");
            DownloadFolder = Environment.CurrentDirectory.ToString();
            DownloadFile = DownloadFolder + @"\" + Title + ".mp4";
            // Library
            // VTV: ffmpeg -user_agent "Mozilla/5.0 (iPhone; U; CPU iPhone OS 3_0 like Mac OS X; en-us)AppleWebKit/528.18 (KHTML, like Gecko) Version/4.0 Mobile/7A341Safari/528.16" -referer "https://vtv.vn/video/thoi-su-19h-vtv1-26-6-2018-307696.htm" -i "https://hls.mediacdn.vn/vtv/2018/6/26/2606thoisu19h-1530017484872626935899-fc08f.mp4/1080.m3u8?v=626c23d3" -c copy "test.mp4"

            // Kenh14: ffmpeg -user_agent "Mozilla/5.0 (iPhone; U; CPU iPhone OS 3_0 like Mac OS X; en-us)AppleWebKit/528.18 (KHTML, like Gecko) Version/4.0 Mobile/7A341Safari/528.16" -referer "https://kenh14.vn/bich-phuong-toi-do-tat-ca-nhung-ai-cua-minh-nguoi-yeu-cu-nhan-tin-moi-di-dam-cuoi-toi-khong-seen-20200603225408402.chn" -i "https://hls.mediacdn.vn/kenh14/2020/6/3/cBhl3NXTf60-1591202288037689890771.mp4/master.m3u8" -c copy "test.mp4"

            // VNEXPRESS: ffmpeg -headers "Referer: https://ione.vnexpress.net/tin-tuc/sao/chau-a/fan-dao-lai-video-chu-tich-jyp-dan-mat-hee-chul-4036216.htm" -i https://d1.vnecdn.net/ione/video/video/web/mp4//2020/01/02/fan-dao-lai-video-chu-tich-jyp-dan-mat-hee-chul-1577949258/index-v1-a1.m3u8 -c copy -bsf:a aac_adtstoasc OUTPUT.MP4

            // SHOPEE: youtube-dl -f bestvideo+bestaudio https://cv.shopee.vn/dash/2019/11/19/18/,J3MCkOS31JaAdKGC_120.mp4,J3MCkOS31JaAdKGC.mp4,.urlset/manifest.mpd

            str_vtv = "/C ffmpeg -user_agent \"Mozilla / 5.0(iPhone; U; CPU iPhone OS 3_0 like Mac OS X; en - us)AppleWebKit / 528.18(KHTML, like Gecko) Version / 4.0 Mobile / 7A341Safari / 528.16\" -referer \"" + Referer + "\" -i \"" + m3u8 + "\" -c copy \"" + Title + ".mp4\"";

            str_kenh14 = "/C ffmpeg -user_agent \"Mozilla / 5.0(iPhone; U; CPU iPhone OS 3_0 like Mac OS X; en - us)AppleWebKit / 528.18(KHTML, like Gecko) Version / 4.0 Mobile / 7A341Safari / 528.16\" -referer \"" + Referer + "\" -i \"" + m3u8 + "\" -c copy \"" + Title + ".mp4\"";

            str_vnexpress = "/C ffmpeg -headers \"Referer: " + Referer + "\" -i \"" + m3u8 + "\" -c copy -bsf:a aac_adtstoasc " + Title + ".mp4";

            str_shopee = "/C youtube-dl -f bestvideo+bestaudio " + m3u8 + ""; // m3u8 manifest.mpd

            str_custom = "/C ffmpeg -headers \"Referer: " + Referer + "\" -i " + m3u8 + " -c copy -bsf:a aac_adtstoasc " + Title + ".mp4";

            switch (cmd_Source)
            {
                //VTV.VN
                //KENH14.VN
                //VNEXPRESS.VN
                //IONE.VNEXPRESS.VN
                //SHOPEE
                //CUSTOM
                case "VTV.VN":
                    cmd_Source = str_vtv;
                    break;
                case "KENH14.VN":
                    cmd_Source = str_kenh14;
                    break;
                case "VNEXPRESS.VN":
                    cmd_Source = str_vnexpress;
                    break;
                case "IONE.VNEXPRESS.VN":
                    cmd_Source = str_vnexpress;
                    break;
                case "SHOPEE":
                    cmd_Source = str_shopee;
                    break;
                case "CUSTOM":
                    cmd_Source = str_custom;
                    break;
            }
            
            

        }
        public void Download()
        {
            reSoure();
            ExecuteCommand(cmd_Source);
        }

        private void bgDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            Download();
        }

        private void bgDownload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProcess.Visible = true;
            lblProcess.Text = Title+".mp4";
            if (MessageBox.Show("Download completed. Do you want open folder download?", "M3U8 Downloade", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start("explorer.exe", DownloadFolder);
            }

            btnDownload.Text = "DOWNLOAD";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbSource_TextChanged(object sender, EventArgs e)
        {
            str_Source = cbbSource.Text;
            switch (str_Source)
            {
                //VTV.VN
                //KENH14.VN
                //VNEXPRESS.VN
                //IONE.VNEXPRESS.VN
                //SHOPEE
                //CUSTOM
                case "VTV.VN":
                    cmd_Source = "VTV.VN";
                    break;
                case "KENH14.VN":
                    cmd_Source = "KENH14.VN";
                    break;
                case "VNEXPRESS.VN":
                    cmd_Source = "VNEXPRESS.VN";
                    break;
                case "IONE.VNEXPRESS.VN":
                    cmd_Source = "IONE.VNEXPRESS.VN";
                    break;
                case "SHOPEE":
                    cmd_Source = "SHOPEE";
                    break;
                case "CUSTOM":
                    cmd_Source = "CUSTOM";
                    break;
            }
        }
        }
}
