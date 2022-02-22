using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperLibrary
{
    internal interface IReader
    {
        string Path { get; set; }
        int PhonNumber { get; set; }
        string Name { get; set; }
        DateTime SubscribDate { get; set; }
        INewspaperManager NewsPaperManager { get; }



    }
}
