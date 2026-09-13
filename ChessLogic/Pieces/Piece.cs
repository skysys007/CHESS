namespace ChessLogic
{
    // base class that all concrete pieces will inherit from
    public abstract class Piece
    {
        public abstract PieceType Type { get; }
        public abstract Player Color {  get; }
        // we need has moved as some moves are only legal if the pieces have not moved
        public bool HasMoved { get; set; } = false; 
        public abstract Piece Copy();
    }
}
