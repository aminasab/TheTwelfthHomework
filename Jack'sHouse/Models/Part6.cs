using System.Collections.Immutable;

namespace Jack_sHouse
{
    internal class Part6
    {
        public ImmutableList<string>? Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> part6)
        {
            Poem = part6.Add("А это корова безрогая,\nЛягнувшая старого пса без хвоста,\n" +
                "Который за шиворот треплет кота,\nКоторый пугает и ловит синицу,\n" +
                "Которая часто ворует пшеницу,\nКоторая в темном чулане хранится\n" +
                "В доме,\nКоторый построил Джек.");
            return Poem;
        }
    }
}
