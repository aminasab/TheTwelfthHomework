using System.Collections.Immutable;

namespace Jack_sHouse
{
    internal class Part7
    {
        public ImmutableList<string>? Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> part7)
        {
            Poem = part7.Add("А это старушка, седая и строгая,\nКоторая доит корову безрогую,\n" +
                "Лягнувшую старого пса без хвоста,\nКоторый за шиворот треплет кота,\n" +
                "Который пугает и ловит синицу,\nКоторая часто ворует пшеницу,\n" +
                "Которая в темном чулане хранится\nВ доме\nКоторый построил Джек.");
            return Poem;
        }
    }
}
