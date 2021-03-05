using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramOMatic
{
    class OutputItem
    {
        public PokemonType PokemonType { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Name { get; set; }

        public OutputItem(PokemonType pokemonType, int min, int max, string name)
        {
            PokemonType = pokemonType;
            Min = min;
            Max = max;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public static int CompareName(OutputItem value1, OutputItem value2)
        {
            return value1.Name.CompareTo(value2.Name);
        }
    }
}
