using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTest
{
    public class GameManager
    {
        public Player t_player;
        public Field t_field;

        public void Start()
        {
            t_player = new Player();
            t_player.SelectJob();
        }

        public void Progress()
        {
            int select = 0;

            while(true)
            {
                Console.Clear();
                t_player.Render();
                Console.Write("1. 사냥터 2. 종료 : " );
                select = int.Parse(Console.ReadLine());

                if(select==1)
                {
                    if(t_field==null)
                    {
                        t_field = new Field();
                        t_field.SetPlayer(t_player);
                    }

                    t_field.Progress();
                }

                if(select ==2)
                {
                    break;
                    Environment.Exit(0);
                }
            }
        }

    }
}
