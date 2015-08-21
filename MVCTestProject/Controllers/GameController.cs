using MVCTestProject.Domain.Abstract;
using MVCTestProject.Domain.Entities;
using MVCTestProject.Domain.Logic;
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

        public ViewResult Game(Game game)
        {
            return View(game);
        }
        public RedirectToRouteResult StartGame(Game game, int gameID ,string returnUrl)
        {
            GameBase gameb = repository.Games.FirstOrDefault(p => p.GameId == gameID);

            game.StartGame(gameb);


            return RedirectToAction("Game", game);     
        }
    }
}