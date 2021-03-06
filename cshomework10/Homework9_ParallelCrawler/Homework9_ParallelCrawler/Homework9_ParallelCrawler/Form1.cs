﻿using System;
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

namespace CrawlerForm {
  public partial class Form1 : Form
    {
      BindingSource BS = new BindingSource();
      ParallelCrawler crawler = new ParallelCrawler();
      Thread thread = null;

      public Form1()
      {
           InitializeComponent();
           urlresult.DataSource = BS;
           crawler.PageDownloaded += Crawler_PageDownloaded;
           crawler.CrawlerStopped += Crawler_CrawlerStopped;
      }

      private void Crawler_CrawlerStopped(ParallelCrawler obj)
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

      private void Crawler_PageDownloaded(ParallelCrawler crawler, int index, string url, string info)
      {
          var pageInfo = new { Index = index, URL = url, Status = info };
          Action action = () => { BS.Add(pageInfo); };
          if (this.InvokeRequired)
          {
              this.Invoke(action);
          }else
          {
              action();
          }
      }


        private void btnStart_Click(object sender, EventArgs e)
        {
            BS.Clear();
            crawler.StartURL = txtUrl.Text;

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(crawler.Start);
            thread.Start();
            lblInfo.Text = "爬虫已启动....";
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
