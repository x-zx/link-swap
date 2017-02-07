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
            var encoding = new UTF8Encoding(false);
            try
            {
                WebClient myWebClient = new WebClient();
                byte[] myDataBuffer = myWebClient.DownloadData(url);
                //string str = Encoding.UTF8.GetString(myDataBuffer);
                string str = GetNoBomUTF8String(myDataBuffer);
                return str;
            }
            catch { }
            return null;
        }

        public bool Exist(string url ,string key)
        {
            string res = GET(url);
            if (res != null && res.IndexOf(key) > -1)
            {
                return true;
            }
            else return false;

    
        }

        public static string GetNoBomUTF8String(byte[] buffer)
        {
            if (buffer == null) return null;
            if (buffer.Length <= 3)
            {
                return Encoding.UTF8.GetString(buffer);
            }
            byte[] bomBuffer = new byte[] { 0xef, 0xbb, 0xbf };
            if (buffer[0] == bomBuffer[0] && buffer[1] == bomBuffer[1] && buffer[2] == bomBuffer[2])
            {
                return new UTF8Encoding(false).GetString(buffer, 3, buffer.Length - 3);
            }
            return Encoding.UTF8.GetString(buffer);
        }

        public static string RemoveBom(String desc, Encoding encode)
        {
            string bomString = encode.GetString(encode.GetPreamble());
            if (!string.IsNullOrEmpty(bomString) && desc.StartsWith(bomString))
            {
                desc = desc.Remove(0, bomString.Length);
            }
            return desc;
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
