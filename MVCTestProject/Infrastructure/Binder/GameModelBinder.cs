using MVCTestProject.Domain.Entities;
using MVCTestProject.Domain.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject.Infrastructure.Binder
{
    public class GameModelBinder : IModelBinder
    {
        private const string sessionKey = "Game";
        
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Game game = null;
            if (controllerContext.HttpContext.Session != null)
            {
                game = (Game)controllerContext.HttpContext.Session[sessionKey];
            }
                if (game == null)
            {
                
                game = new Game();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = game;
                }
            }

            return game;
        }
    }
}