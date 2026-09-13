using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public class Board
    {
        // array to store pieces in the board
        private readonly Piece[,] pieces = new Piece[8, 8];

        // Access pieces from an indexer like a 2d array
        public Piece this[int row, int col]
        {
            get { return pieces[row, col]; }
            set { pieces[row, col   ] = value; }
        }

        //Indexer for position 
        public Piece this[Position pos]
        {
            get { return this[pos.Row, pos.Column]; }
            set { this[pos.Row, pos.Column] = value; }
        }

        public static Board Initial()
        {
            Board board = new Board();
            board.AddStartPieces();
            return board;
        }

        // Method to initialize start pieces
        private void AddStartPieces()
        {
            //BLACK PIECES
            this[0, 0] = new Rook(Player.Black); 
            this[0, 1] = new Knight(Player.Black); 
            this[0, 2] = new Bishop(Player.Black); 
            this[0, 3] = new Queen(Player.Black); 
            this[0, 4] = new King(Player.Black); 
            this[0, 5] = new Bishop(Player.Black); 
            this[0, 6] = new Knight(Player.Black); 
            this[0, 7] = new Rook(Player.Black); 
            //WHITE PIECES

            this[7, 0] = new Rook(Player.White); 
            this[7, 1] = new Knight(Player.White); 
            this[7, 2] = new Bishop(Player.White); 
            this[7, 3] = new Queen(Player.White); 
            this[7, 4] = new King(Player.White); 
            this[7, 5] = new Bishop(Player.White); 
            this[7, 6] = new Knight(Player.White); 
            this[7, 7] = new Rook(Player.White); 

            for (int i = 0; i < 8; i++)
            {
                this[1, i] = new Pawn(Player.Black);
                this[6, i] = new Pawn(Player.White);
            }
        }

    }
}
