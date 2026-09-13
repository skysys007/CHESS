namespace ChessLogic
{
    // this class represents position or square on the board
    public class Position
    {
        // row and column props
        public int Row { get; }
        public int Column { get; }

        // Constructor which takes a row and a column and stores it in the props
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        //square color method to verify the square color which returns a player value as we use player to represent colors
        public Player SquareColor()
        {
            if ((Row+Column)%2 == 0)
            {
                return Player.White;
            }
            return Player.Black;
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        // method that takes current position and given Direction as parameters and returns the new position
        public static Position operator +(Position pos, Direction dir) {
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta); 
            
        }
    }
}
