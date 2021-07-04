using System;
using System.Collections.Generic;
using System.Text;

namespace A1GurkiratSingh
{
    class BasketballPlayer:Player
    {

        private int fieldGoals;

        public int FieldGoals
        {
            get { return fieldGoals; }
            set { fieldGoals= value; }
        }

        private int threePointers;

        public int ThreePointers
        {
            get { return threePointers; }
            set { threePointers = value; }
        }

        public BasketballPlayer(string playerType, int playerId, String playerName, String teamName, int gamesPlayed, int fieldGoals, int threePointers) :
            base(playerType, playerId, playerName, teamName, gamesPlayed)
        {
            FieldGoals = fieldGoals;
            ThreePointers = threePointers;

        }

        public override int Points()
        {
            return (fieldGoals - threePointers) +(2 * threePointers);
        }

        public override string ToString()
        {
              

            return $"PlayerType:{PlayerType}  " +
               $"   Player Id:{PlayerId}  " +
               $"   Player Name:{PlayerName}  " +
               $"   Team Name:{TeamName}  " +
               $"   Games Played:{GamesPlayed}  " +
               $"  Field Goals:{fieldGoals}  " +
               $" Three Pointers:{threePointers}  " +
               $"   Points:{Points()}";

        }



    }
}
