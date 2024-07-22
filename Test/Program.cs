using System;

class Program
{
    static public void masuhanntei(ref char[,] board, int oy, int ox)
    {
        bool right = false;
        bool left = false;
        bool up = false;
        bool down = false;

        if (ox + 1 >= board.GetLength(1))
        {
            right = true;
        }
        else if (board[oy, ox + 1] == '#')
        {
            right = true;
        }
       
        if (ox - 1 < 0)
        {
            left = true;
        }
        else if (board[oy, ox - 1] == '#')
        {
            left = true;
        }
        
        if (oy + 1 >= board.GetLength(0))
        {
            down = true;
        }
        else if (board[oy + 1, ox] == '#')
        {
            down = true;
        }
        
        if (oy - 1 < 0)
        {
            up = true;
        }
        else if (board[oy - 1, ox] == '#')
        {
            up = true;
        }

        if ( right && left && up && down)
        {
            Console.WriteLine(oy + " " + ox);
        }
    }

    static public void Main()
    {
        // 標準入力からの読み取り
        string[] inputs = Console.ReadLine().Split();
        int H = int.Parse(inputs[0]);
        int W = int.Parse(inputs[1]);

        // 盤面の読み取り
        char[,] board = new char[H, W];
        for (int i = 0; i < H; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < W; j++)
            {
                board[i, j] = line[j];
            }
        }

        for (int i = 0; i < H; i++)
        {
            for (int j = 0; j < W; j++)
            {
                masuhanntei(ref board, i, j);
            }
        }
    }
}