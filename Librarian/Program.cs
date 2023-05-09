using System.Collections.Concurrent;

namespace Librarian
{
    internal class Program
    {
        private static readonly ConcurrentDictionary<string, int> _books = new();

        public static void Main(string[] args)
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    foreach (var book in _books)
                    {
                        if (book.Value < 100)
                        {
                            _books[book.Key] = book.Value + 1;
                        }
                        else
                        {
                            _books.TryRemove(book);
                        }
                    }
                }
            });
            while (true)
            {
                ShowMenu();

                var userChoice = Console.ReadLine() ?? "";
                switch (userChoice)
                {
                    case "1":
                        InputBook();
                        break;
                    case "2":
                        PrintUnread();
                        break;
                    case "3":
                        Exit();
                        break;
                }
            }
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void PrintUnread()
        {
            foreach (var book in _books)
            {
                Console.WriteLine($"{book.Key} - {book.Value}%");
            }
        }

        public static void InputBook()
        {
            Console.Write("Введите название книги: ");
            var book = Console.ReadLine();
            _books.TryAdd(book!, 0);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Нажмите клавишу для выбора:\n" +
                "1 - добавить книгу;\n" +
                "2 - вывести список непрочитанного;\n" +
                "3 - выйти.");
        }
    }
}