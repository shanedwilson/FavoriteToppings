using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FavoriteToppings
{
    class Pizza
    {
        public List<string> Toppings { get; set; }

        public override string ToString()
        {
            return string.Join(", ", Toppings);
        }



    }
}
