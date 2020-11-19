using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Step_by_stepASP.NET.Models;
using Step_by_stepASP.NET.ViewModels;


namespace Step_by_stepASP.NET.Controllers
{
    public class PokemonsController : Controller
    {
        // GET: Pokemons
        public ActionResult Random()
        {
            var pokemon = new Pokemon() { Name = "Lucario" };
            //ViewData["Pokemon"] = pokemon;
            //ViewBag.Pokemon = pokemon;
            var battlers = new List<Battler>
            {
                //new Battler {Name = "CPULV1"},
                //new Battler {Name = "Red2green"}
            };

            var viewModel = new RandomPokemonViewModel
            {
                Pokemon = pokemon,
                Battlers = battlers
        };
            return View(viewModel);
            //return Content("Welcome to the Battle!!");
            //return new EmptyResult();
            //return HttpNotFound();

           // return RedirectToAction("Index", "Home", new { page = 1, sortby = "Name"});
        
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex = {0} and sortBy = {1}", pageIndex, sortBy));
        }

        [Route("pokemons/types/{Primary}/{Secondary}")]

         public ActionResult byPrimaryType(string Primary, string Secondary)
        {
            return Content(Primary + ", " + Secondary);
        }


    }

    
}