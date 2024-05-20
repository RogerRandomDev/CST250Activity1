using ChessBoardModel;

namespace ChessBoardGuiApp
{
    public partial class Form1 : Form
    {
        static public Board myBoard = new Board(8);
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }
        public void populateGrid() {
            int buttonSize = panel1.Width / myBoard.Size;
            panel1.Height = panel1.Width;
            for(int r = 0; r < myBoard.Size; r++)
            {
                for(int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c] = new Button();
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;
                    btnGrid[r, c].Click += Grid_Button_Click;
                    panel1.Controls.Add(btnGrid[r, c]);
                    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c);

                    btnGrid[r, c].Text = r.ToString() + "|" + c.ToString();

                    btnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();

                }
            }
        }

        private void Grid_Button_Click(object? sender, EventArgs e)
        {
            string[] strArr = (sender as Button).Tag.ToString().Split("|");
            int r = int.Parse(strArr[0]);
            int c = int.Parse(strArr[1]);
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    myBoard.theGrid[i,j].CurrentlyOccupied = false;
                }
            }
            
            
            Cell currentCell = myBoard.theGrid[r, c];
            if (comboBox1.SelectedIndex<0)
            {
                currentCell.occupyingPiece = "Knight";
                currentCell.CurrentlyOccupied = true;
            }
            else
            {
                currentCell.occupyingPiece = comboBox1.Items[comboBox1.SelectedIndex] as String;
                currentCell.CurrentlyOccupied = true;
            }
            myBoard.MarkNextLegalMoves(currentCell);
            updateButtonLabels();

            for(int i = 0; i < myBoard.Size; i++)
            {
                for(int j=0;j< myBoard.Size; j++)
                {
                    btnGrid[i, j].BackColor = default(Color);
                }
            }

            (sender as Button).BackColor = Color.Cornsilk;

        }
        public void updateButtonLabels()
        {
            for ( int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c].Text = "";
                    if (myBoard.theGrid[r, c].LegalNextMove) btnGrid[r, c].Text = "Legal";
                    if (myBoard.theGrid[r, c].CurrentlyOccupied) btnGrid[r, c].Text = myBoard.theGrid[r, c].occupyingPiece;
                }
            }
        }
    }
}
