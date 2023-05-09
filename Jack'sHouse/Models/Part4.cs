using System.Collections.Immutable;

namespace Jack_sHouse
{
    internal class Part4
    {
        public ImmutableList<string>? Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> part4)
        {
            Poem = part4.Add("Вот кот,\nКоторый пугает и ловит синицу,\n" +
                "Которая часто ворует пшеницу,\n" +
                "Которая в темном чулане хранится\n" +
                "В доме,\nКоторый построил Джек.");
            return Poem;
        }
    }
}
