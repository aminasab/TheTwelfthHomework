using System.Collections.Immutable;

namespace Jack_sHouse
{
    internal class Part3
    {
        public ImmutableList<string>? Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> part3)
        {
            Poem = part3.Add("А это веселая птица-синица,\n" +
                "Которая часто ворует пшеницу,\n" +
                "Которая в темном чулане хранится\n" +
                "В доме,\nКоторый построил Джек.");
            return Poem;
        }
    }
}
