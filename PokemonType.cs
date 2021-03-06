using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramOMatic
{
    class PokemonType
    {
        public string Name { get; set; }
        public Color DisplayColor { get; set; }
        public PokemonTypeEnum Id { get; set; }

        public PokemonType(string name, Color color, PokemonTypeEnum id)
        {
            Name = name;
            DisplayColor = color;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
