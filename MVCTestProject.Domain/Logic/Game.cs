using MVCTestProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestProject.Domain.Logic
{
    public class Game
    {
        public GameBase ActualGame { get; set; }

        public void StartGame(GameBase gameb)
        {
            ActualGame = gameb;
        }
    }
}
