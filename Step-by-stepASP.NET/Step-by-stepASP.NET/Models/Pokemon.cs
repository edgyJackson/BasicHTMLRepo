using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Step_by_stepASP.NET.Models
{
    public class Pokemon
    {
        public int pokedexID { get; set; }
        public string Name { get; set; }

        public string pType { get; set; }

        public string sType { get; set; }
    }
}