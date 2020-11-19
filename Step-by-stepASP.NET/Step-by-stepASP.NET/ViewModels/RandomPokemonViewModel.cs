using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Step_by_stepASP.NET.Models;

namespace Step_by_stepASP.NET.ViewModels
{
    public class RandomPokemonViewModel
    {
        public Pokemon Pokemon { get; set; }
        public List<Battler> Battlers { get; set; }
    }
}