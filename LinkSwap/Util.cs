using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace LinkSwap
{
    public class Util
    {
        public string GET(string url)
        {
            Console.WriteLine(url);
            try
            {
                WebClient myWebClient = new WebClient();
                byte[] myDataBuffer = myWebClient.DownloadData(url);
                string str = Encoding.UTF8.GetString(myDataBuffer);
                return str;
            }
            catch { }
            return null;
        }

      
        public string GetTimeStamp(bool bflag = false)
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            string ret = string.Empty;
            if (bflag)
                ret = Convert.ToInt64(ts.TotalSeconds).ToString();
            else
                ret = Convert.ToInt64(ts.TotalMilliseconds).ToString();

            return ret;
        }

        public string GetValue(string str, string key = null, string pattern = null)
        {
            if (pattern == null) pattern = @"(?<=" + key + @"\s*=\s*).+?(?=(&|;|\s|$))";
            Match mc = Regex.Match(str, pattern);
            return mc.Value;
        }
    }
}
