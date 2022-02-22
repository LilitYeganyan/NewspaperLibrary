using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperLibrary
{
    internal class NewsPaperManager : INewspaperManager
    {
        public event EventHandler<NewspaperPublishEventArgs> NewspaperPublished;

        public void PublishNewspaper(INewspaper newsPaper)
        {
            NewspaperPublishEventArgs args = new NewspaperPublishEventArgs(newsPaper);
            Console.WriteLine("Newspaper is publish");
            string DatTime = newsPaper.PublishDate.ToString();
            Console.WriteLine(DatTime);
            NewspaperPublished.Invoke(this, args);
        }        
    }
}
