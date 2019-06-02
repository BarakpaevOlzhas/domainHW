using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();

            string url = "https://github.com/BarakpaevOlzhas/Unity/archive/master.zip";
            string savePath = AppDomain.CurrentDomain.BaseDirectory;
            string nameFile = "TestFile";

            wc.DownloadFile(url, savePath + nameFile);
        }
    }
}
