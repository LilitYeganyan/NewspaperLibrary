using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperLibrary
{
    internal class NewsPaper : INewspaper
    {
        public DateTime PublishDate { get;}

        public string Title { get; set; }

        public string Content { get; set; }

        public int PageCount { get; set; }

        public NewsPaper( string title, string content, int pageCount)
        {
            this.PublishDate = DateTime.Now;
            this.Title = title;
            this.Content = content;
            this.PageCount = pageCount;
        }
    }
}
