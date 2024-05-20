using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] theGrid;
        
        public Board(int s)
        {
            Size = s;
            theGrid = new Cell[Size, Size];
            for(int i = 0; i < Size; i++)
            {
                for(int j=0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece="NONE")
        {
            if (chessPiece == "NONE"){chessPiece = currentCell.occupyingPiece;}
            for(int r=0;r<Size;r++)
            {
                for(int c = 0; c < Size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                }
            }
            switch (chessPiece)
            {
                case "Knight":
                    setGridCellLegal(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1, true);
                    setGridCellLegal(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1, true);
                    setGridCellLegal(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1, true);
                    setGridCellLegal(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1, true);
                    setGridCellLegal(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2, true);
                    setGridCellLegal(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2, true);
                    setGridCellLegal(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2, true);
                    setGridCellLegal(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2, true);
                    break;
                case "King":
                    setGridCellLegal(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1, true);
                    setGridCellLegal(currentCell.RowNumber, currentCell.ColumnNumber + 1, true);
                    setGridCellLegal(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1, true);
                    setGridCellLegal(currentCell.RowNumber + 1, currentCell.ColumnNumber, true);
                    setGridCellLegal(currentCell.RowNumber - 1, currentCell.ColumnNumber, true);
                    setGridCellLegal(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1, true);
                    setGridCellLegal(currentCell.RowNumber, currentCell.ColumnNumber - 1, true);
                    setGridCellLegal(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1, true);
                    break;
                case "Rook":
                    for(int i = 0; i < Size; i++)
                    {
                        setGridCellLegal(currentCell.RowNumber, i, true);
                        setGridCellLegal(i, currentCell.ColumnNumber, true);
                    }


                    break;
                case "Bishop":
                    for (int i = 0; i < Size; i++)
                    {
                        setGridCellLegal(currentCell.RowNumber + i, currentCell.ColumnNumber + i, true);
                        setGridCellLegal(currentCell.RowNumber - i, currentCell.ColumnNumber + i,true);
                        setGridCellLegal(currentCell.RowNumber + i, currentCell.ColumnNumber - i,true);
                        setGridCellLegal(currentCell.RowNumber - i, currentCell.ColumnNumber - i,true);
                    }
                    break;
                case "Queen":
                    for (int i = 0; i < Size; i++)
                    {
                        setGridCellLegal(currentCell.RowNumber + i, currentCell.ColumnNumber + i, true);
                        setGridCellLegal(currentCell.RowNumber - i, currentCell.ColumnNumber + i, true);
                        setGridCellLegal(currentCell.RowNumber + i, currentCell.ColumnNumber - i, true);
                        setGridCellLegal(currentCell.RowNumber - i, currentCell.ColumnNumber - i, true);

                        setGridCellLegal(currentCell.RowNumber, i, true);
                        setGridCellLegal(i, currentCell.ColumnNumber, true);
                    }
                    break;
                default:
                    break;
            }

        }
        public void setGridCellLegal(int x,int y,bool value)
        {
            if (!(x< Size && x >= 0 && y < Size && y >= 0)) return;
            theGrid[x,y].LegalNextMove = value;
        }

    }
}
