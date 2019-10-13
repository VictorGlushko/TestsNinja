using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IFileDownloader
    {
        void GetFile(string url, string path);
    }

    class FileDownloader : IFileDownloader
    {
        public void GetFile(string url, string path)
        {

            var client = new WebClient();
            client.DownloadFile(url, path);

        }
    }
}
