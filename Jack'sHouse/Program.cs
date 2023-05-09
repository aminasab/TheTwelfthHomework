using System.Collections.Immutable;

namespace Jack_sHouse
{
    internal class Program
    {
        private static readonly ImmutableList<string> Poem = ImmutableList.Create<string>();

        static void Main(string[] args)
        {
            Part1 part1 = new();
            Part2 part2 = new();
            Part3 part3 = new();
            Part4 part4 = new();
            Part5 part5 = new();
            Part6 part6 = new();
            Part7 part7 = new();
            Part8 part8 = new();
            Part9 part9 = new();
            var final = part9.AddPart(part8.AddPart(
                part7.AddPart(part6.AddPart(
                    part5.AddPart(part4.AddPart(
                        part3.AddPart(part2.AddPart(part1.AddPart(Poem)))))))));
            Console.WriteLine("          Часть 1          ");
            PrintImmutableList(part1.Poem!);
            Console.WriteLine("          Часть 2          ");
            PrintImmutableList(part2.Poem!);
            Console.WriteLine("          Часть 3          ");
            PrintImmutableList(part3.Poem!);
            Console.WriteLine("          Часть 4          ");
            PrintImmutableList(part4.Poem!);
            Console.WriteLine("          Часть 5          ");
            PrintImmutableList(part5.Poem!);
            Console.WriteLine("          Часть 6          ");
            PrintImmutableList(part6.Poem!);
            Console.WriteLine("          Часть 7          ");
            PrintImmutableList(part7.Poem!);
            Console.WriteLine("          Часть 8          ");
            PrintImmutableList(part8.Poem!);
            Console.WriteLine("          Часть 9          ");
            PrintImmutableList(part9.Poem!);
            Console.WriteLine("          Конец            ");
            PrintImmutableList(Poem);
        }

        private static void PrintImmutableList(ImmutableList<string> immutableList)
        {
            immutableList.ForEach(Console.WriteLine);
        }
    }
}