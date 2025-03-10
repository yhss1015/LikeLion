using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Block
    {
        public int[,] Blocks = new int[50, 2]; // (x, y) 좌표를 5개 저장

        public bool[] isHitted = new bool[50];

        int currentDirect;
        bool Hitted = false;

        public void Initialize()
        {
            Random rand = new Random();
            HashSet<(int, int)> usedPositions = new HashSet<(int, int)>();

            for (int i = 0; i < 50; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(5, 37) * 2; // 10~38 범위에서 2의 배수 생성
                    y = rand.Next(1, 5) * 2;  // 2~6 범위에서 2의 배수 생성
                } while (usedPositions.Contains((x, y))); // 이미 있는 좌표라면 다시 생성

                Blocks[i, 0] = x;
                Blocks[i, 1] = y;
                isHitted[i] = false;
                usedPositions.Add((x, y)); // 사용된 좌표 저장
            }
        }
        public void Render()
        {
            for (int i = 0; i <50; i++)
            {
                if (!isHitted[i]) // 맞지 않은 블록만 렌더링
                {
                    Program.gotoxy(Blocks[i, 0], Blocks[i, 1]);
                    Console.Write("■");
                }
            }
        }

        public void Progress(ref Ball pBall)
        {
            BALLDATA pBallData = pBall.GetBall();

            // 현재 공의 좌표
            int ballX = pBallData.nX;
            int ballY = pBallData.nY;
            Hitted = false;
            // 충돌 감지
            for (int i = 0; i < 50; i++)
            {
                if (((Blocks[i, 0] == ballX+1 && Blocks[i, 1] == ballY)|| (Blocks[i, 0] == ballX + 1 && Blocks[i, 1] == ballY+1)|| (Blocks[i, 0] == ballX + 1 && Blocks[i, 1] == ballY -1)) && !isHitted[i]&&Hitted ==false)
                {
                    
                    
                    
                    currentDirect = pBallData.nDirect;
                    switch (currentDirect)
                    {
                        case 1:
                            isHitted[i] = true; // 블록이 맞았음을 표시
                            pBallData.nDirect = 5;
                            Hitted = true;

                            break;
                        case 2:
                            isHitted[i] = true; // 블록이 맞았음을 표시
                            pBallData.nDirect = 4;
                            Hitted = true;
                            break;
                        /*case 4:
                            pBallData.nDirect = 2;
                            break;
                        case 5:
                            pBallData.nDirect = 1;
                            break;
                        */
                    }

                }
                if (((Blocks[i, 0] == ballX -1 && Blocks[i, 1] == ballY)|| (Blocks[i, 0] == ballX - 1 && Blocks[i, 1] == ballY+1)|| (Blocks[i, 0] == ballX - 1 && Blocks[i, 1] == ballY-1)) && !isHitted[i]&& Hitted == false)
                {

                    
                    currentDirect = pBallData.nDirect;
                    switch (currentDirect)
                    {
                        /*case 1:
                            pBallData.nDirect = 5;
                            break;
                        case 2:
                            pBallData.nDirect = 4;
                        
                            break;
                        */
                        case 4:
                            isHitted[i] = true; // 블록이 맞았음을 표시
                            pBallData.nDirect = 2;
                            Hitted = true;
                            break;
                        case 5:
                            isHitted[i] = true; // 블록이 맞았음을 표시
                            pBallData.nDirect = 1;
                            Hitted = true;
                            break;
                    }

                }
                if(((Blocks[i, 0] == ballX  && Blocks[i, 1] == ballY+1 )|| (Blocks[i, 0] == ballX-1 && Blocks[i, 1] == ballY + 1)|| (Blocks[i, 0] == ballX +1 && Blocks[i, 1] == ballY + 1)) && !isHitted[i]&& Hitted == false)
                {

                    
                    currentDirect = pBallData.nDirect;
                    switch (currentDirect)
                    {
                        case 1:
                            isHitted[i] = true; // 블록이 맞았음을 표시
                            pBallData.nDirect = 2;
                            Hitted = true;
                            break;
                        /*case 2:
                            pBallData.nDirect = 1;
                            break;
                        case 4:
                            pBallData.nDirect = 5;
                            break;
                        */
                        case 5:
                            isHitted[i] = true; // 블록이 맞았음을 표시
                            pBallData.nDirect = 4;
                            Hitted = true;
                            break;
                    }

                }
                if (((Blocks[i, 0] == ballX && Blocks[i, 1] == ballY -1) || (Blocks[i, 0] == ballX - 1 && Blocks[i, 1] == ballY -1) || (Blocks[i, 0] == ballX + 1 && Blocks[i, 1] == ballY -1)) && !isHitted[i]&& Hitted == false)
                {

                    currentDirect = pBallData.nDirect;
                    switch (currentDirect)
                    {
                        //case 1:
                        //    pBallData.nDirect = 2;
                        //    break;
                        case 2:
                            isHitted[i] = true; // 블록이 맞았음을 표시
                            currentDirect = pBallData.nDirect;
                            pBallData.nDirect = 1;
                            Hitted = true;
                            break;
                        case 4:
                            isHitted[i] = true; // 블록이 맞았음을 표시
                            currentDirect = pBallData.nDirect;
                            pBallData.nDirect = 5;
                            Hitted = true;
                            break;
                        
                        //case 5:
                        //    pBallData.nDirect = 4;
                        //    break;
                    }

                    

                }
                
            }
        }

    }
}
