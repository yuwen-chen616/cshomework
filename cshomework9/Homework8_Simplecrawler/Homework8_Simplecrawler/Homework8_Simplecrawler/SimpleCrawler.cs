using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//改进书上例子9-10的爬虫程序。
// （1）只爬取起始网站上的网页 
//（2）只有当爬取的是html文本时，才解析并爬取下一级URL。
// （3）相对地址转成绝对地址进行爬取。
//（4）尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。

namespace Homework8_Simplecrawler
{
    internal class SimpleCrawler
    {
        public event Action<SimpleCrawler> CrawlerStopped;
        public event Action<SimpleCrawler, string, string> PageDownloaded;
        public string StartURL = "https://www.cnblogs.com/dstang2000/"; //起始网页
        //所有已下载和待下载URL，key是URL，value表示是否下载成功
        private Dictionary<string, bool> urls = new Dictionary<string, bool>();
        private Queue<string> queuepend = new Queue<string>();//待下载队列

        public void Start()
        {
            urls.Clear();
            queuepend.Clear();
            queuepend.Enqueue(StartURL);

            while (urls.Count < 100 && queuepend.Count > 0)
            {
                string url = queuepend.Dequeue();
                try
                {
                    string html = DownLoad(url);
                    urls[url] = true;
                    PageDownloaded(this, url, "success");
                    Parse(html, url);//解析,并加入新的链接
                }
                catch (Exception ex)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message); //显示已经爬取的URL和错误的URL信息。
                }
            }
            CrawlerStopped(this);
        }
        
        private string DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = urls.Count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }

        //只有当爬取的是html文本时，才解析并爬取下一级URL。
        private void Parse(string html, string pageUrl)
        {
            string urlquery = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";
            var matches = new Regex(urlquery).Matches(html);
            foreach (Match match in matches)
            {
                string URL = match.Groups["url"].Value;
                if (URL == null || URL == "") continue;
                URL = TransferUrl(URL, pageUrl);//转绝对路径

                //解析出host和file两个部分，进行过滤
                string urlParse = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
                Match UrlMatch = Regex.Match(URL, urlParse);
                string host = UrlMatch.Groups["host"].Value;
                string file = UrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";
                string HostFilter = "^" + host + "$";
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, ".html?$")
                  && !urls.ContainsKey(URL))
                {
                    queuepend.Enqueue(URL);
                    urls.Add(URL, false);
                }
            }
        }

        //相对路径转为绝对路径
        private string TransferUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }
            if (url.StartsWith("/"))
            {
                string urlParse = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
                Match urlMatch = Regex.Match(pageUrl, urlParse);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }
            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return TransferUrl(url, pageUrl.Substring(0, idx));
            }
            if (url.StartsWith("./"))
            {
                return TransferUrl(url.Substring(2), pageUrl);
            }
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}