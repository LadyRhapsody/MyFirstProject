using MVCTestProject.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject.Controllers
{
    public class GamesController : Controller
    {
        private IGamesRepository repository;

        public GamesController(IGamesRepository repo)
        {
            this.repository = repo;
        }
        public ViewResult GameList()
        {
            return View(repository.Games);
        }
    }
}