
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using ChessBoardModel;
internal class Program
{
    static Board myBoard = new Board(8);
    private static void Main(string[] args)
    {
        //show chesboard
        printGrid(myBoard);
        //get location of the piece
        Cell myLocation = setCurrentCell();
        //calculate and mark legal moves
        myBoard.MarkNextLegalMoves(myLocation);
        //show the board for . for empty X for a location
        // + for legal moves
        printGrid(myBoard);
        // Wait for another return key to exit prorgram
        Console.ReadLine();
    }
    static public void printGrid(Board myBoard)
    {
        string spacer_bar = "";
        for(int i = 0; i < myBoard.Size; i++)
        {
            spacer_bar += "+---";
        }
        spacer_bar += "+";

        for(int i = 0; i < myBoard.Size; i++)
        {
            Console.WriteLine(spacer_bar);
            for(int j = 0; j <myBoard.Size; j++)
            {
                String txt = ".";
                if (myBoard.theGrid[i, j].CurrentlyOccupied)
                {
                    txt="X";
                }
                else if (myBoard.theGrid[i, j].LegalNextMove)
                {
                    txt="+";
                }
                Console.Write("| "+txt+" "+(j==myBoard.Size-1?"|":""));
            }
            Console.WriteLine();
        }
        Console.WriteLine(spacer_bar);
        Console.WriteLine("=========================================================");
    }
    static public int getNumberInput(String display_text,int min_val=0,int max_val=999999999)
    {
        while (true)
        {
            Console.Out.Write(display_text);
            string check = Console.ReadLine();
            int output_num = 0;
            if (!int.TryParse(check,out output_num)) { Console.Out.WriteLine("input not a valid number"); continue; }
            if (output_num < min_val || output_num > max_val) { Console.Out.WriteLine(String.Format("input number must be within range of {0}-{1}",min_val.ToString(),max_val.ToString())); continue; }
            return output_num;
        }
    }
    static public string getPiece()
    {
        string[] piece_names = ["Queen", "Knight", "Rook", "King", "Bishop"];
        while (true)
        {
            Console.Out.Write("Enter your piece name(Queen,Knight,Rook,King,Bishop)");
            string check = Console.ReadLine();
            if (!piece_names.Contains(check)) { Console.WriteLine("Invalid Piece name"); continue; }
            return check;
        }
    }

    static public Cell setCurrentCell()
    {
        int currentRow = getNumberInput("enter your current row number ",0,myBoard.Size-1);
        int currentCol = getNumberInput("Enter your current column number ", 0, myBoard.Size - 1);
        string currentPiece = getPiece();
        myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;
        myBoard.theGrid[currentRow, currentCol].occupyingPiece = currentPiece;
        return myBoard.theGrid[currentRow, currentCol];
    }
}