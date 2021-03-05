using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramOMatic
{
    class InputItem
    {
        public string Name { get; set; }
        public int Value { get; set; }
        [System.ComponentModel.DisplayName("Type")]
        public PokemonType PokemonType { get; set; }

        public InputItem(PokemonType pokemonType, int value, string name)
        {
            PokemonType = pokemonType;
            Value = value;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public static int CompareName(InputItem value1, InputItem value2)
        {
            return value1.Name.CompareTo(value2.Name);
        }

        public static int CompareValueDesc(InputItem value1, InputItem value2)
        {
            return value2.Value.CompareTo(value1.Value);
        }
    }
}
