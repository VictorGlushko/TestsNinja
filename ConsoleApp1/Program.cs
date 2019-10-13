using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strw= @"E:\123.txt";
            var client = new WebClient();
            client.DownloadFile("https://www.google.ru/", strw);
        }
    }
}
