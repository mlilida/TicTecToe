using System;
using TicTecToe;

Console.WriteLine("=== 틱택토 게임 · 1단계 ===");
Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
Console.WriteLine();
Console.WriteLine("위치번호:");

Board board = new Board();
board.ShowLocation();
Console.WriteLine();

string[] input = new string[9];
for (int i = 0; i < 9; i++)
{
    input[i] = ".";
}

Console.WriteLine("현재 보드:");
board.ShowGameBoard(input);
Console.WriteLine();
Console.WriteLine("플레이어 X의 차례입니다.");


for (int i = 1; i < 10; i++)
{
    Console.Write("위치를 선택하세요 (1~9): ");
    string inputNum = Console.ReadLine();
    if (!int.TryParse(inputNum, out int readNum))
    {
        Console.WriteLine("숫자로 위치를 입력하세요.");
        i--;
        continue;
    }
    if (readNum < 1 || readNum > 9)
    {
        Console.WriteLine("1부터 9까지의 번호를 입력하세요.");
        i--;
        continue;
    }
    if (input[readNum - 1] != ".")
    {
        Console.WriteLine("이미 선택한 칸입니다. 빈칸을 선택하세요.");
        i--;
        continue;
    }


    if (i % 2 == 1)
    {
        input[readNum - 1] = "X";
    }
    if (i % 2 == 0)
    {
        input[readNum - 1] = "O";
    }

    for (int j = 1; j < 10; j++)
    {
        Console.Clear();
        Console.WriteLine("=== 틱택토 게임 · 1단계 ===");
        Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
        Console.WriteLine();
        Console.WriteLine("위치번호:");
        board.ShowLocation();
        Console.WriteLine();
        Console.WriteLine("현재 보드:");
        board.ShowGameBoard(input);
        Console.WriteLine();
        if (i % 2 == 1)
        {
            Console.WriteLine("플레이어 X의 차례입니다.");
        }
        if (i % 2 == 0)
        {
            Console.WriteLine("플레이어 O의 차례입니다.");
        }
    }

    if (board.Winner(input))
    {
        if (i % 2 == 1)
        {
            Console.WriteLine("플레이어 X 승리!");
            break;
        }
        if ((i % 2) == 0)
        {
            Console.WriteLine("플레이어 O 승리!");
            break;
        }
    }
    if (i == 9)
    {
        Console.WriteLine("무승부입니다!");
    }
}

