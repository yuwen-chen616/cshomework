using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//作业：将上次作业的爬虫程序，使用并行处理进行优化，实现更快速的网页爬取。

namespace CrawlerForm
{
    internal class ParallelCrawler
    {
        public event Action<ParallelCrawler> CrawlerStopped;
        public event Action<ParallelCrawler, int, string, string> PageDownloaded;
        public string StartURL = "https://www.cnblogs.com/dstang2000/";
        //所有URL，key是URL，value表示是否下载成功
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();
        private ConcurrentQueue<string> queuepend = new ConcurrentQueue<string>();//待下载队列

        public void Start()
        {
            urls.Clear();
            queuepend = new ConcurrentQueue<string>();
            queuepend.Enqueue(StartURL);
            List<Task> tasks = new List<Task>();
            int complatedCount = 0;//已完成的任务数
            PageDownloaded += (crawler, index, url, info) => { complatedCount++; };

            while (tasks.Count < 100)
            {
                if (!queuepend.TryDequeue(out string url))
                {
                    if (complatedCount < tasks.Count)
                    {
                        continue;
                    }
                    else
                    {
                        break;//所有任务都完成
                    }
                }
                int index = tasks.Count;
                Task task = Task.Run(() => DownloadAndParse(url, index));
                tasks.Add(task);
            }
            Task.WaitAll(tasks.ToArray()); //等待剩余任务执行完毕
            CrawlerStopped(this);
        }

        private void DownloadAndParse(string url, int index)
        {
            try
            {
                string html = DownLoad(url, index);
                urls[url] = true;
                Parse(html, url);//解析,并加入新的链接
                PageDownloaded(this, index, url, "success");
            }
            catch (Exception ex)
            {
                PageDownloaded(this, index, url, "Error:" + ex.Message);
            }
        }

        private string DownLoad(string url, int index)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            File.WriteAllText(index + ".html", html, Encoding.UTF8);
            return html;
        }

        private void Parse(string html, string pageUrl)
        {
            var matches = new Regex(@"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']").Matches(html);
            foreach (Match match in matches)
            {
                string URL = match.Groups["url"].Value;
                if (URL == null || URL == "") continue;
                URL = TransferUrl(URL, pageUrl);//转绝对路径

                string urlParse = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
                //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(URL, urlParse);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                string HostFilter = "^" + host + "$";
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, ".html?$")
                  && !urls.ContainsKey(URL))
                {
                    queuepend.Enqueue(URL);
                    urls.TryAdd(URL, false);
                }
            }
        }


        //将相对路径转为绝对路径
        static private string TransferUrl(string url, string pageUrl)
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