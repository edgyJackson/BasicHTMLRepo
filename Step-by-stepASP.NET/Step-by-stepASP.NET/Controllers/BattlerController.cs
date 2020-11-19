using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Step_by_stepASP.NET.Models;

namespace Step_by_stepASP.NET.Controllers
{
    public class BattlerController : Controller
    {


        private IList<SelectListItem> stateSelectList = new List<SelectListItem>
        {
            new SelectListItem {Value ="OR", Text="Oregon", Selected=true},
            new SelectListItem {Value ="WA", Text="Washington"},
            new SelectListItem {Value ="CA", Text="California"},
            new SelectListItem {Value ="ID", Text="Idaho"}
        };
        
        // GET: Battler
        public ActionResult Index()
        {
            ViewBag.StateList = stateSelectList;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string gamertag, string lastname, int? age, string state)
        {

            if (ModelState.IsValid)
            {
                int a = age.GetValueOrDefault();
                IList<Battler> output = new List<Battler>();

                int id = 0;
                for(int i= 0; i < a; i++) 
                {
                    output.Add(new Battler { gamerTag = gamertag, lastName =lastname, state =state, age = i, Id = id });
                    id++;
                }

                ViewBag.BattlerList = output;
                ViewBag.Success = true;
                ViewBag.StateList = stateSelectList;
                return View();
            }

            else
            {
                return RedirectToAction( "Index","Home");
            }
        }
    }
}