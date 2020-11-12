using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CutURL.Domain
{
    public class CutUrl
    {
        public string[] GetShortURL(string[] longURL)
        {
            try
            {
                string[] shortURL = new string[longURL.Length];
                for (int i = 0; i < longURL.Length; i++)
                {
                    using (WebClient wc = new WebClient())
                    {
                        shortURL[i] = wc.DownloadString("https://clck.ru/--?url=" + longURL[i]);
                    }
                }
                return shortURL;
            }
            catch(WebException wex)
            {
                Console.WriteLine(wex.InnerException.Message);
                return Array.Empty<String>();
            }
        }
        public string[] GetURLOnFile(string filename) => File.ReadAllLines(filename);
    }
}
