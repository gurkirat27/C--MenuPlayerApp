using System;
using System.Collections.Generic;
using System.Text;

namespace A1GurkiratSingh
{
    abstract class Player
    {

        private String playerType;

        public String PlayerType
        {
            get { return playerType; }
            set { playerType = value; }
        }


        private int playerId;

        public int PlayerId
        {
            get { return playerId; }
            set { playerId = value; }
        }

        private String playerName;

        public String PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }


        private String teamName;

        public String TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }


        private int gamesPlayed;

        public int GamesPlayed
        {
            get { return gamesPlayed; }
            set { gamesPlayed = value; }
        }


        public Player(String playerType,int playerId,String playerName,String teamName, int gamesPlayed) {

            PlayerType = playerType;
            PlayerId = playerId;
            PlayerName = playerName;
            TeamName = teamName;
            GamesPlayed = gamesPlayed;

      }

        public abstract int Points();


    }
}
