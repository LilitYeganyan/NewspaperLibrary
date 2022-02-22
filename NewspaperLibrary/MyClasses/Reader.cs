using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperLibrary
{
    internal class Reader : IReader
    {
        public string Path { get; set; }
        public int PhonNumber { get; set; }
        public string Name { get; set; }
        public DateTime SubscribDate { get; set; }
        public INewspaperManager NewsPaperManager { get; set; }

        public Reader(string path, int PhonNumber, string name)
        {
            this.Path = path;
            this.PhonNumber = PhonNumber;
            this.Name = name;
            this.SubscribDate = DateTime.Now;
        }
        private void SoweToReaderNews(object manager, NewspaperPublishEventArgs args)
        {
            Console.WriteLine("New Post");
        }
        private void SubscribetoTheCompany()
        {
            NewsPaperManager.NewspaperPublished += SoweToReaderNews;
        }
    }
}
