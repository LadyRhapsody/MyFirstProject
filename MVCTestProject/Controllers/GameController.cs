using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject.Controllers
{
    public class GameController : Controller
    {
        
        public ViewResult StartGame(string returnUrl)
        {

            return View();
            //return RedirectToAction("StartGame");
                
                //"Game", new {returnUrl});
        }
    }
}