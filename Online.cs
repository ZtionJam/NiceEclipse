using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NiceEclipse
{
    static class Online
    {
        public static WebClient wc = new WebClient();
        public static string url = @"http://api.ztion.top/niceeclipse.html",thisver="2.0";
        public static Boolean hasNet = false;
        public static string name, uptime, newver, mustup,headimg,newapp,upinfo;
        public static Boolean GetUp() {
            try
            {
                wc.Credentials = CredentialCache.DefaultCredentials;
                Byte[] code = wc.DownloadData(url);
                string json = Encoding.UTF8.GetString(code);
                RootObject rb = JsonConvert.DeserializeObject<RootObject>(json);
                name = rb.name;
                uptime = rb.appinfo[0].uptime;
                newver= rb.appinfo[0].newver;
                mustup = rb.appinfo[0].mustup;
                headimg = rb.appinfo[0].headimg;
                newapp = rb.appinfo[0].newapp;
                upinfo = rb.appinfo[0].upinfo;

                hasNet = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public static void Main() {
            GetUp();
            
        }
    }
    #region Json类
    public class Appinfo
    {
        public string uptime { get; set; }
        public string newver { get; set; }
        public string mustup { get; set; }
        public string headimg { get; set; }
        public string newapp { get; set; }
        public string upinfo { get; set; }
    }

    public class RootObject
    {
        public string name { get; set; }
        public List<Appinfo> appinfo { get; set; }
    }
    #endregion
}
