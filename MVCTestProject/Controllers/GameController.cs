using MVCTestProject.Domain.Abstract;
using MVCTestProject.Domain.Entities;
using MVCTestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject.Controllers
{
    public class GameController : Controller
    {
        private IGamesRepository repository;

        public GameController(IGamesRepository repo)
        {
            repository = repo;
        }

        public ViewResult Game(GameBase game)
        {
            return View(new GameViewModel {MyGame= game });
        }
        public RedirectToRouteResult StartGame(int gameID ,string returnUrl)
        {
            GameBase game = repository.Games.FirstOrDefault(p => p.GameId == gameID);
            


            return RedirectToAction("Game", game);     
        }
    }
}