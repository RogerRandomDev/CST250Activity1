﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Cell
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        public bool CurrentlyOccupied { get; set; }

        public String occupyingPiece { get; set; }

        public bool LegalNextMove { get; set; }

        public Cell(int r, int c)
        {
            RowNumber = r;
            ColumnNumber = c;
            occupyingPiece = "Knight";
        }
        public Cell(int r, int c,String p)
        {
            RowNumber = r;
            ColumnNumber = c;
            occupyingPiece = p;
        }
    }
}
