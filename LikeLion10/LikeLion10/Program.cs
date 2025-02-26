using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion10
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            //int[] num = new int[3];
            //for(int i = 0; i < 3; i++)
            //{
            //    num[i] = i * 10;
            //    Console.WriteLine(num[i]);
            //}

            //배열 초기화 방법
            //int[] num = new int[] { 10, 20, 30 };

            //string[] fruits = { "사과", "바나나", "오렌지" };

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //Console.Write("국어, 영어, 수학 점수를 입력하세요 (공백으로 구분): ");
            //string[] score = Console.ReadLine().Split(' ');
            //int[] scoreInt = new int[score.Length];
            //int sum = 0;
            //int avg = 0;

            //for (int i = 0; i < score.Length; i++)
            //{
            //    scoreInt[i] = int.Parse(score[i]);
            //    Console.WriteLine(scoreInt[i]);
            //    sum += scoreInt[i];
            //}

            //avg = sum / score.Length;
            //Console.WriteLine("총점: " + sum);
            //Console.WriteLine("평균: " + avg);

            ////출력 포멧
            //double value = 11123.456789;
            //Console.WriteLine(value.ToString("F2")); //11123.46
            //Console.WriteLine($"{value:F2}"); //11123.46
            //Console.WriteLine(String.Format("{0:F2}", value)); //11123.46
            //Console.WriteLine(value.ToString("N2")); //11,123.46

            ////배열의 차원
            //int[,] matrix = new int[2, 3] 
            //{ 
            //    { 1, 2, 3 },
            //    { 4, 5, 6 } 
            //};

            //for(int i = 0; i < 2; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////가변 배열
            //int[][] jagged = new int[2][];
            //jagged[0] = new int[3] { 1, 2, 3 };
            //jagged[1] = new int[2] { 4, 5 };

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write(jagged[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"배열 타입: {jagged.GetType()}");

            //빙고 게임
            //int[] iArray = new int[25];

            //for (int i = 0; i < 25; i++)
            //{
            //    iArray[i] = i + 1;
            //}

            //for(int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //        Console.Write(iArray[i*5+j].ToString("D2") + " ");
            //    }
            //    Console.WriteLine();
            //}


            ////셔플
            //Random rand = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    int iA = rand.Next(25);
            //    int iB = rand.Next(25);
            //    int iTmp = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iTmp;

            //}

            ////빙고판 출력
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (iArray[i * 5 + j] == 0)
            //        {
            //            Console.Write("XX ");
            //        }
            //        else
            //        {
            //            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //int iCount = 0;

            ////빙고 게임 시작
            //while (true)
            //{
            //    Console.Clear();

            //    //빙고판 출력
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                Console.Write("XX ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //            }

            //        }
            //        Console.WriteLine();
            //    }

            //    Console.Write("빙고 번호를 입력하세요: ");
            //    int input = int.Parse(Console.ReadLine());
            //    int iBingo = 0;

            //    //입력한 번호 찾아서 0으로 변경
            //    for (int i = 0; i < 25; i++)
            //    {
            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }

            //    Console.WriteLine();

            //    //빙고판 출력
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                Console.Write("XX ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //            }

            //        }
            //        Console.WriteLine();
            //    }

            //    //빙고 체크
            //    //가로
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                ++iCount;
            //            }

            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //                iCount = 0;
            //            }
            //        }
            //    }

            //    //세로
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[j * 5 + i] == 0)
            //            {
            //                ++iCount;
            //            }

            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //                iCount = 0;
            //            }
            //        }

            //    }

            //    //대각선
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 4 + 4] == 0)
            //        {
            //            ++iCount;
            //        }
            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //            iCount = 0;
            //        }
            //    }
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 6] == 0)
            //        {
            //            ++iCount;
            //        }

            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //            iCount = 0;
            //        }
            //    }

            //    if (iBingo >= 5)
            //    {
            //        Console.WriteLine("빙고!!");
            //        break;
            //    }
            //}

            int[,] board = new int[5, 5]; //5x5 빙고판
            bool[,] marked = new bool[5, 5]; //선택된 숫자 체크

            int bingoCount = 0;

            Random random = new Random();

            //빙고판 초기화
            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++)
                numbers[i] = i + 1;

            //랜덤 섞기(Fisher-Yates Shuffle)
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);

            }


            //2차원 배열로 변환
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            //게임시작
            while (bingoCount < 5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");


                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25) : ");
                int number = int.Parse(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true; //숫자를 X로 변경
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로체크
                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[i, j]) rowBingo = false;

                    if (rowBingo) bingoCount++;
                }


                //세로체크
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < 5; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) bingoCount++;
                }


                //대각선 체크 (왼쪽위 ->오른쪽 아래)

                bool diag1Bingo = true;

                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, i])
                        diag1Bingo = false;
                }
                if (diag1Bingo)
                    bingoCount++;


                //대각선 오른쪽위 ->왼쪽아래
                bool diag2Bingo = true;

                for (int i = 0; i < 5; i++)
                    if (!marked[i, 4 - i]) diag2Bingo = false;


                if (diag2Bingo) bingoCount++;

            }

            Console.WriteLine("빙고 5개 완성! 게임종료");




        }
    }
}
