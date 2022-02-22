using System;

namespace NewspaperLibrary
{
    internal class ConsoleCreater
    {
        private NewspaperStore NewspaperStore { get; set; }

        public ConsoleCreater()
        {
            NewspaperStore newspaperStore = new NewspaperStore();
        }

        private void ProgramCreater()
        {
            while (true)
            {
                Console.WriteLine("Choose your status");
                Console.WriteLine("1. Publisher");
                Console.WriteLine("2. User");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.NumPad1:
                        PrintingHouse();
                        break;

                    case ConsoleKey.NumPad2:
                        break;
                }
            }
        }

        #region PrintingHouse
        private void PrintingHouse()
        {
            while (true)
            {
                Console.WriteLine("1. For Creat newspaper");
                Console.WriteLine("2. For Remove Newspaper");
                Console.WriteLine("For finish clik esc.");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.NumPad1:
                        CreatNewsPaper();
                        break;
                    case ConsoleKey.NumPad2:
                        RemoveNewspaper();
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }
        private void CreatNewsPaper()
        {
            Console.WriteLine("Add Newspapers Titel");
            string titel = Console.ReadLine();

            Console.WriteLine("Add Newspapers Content");
            string content = Console.ReadLine();

            Console.WriteLine("Add Page Count");
            int page = int.Parse(Console.ReadLine());

            INewspaper newspaper = new NewsPaper(titel, content, page);
            NewspaperStore.AddNewsPaper(newspaper);
        }

        private void RemoveNewspaper()
        {
            Console.WriteLine("Enter Newspapers Title");
            string title = Console.ReadLine();

            List<INewspaper> newspaperList = NewspaperStore.GiveNewspaperList();

            if (newspaperList is null)
            {
                PrintingHouse();
            }
            else
            {
                NewspaperStore.RemoveNewspaper(title);
            }
        }

        #endregion

        #region StorCreater
        public void StorCreater()
        {
            while(true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. ");

            }
        }

        #endregion

    }
}
