using MVCTestProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestProject.Domain.Logic
{
    public class FourInARow :Game
    {
        public List<int> GameGround { get; set; }
        public List<FourInARowTocken> tockens { get; set; }
        public FourInARow(GameBase gameprop)
        {
            ActualGame = gameprop;
            Player = new List<Player> {
            new Player { Name = "Spieler1", PlayerId= 1},
            new Player { Name= "Spieler2", PlayerId=2}
            };

            GameGround = new List<int>();
            for(int i =1; i<= 6 * 7; i++)
            {
                GameGround.Add(i);
            }

        }
    }
}
