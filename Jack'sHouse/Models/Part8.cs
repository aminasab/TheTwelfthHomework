using System.Collections.Immutable;

namespace Jack_sHouse
{
    internal class Part8
    {
        public ImmutableList<string>? Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> part8)
        {
            Poem = part8.Add("А это ленивый и толстый пастух,\nКоторый бранится с коровницей строгою,\nКоторая доит корову безрогую,\nЛягнувшую старого пса без хвоста,\n" +
                "Который за шиворот треплет кота,\nКоторый пугает и ловит синицу,\n" +
                "Которая часто ворует пшеницу,\nКоторая в темном чулане хранится\n" +
                "В доме,\nКоторый построил Джек.");
            return Poem;
        }
    }
}
