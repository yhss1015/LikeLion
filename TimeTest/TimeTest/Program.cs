using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTest
{
    class Program
    {
        

        static void Main(string[] args)
        {
            GameManager gamemanager = new GameManager();
            gamemanager.Start();
            gamemanager.Progress();

        }
    }
}
