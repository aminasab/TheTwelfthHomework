using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack_sHouse
{
    internal class Part1
    {
        public ImmutableList <string>? Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> part1)
        {
            Poem = part1.Add("Вот дом,\nКоторый построил Джек.");
            return Poem;
        }
    }
}
