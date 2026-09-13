using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public class Direction

    {
        public readonly static Direction North = new Direction(-1, 0);
        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthWest = South + West;
        // we represent Direction as row Delta and col Delta i.e the change in row and column positions
        public int RowDelta { get;}
        public int ColumnDelta { get;}

        public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta; 
        }

        // Overriding the + Binary Operator to add two delta or directions together
        public static Direction operator +(Direction dir1, Direction dir2)
        {
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta);
        }

        // Overriding the * operator so that we can scale the delta or direction
        public static Direction operator *(int Scalar, Direction dir) { 
            return new Direction(Scalar * dir.RowDelta, Scalar * dir.ColumnDelta); 
        }

        //
    }
}
