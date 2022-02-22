using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperLibrary
{
    internal class NewspaperStore
    {
        private List<INewspaper> NewspapersList { get; set; }
        private INewspaperManager StoreManager { get; set; }
        private List<IReader> ReaderList { get; set; }
        public NewspaperStore()
        {
            StoreManager = new NewsPaperManager();
            NewspapersList = new List<INewspaper>();
        }

        public void AddNewsPaper(INewspaper newspaper)
        {
            StoreManager.PublishNewspaper(newspaper);
            NewspapersList.Add(newspaper);
        }
        public void RemoveNewspaper(string title)
        {

            List<INewspaper> list = new List<INewspaper>();
            int index = 0;
            for (int i = 0; i < NewspapersList.Count; i++)
            {
                if (title == NewspapersList[i].Title)
                {
                    continue;
                }
                list[index] = NewspapersList[i];
                index++;
            }
            NewspapersList = list;
        }

        public List<INewspaper> GiveNewspaperList()
        {
            List<INewspaper> list = new List<INewspaper>();
            list = this.NewspapersList;
            return list;
        }

        public void AddReader(IReader reader)
        {
            ReaderList.Add(reader);
        }

        public void RemoveReader(string name, int number)
        {            
            List<IReader> list = new List<IReader>();
            int index = 0; 
            
            for(int i=0; i<list.Count; i++)
            {
                if(name == ReaderList[i].Name && number == ReaderList[i].PhonNumber)
                {
                    continue;
                }
                else
                {
                    list[index] = ReaderList[i];
                }
                index++;
            }
            ReaderList = list;
        }
    }
}
