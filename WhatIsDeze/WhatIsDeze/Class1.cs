using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsDeze
{

    class TicTacToeEngine
    {

        Dictionary<int, string> dict = new Dictionary<int, string>()
                                            {
                                                {1,""},
                                                {2, ""},
                                                {3,""},
                                                {4,""},
                                                {5,""},
                                                {6,""},
                                                {7,""},
                                                {8,""},
                                                {9,""}
                                            };



        public enum GameStatus { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins }

        public GameStatus status = GameStatus.PlayerOPlays;

        public String board()
        {
            return dict.ToString();
        }

        public Boolean ChooseCell(int tni)
        {
            bool result = false;
            if (dict[tni] == "")
            {
                if (status == GameStatus.PlayerOPlays) { dict[tni] = "o"; }
                if (status == GameStatus.PlayerXPlays) { dict[tni] = "x"; }

                result = true;
            }

            return result;
        }

        public void reset()
        {
            dict = new Dictionary<int, string>()
                                            {
                                                {1,""},
                                                {2, ""},
                                                {3,""},
                                                {4,""},
                                                {5,""},
                                                {6,""},
                                                {7,""},
                                                {8,""},
                                                {9,""}
                                            };
            status = GameStatus.PlayerOPlays;


        }

        public String whosTurn()
        {
            String result = "";
            if (status == GameStatus.PlayerOPlays) { result =  "o"; }
            if (status == GameStatus.PlayerXPlays) { result =  "x"; }
            if (status == GameStatus.Equal) { result = "equal"; }
            return result;
        }

        public Boolean isThereAWinner()
        {
            Boolean result = false;
            String winner = "";

            if(dict[1] == dict[2] && dict[2] == dict[3] && dict[3] != "")
            {
                result = true;
                winner = dict[1];

            }
            if (dict[4] == dict[5] && dict[5] == dict[6] && dict[6] != "")
            {
                result = true;
                winner = dict[4];

            }
            if (dict[7] == dict[8] && dict[8] == dict[9] && dict[9] != "")
            {
                result = true;
                winner = dict[7];

            }
            if (dict[1] == dict[5] && dict[5] == dict[9] && dict[9] != "")
            {
                result = true;
                winner = dict[1];

            }
            if (dict[1] == dict[4] && dict[4] == dict[7] && dict[7] != "")
            {
                result = true;
                winner = dict[1];

            }
            if (dict[2] == dict[5] && dict[5] == dict[8] && dict[8] != "")
            {
                result = true;
                winner = dict[2];

            }
            if (dict[7] == dict[5] && dict[5] == dict[3] && dict[3] != "")
            {
                result = true;
                winner = dict[7];
            }
            if (dict[3] == dict[6] && dict[6] == dict[9] && dict[9] != "")
            {
                result = true;
                winner = dict[3];
            }
          
            if (winner == "")
            {
                if (dict.ContainsValue(""))
                {
                    if (status == GameStatus.PlayerOPlays) { status = GameStatus.PlayerXPlays; }
                    else if (status == GameStatus.PlayerXPlays) { status = GameStatus.PlayerOPlays; }
                }
                else
                {
                    winner = "equal";
                    status = GameStatus.Equal;
                    result = true;
                    
                }
            }
            Console.WriteLine(winner);

            return result;
        }
    }
}
