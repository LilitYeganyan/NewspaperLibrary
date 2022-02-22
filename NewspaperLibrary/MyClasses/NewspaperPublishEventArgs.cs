using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperLibrary
{
    internal class NewspaperPublishEventArgs: EventArgs
    {
        INewspaper Newspaper { get; }
        public NewspaperPublishEventArgs(INewspaper newsPaper)
        {
            this.Newspaper = newsPaper;
        }
    }
}
