using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitHubDownloadTest
{
    class Program
    {
        /// <summary>
        /// test console app
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            using (var client = new WebClient())
            {
                client.Headers.Add("user-agent", "Anything");
                client.DownloadFile(
                    "https://api.github.com/repos/nodatime/nodatime/zipball/", "nodatime.zip");
            }
        }
    }
}
