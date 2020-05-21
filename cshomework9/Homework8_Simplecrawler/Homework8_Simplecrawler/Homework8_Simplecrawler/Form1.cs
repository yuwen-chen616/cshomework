using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8_Simplecrawler
{
    public partial class Form1 : Form
    {
        BindingSource BS = new BindingSource();
        SimpleCrawler crawler = new SimpleCrawler();
        Thread thread = null;

        public Form1()
        {
            InitializeComponent();
            urlresult.DataSource = BS; ;
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(SimpleCrawler obj)
        {
            Action action = () => lblInfo.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }else
            {
                action();
            }
    }

        private void Crawler_PageDownloaded(SimpleCrawler crawler, string url, string info) {
            var pageInfo = new { Index = BS.Count + 1, URL = url, Status = info };
            Action action = () => { BS.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }else
            {
                action();
            }
        }


        private void btnStart_Click(object sender, EventArgs e) {
            BS.Clear();
            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(crawler.Start);
            thread.Start();
            lblInfo.Text = "爬虫已启动";
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
