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

            return game;
        }
    }
}