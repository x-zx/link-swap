using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LinkSwap
{
    public class SEO
    {
        Util util = new Util();
        string domain;
        string aizhan_html,chinaz_html, aizhan_link_html;
        public SEO(string domain)
        {
            this.domain = domain;
            aizhan_html = util.GET("http://www.aizhan.com/cha/" + domain);
            chinaz_html = util.GET("http://seo.chinaz.com/?q=" + domain);
            aizhan_link_html = util.GET("http://link.aizhan.com/?url=" + domain); 
        }

        public int GetNum(string type)
        {
            try
            {
                switch (type)
                {
                case "baidu":
                    MatchCollection mc = Regex.Matches(aizhan_html, "<td id=\"baidu\">.*?([\\d,]*)</a></td>");
                    return int.Parse(mc[0].Groups[1].Value.Replace(",", ""));
                    break;
                case "360":
                    MatchCollection mc2 = Regex.Matches(aizhan_html, "<td id=\"360so\">.*?([\\d,]*)</a></td>");
                    return int.Parse(mc2[0].Groups[1].Value.Replace(",", ""));
                    break;
                case "in":
                    MatchCollection mc3 = Regex.Matches(aizhan_link_html, "infoCount\">(\\d+)");
                    return int.Parse(mc3[0].Groups[1].Value);
                    break;
                case "out":
                    MatchCollection mc4 = Regex.Matches(aizhan_html, "出站链接：(\\d+)");
                    return int.Parse(mc4[0].Groups[1].Value);
                    break;
                }
            }
            catch { }
            
           
            return 0;
        }

        public int GetPR()
        {
            try
            {
                MatchCollection mc2 = Regex.Matches(aizhan_html, "pr(\\d+)");
                return int.Parse(mc2[0].Groups[1].Value);
            }
            catch { }
            

            //try
            //{
            //    switch (type)
            //    {
            //        case "baidu":
            //            MatchCollection mc = Regex.Matches(aizhan_html, "brs/(\\d+)");
            //            return int.Parse(mc[0].Groups[1].Value);
            //            break;
            //        case "google":
            //            MatchCollection mc2 = Regex.Matches(aizhan_html, "pr(\\d+)");
            //            return int.Parse(mc2[0].Groups[1].Value);
            //            break;
            //    }
            //}
            //catch { }
            return 0;
        }

        public int GetWeight(string type)
        {
            switch (type)
            {
                case "chinaz":
                    MatchCollection mc1 = Regex.Matches(chinaz_html, "baiduapp/(\\d+)");
                    return int.Parse(mc1[0].Groups[1].Value);
                    break;
                case "aizhan":
                    MatchCollection mc2 = Regex.Matches(aizhan_html, "brs/(\\d+)");
                    return int.Parse(mc2[0].Groups[1].Value);
                    break;
            }
            return 0;
        }
        
    }
}
