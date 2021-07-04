using System;
using System.Collections.Generic;
using System.Text;

namespace A1GurkiratSingh
{
    class BaseballPlayer:Player
    {


        private int runs;

        public int Runs
        {
            get { return runs; }
            set {runs = value; }
        }

        private int homeRuns;

        public int HomeRuns
        {
            get { return homeRuns; }
            set { homeRuns = value; }
        }

        public BaseballPlayer(String playerType, int playerId, String playerName, String teamName, int gamesPlayed, int runs, int homeRuns) :
            base(playerType, playerId, playerName, teamName, gamesPlayed)
        {
            Runs = runs;
            HomeRuns = homeRuns;

        }

        public override int Points()
        {
            return (runs - homeRuns) +(2 * homeRuns);
        }

        public override string ToString()
        {
           

            return $"PlayerType:{PlayerType}  " +
        $"   Player Id:{PlayerId}  " +
        $"   Player Name:{PlayerName}  " +
        $"   Team Name:{TeamName}  " +
        $"   Games Played:{GamesPlayed}  " +
        $"  Runss:{runs}  " +
        $" Home Runs:{homeRuns}  " +
        $"   Points:{Points()}";

        }
    }
}
