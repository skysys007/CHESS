using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public class Pawn:Piece
    {
        public override PieceType Type => PieceType.Pawn; // from enum class
        public override Player Color { get; }
        public Pawn(Player color)
        {
            Color = color;
        }
        public override Piece Copy()
        {
            Pawn copy = new Pawn(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
