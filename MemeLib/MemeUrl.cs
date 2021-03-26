using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MemeLib
{
    public static class MemeUrl
    {
        private static Dictionary<string, string> Pages = new Dictionary<string, string>
        {
            { "https://www.blasty.pl/random.html", "//div[@class=\"file-warapper\"]/div/a/img" },
            { "https://nowe.memy.pl/losuj", "//figure[@class=\"figure-item\"]/a/img" }
        };

        private static KeyValuePair<string, string> DrawPage()
        {
            var random = new Random();
            // Return random mem url
            return Pages.ElementAt(random.Next(Pages.Count));
        }

        public static string DrawUrl()
        {
            HtmlWeb web = new HtmlWeb();
            var drawedPage = DrawPage();
            HtmlDocument page = web.Load(drawedPage.Key);

            try
            {
                string memeUrl = page.DocumentNode.SelectSingleNode(drawedPage.Value).Attributes["src"].Value;
                return memeUrl;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
