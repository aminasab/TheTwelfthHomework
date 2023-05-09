using System.Collections.Immutable;

namespace Jack_sHouse
{
    internal class Part2
    {
        public ImmutableList<string>? Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> part2)
        {
            Poem = part2.Add("А это пшеница,\nКоторая в темном чулане хранится\n" +
                            "В доме,\nКоторый построил Джек.");
            return Poem;
        }
    }
}
