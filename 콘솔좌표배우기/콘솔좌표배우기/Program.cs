using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표배우기
{
    internal class Program
    {
        private static object lockObj = new object();
        private static char[,] screenBuffer = new char[80, 25];
        private static int playerY = 10; // 플레이어의 초기 Y 좌표
        private static readonly int playerX = 3; // X 좌표는 고정
        private static bool isRunning = true; // 게임 루프 유지
        private static CancellationTokenSource gameTimerCancellationSource;
        private static List<(int x, int y)> projectiles = new List<(int, int)>(); // 발사체 리스트
        private static int score = 0;
        private static int remainingTime = 10; // 초기 남은 시간

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            Console.WriteLine("콘솔 창 크기가 80x25로 설정되었습니다.");
            Console.ReadLine();

            MainMenu();
        }

        static void MainMenu()
        {
            start();
            Thread.Sleep(100);
            start();
            Thread.Sleep(100);
            start();
            Thread.Sleep(100);
            start();

            Console.Write("메뉴 선택 (1. 시작 2. 종료) : ");
            int menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                GameStart();
            }
            else
            {
                Console.WriteLine("\n게임을 종료합니다.");
                Environment.Exit(0);
            }
        }

        static void GameStart()
        {
            Console.Clear();
            board();
            DrawPlayer();

            // 게임 타이머 시작 (10초)
            StartGameTimer(10);

            // 키 입력 처리를 별도의 쓰레드에서 실행
            Task.Run(() => HandleInput());

            // 게임이 종료될 때까지 대기
            while (isRunning)
            {
                Thread.Sleep(100);
            }

            ClearProjectiles();
            Console.Clear();
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("타임오버!!");
            Thread.Sleep(300);
            Console.Clear();
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("타임오버!!");
            Thread.Sleep(300);
            Console.Clear();
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("타임오버!!");
            Thread.Sleep(300);
            Console.WriteLine("\n\n획득한 점수는 " + score + " 입니다\n\n");


        }

        // 타이머 시작 (지정된 시간 동안 게임을 진행)
        static void StartGameTimer(int seconds)
        {
            gameTimerCancellationSource = new CancellationTokenSource();
            var token = gameTimerCancellationSource.Token;

            Task.Run(async () =>
            {
                for (int i = 0; i < seconds; i++)
                {
                    if (token.IsCancellationRequested) return;
                    remainingTime = seconds - i;
                    UpdateRemainingTime(); // 남은 시간 업데이트
                    await Task.Delay(1000);
                }

                // 시간이 다 되면 게임 화면 클리어하고 타임오버 메시지 출력
                lock (lockObj)
                {
                    Console.Clear();
                    ClearProjectiles(); // 발사체 모두 제거
                    isRunning = false;
                }
            });
        }

        // 남은 시간 화면에 업데이트
        static void UpdateRemainingTime()
        {
            lock (lockObj)
            {
                Console.SetCursorPosition(20, 22);
                Console.Write($"남은 시간: {remainingTime}초");
            }
        }

        // 플레이어 입력 처리
        static void HandleInput()
        {
            while (isRunning)
            {
                var key = Console.ReadKey(true).Key;

                lock (lockObj)
                {
                    // 기존 위치 지우기
                    Console.SetCursorPosition(playerX, playerY);
                    Console.Write(" ");

                    // 방향키로 이동
                    if (key == ConsoleKey.UpArrow && playerY > 1)
                    {
                        playerY--;
                    }
                    else if (key == ConsoleKey.DownArrow && playerY < 19)
                    {
                        playerY++;
                    }
                    else if (key == ConsoleKey.Spacebar)
                    {
                        Task.Run(() => attack(playerY)); // 공격 실행
                    }

                    // 새로운 위치에 플레이어 그리기
                    DrawPlayer();
                }
            }
        }

        // 플레이어 표시
        static void DrawPlayer()
        {
            lock (lockObj)
            {
                Console.SetCursorPosition(playerX, playerY);
                Console.Write("®");
            }
        }

        static void attack(int y)
        {
            int prevX = playerX + 1;

            for (int x = playerX + 1; x < 78; x++)
            {
                lock (lockObj)
                {
                    if (isRunning == true)
                    {
                        if (screenBuffer[x, y] == '☆')
                        {
                            screenBuffer[x, y] = ' ';
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ");

                            Task.Run(async () =>
                            {
                                lock (lockObj)
                                {
                                    Console.SetCursorPosition(x, y);
                                    Console.Write("+50");
                                    score += 50;
                                    Console.SetCursorPosition(40, 22);
                                    Console.Write("현재 점수는 " + score + " 입니다.");

                                }

                                await Task.Delay(1000);

                                lock (lockObj)
                                {
                                    Console.SetCursorPosition(x, y);
                                    Console.Write("   ");
                                }
                            });

                            break;
                        }

                        Console.SetCursorPosition(prevX, y);
                        Console.Write(" ");
                        Console.SetCursorPosition(x, y);
                        Console.Write("▶");

                        // 발사체 리스트에 추가
                        projectiles.Add((x, y));
                    }

                }

                prevX = x;
                Thread.Sleep(50);
            }

            lock (lockObj)
            {
                Console.SetCursorPosition(prevX, y);
                Console.Write(" ");
            }
        }

        // 발사체 모두 제거
        static void ClearProjectiles()
        {
            lock (lockObj)
            {
                foreach (var projectile in projectiles)
                {
                    Console.SetCursorPosition(projectile.x, projectile.y);
                    Console.Write(" "); // 발사체 제거
                }
                projectiles.Clear(); // 발사체 리스트 초기화
            }
        }

        static public void start()
        {
            Console.Clear();
            Thread.Sleep(100);
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                          ★                                 ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃           ☆                                                                ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                              ☆             ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                    ★                                       ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                    ☆                                                       ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                           ★                ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃      ★                                                                     ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                              멋사4기 적 맞추기                              ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                 ★                                                          ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                      ☆                     ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                             ★              ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                   ☆                                        ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                               ☆                            ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃     ★                                                               ☆     ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        static public void board()
        {
            Random random = new Random();
            Console.Clear();
            Thread.Sleep(100);
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for (int i = 1; i < 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("┃                                                                             ┃");
            }
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            for (int i = 0; i < 5; i++)
            {
                int randomX = random.Next(40, 76);
                int randomY = random.Next(2, 19);
                WriteCharAt(randomX, randomY, '☆');
            }
        }

        static void WriteCharAt(int x, int y, char c)
        {
            if (x < 0 || x >= 80 || y < 0 || y >= 25) return;
            lock (lockObj)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(c);
                screenBuffer[x, y] = c;
            }
        }
    }
}
