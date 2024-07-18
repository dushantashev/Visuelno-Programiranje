using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class GameForTicket
    {
        public Game Game { get; set; }
        public String tip {  get; set; }

        public GameForTicket(Game game, String tip)
        {
            Game = game;
            this.tip = tip;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}-{2} {3}",Game.Code,Game.Home,Game.Guest,tip);

        }
    }
}
