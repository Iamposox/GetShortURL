using CutURL.Domain;
using System;

namespace ShortURL
{
    class Program
    {
        static void Main(string[] args)
        {
            CutUrl cutUrl = new CutUrl();
            var getUrlOnFile = cutUrl.GetURLOnFile("URL.txt");
            var shortUrl = cutUrl.GetShortURL(getUrlOnFile);
            for(int i=0; i< shortUrl.Length;i++)
            {
                Console.WriteLine($"{getUrlOnFile[i]} => {shortUrl[i]}");
            }
        }
    }
}
