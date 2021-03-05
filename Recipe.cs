using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramOMatic
{
    class Recipe
    {
        [System.ComponentModel.DisplayName("First Input")]
        public InputItem FirstInput { get; set; }

        [System.ComponentModel.DisplayName("Second Input")]
        public InputItem SecondInput { get; set; }

        [System.ComponentModel.DisplayName("Third Input")]
        public InputItem ThirdInput { get; set; }

        [System.ComponentModel.DisplayName("Fourth Input")]
        public InputItem FourthInput { get; set; }
        public OutputItem Output { get; set; }

        public Recipe(InputItem input1, InputItem input2, InputItem input3, InputItem input4, OutputItem output)
        {
            FirstInput = input1;
            SecondInput = input2;
            ThirdInput = input3;
            FourthInput = input4;
            Output = output;
        }
    }
}
