namespace RegularCustomer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new();
            Customer customer = new();
            customer.Subscribe(shop);
            Console.WriteLine("Команды для управления программой:\n" +
                "A - добавить товар\n" +
                "D - удалить товар\n" +
                "X - выход из программы");
            while (true)
            {
                var key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        shop.Add($"Товар от {DateTime.Now}");
                        break;
                    case ConsoleKey.D:
                        Console.Write("Введите Id товара для удаления: ");
                        if (int.TryParse(Console.ReadLine(), out var idForDelete))
                        {
                            shop.Remove(idForDelete);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный Id для удаления");
                        }
                        break;
                    case ConsoleKey.X:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}