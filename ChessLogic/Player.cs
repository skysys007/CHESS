using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public enum Player
    {
        None,// incase of a draw - winning player
        Black,
        White

    }
    public static class PlayerExtensions
    {
        // takes a player as param and returns the opponent
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.Black,
                _ => Player.None, //default 
            };
        }
    }
}
