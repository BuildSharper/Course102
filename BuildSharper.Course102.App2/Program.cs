//initialize the 10x10 array for the BattleShip game board, with ships 1, 2, 4, and 5
int[,] player1Board = new int[10, 10] {
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
    { 0, 4, 0, 0, 0, 0, 0, 0, 0, 0},
    { 0, 4, 0, 0, 0, 0, 0, 0, 0, 0},
    { 0, 4, 0, 0, 0, 2, 0, 0, 0, 0},
    { 0, 4, 0, 0, 0, 2, 0, 0, 0, 0},
    { 0, 0, 0, 0, 0, 2, 0, 0, 0, 0},
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    { 0, 0, 0, 5, 5, 5, 5, 5, 0, 0}
};

//let's manually place boat number 3 in row 1 column 10, row 2 column 10, and row 3 column 10
player1Board[0, 9] = 3;
player1Board[1, 9] = 3;
player1Board[2, 9] = 3;

//now let's display the board, i iterates through the rows
for (int i = 0; i < 10; i++)
{
    //j iterates through the columns
    for (int j = 0; j < 10; j++)
    {
        Console.Write(player1Board[i, j]);
    }

    //we've reached the end of this row, let's move to the cursor to the next line
    Console.Write("\r\n");
}