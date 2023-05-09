using System.Collections.Immutable;

namespace Jack_sHouse
{
    internal class Part5
    {
        public ImmutableList<string>? Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> part5)
        {
            Poem = part5.Add("Вот пес без хвоста,\nКоторый за шиворот треплет кота,\n" +
                "Который пугает и ловит синицу,\nКоторая часто ворует пшеницу,\n" +
                "Которая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
            return Poem;
        }
    }
}
