using System;
using System.Collections.Generic;
using System.Text;

namespace A1GurkiratSingh
{
    class HockeyPlayer:Player
    {

        private int assist;

        public int Assist
        {
            get { return assist; }
            set { assist = value; }
        }

        private int goals;

        public int Goals
        {
            get { return goals; }
            set { goals = value; }
        }

        public HockeyPlayer(String playerType, int playerId, String playerName, String teamName, int gamesPlayed,int assist,int goals):
            base(playerType,playerId,playerName,teamName,gamesPlayed)
        {
            Assist = assist;
            Goals = goals;
        
        }

        public override int Points()
        {
            return assist + (2 * goals);
        }

        public override string ToString()
        {




            return $"PlayerType:{PlayerType}  " +
                $"   Player Id:{PlayerId}  " +
                $"   Player Name:{PlayerName}  " +
                $"   Team Name:{TeamName}  " +
                $"   Games Played:{GamesPlayed}  " +
                $"   Assist:{Assist}  " +
                $"   Goals:{goals}  " +
                $"   Points:{Points()}  ";
                



        }


    }
}
