using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperLibrary
{
    internal interface INewspaper
    {
        DateTime PublishDate { get; }
        string Title { get; }
        string Content { get; }
        int PageCount { get; }

 
    }
}
