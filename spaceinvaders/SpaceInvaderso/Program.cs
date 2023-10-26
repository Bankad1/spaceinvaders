using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaderso
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 80);
            Console.SetWindowSize(80, 32);
            Console.CursorVisible = false;
            Enemies e = new Enemies();
            Tank t = new Tank(e);
            t.Draw();

            await GameLoop(100); // 100 ms-es időzítés

            e._timer.Dispose();
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }

        static async Task GameLoop(int delayMs)
        {
            while (Enemies.list.Count < 40)
            {
                var c = Console.ReadKey(true).Key;
                t.GetInput(c);
                Console.SetCursorPosition(50, 30);
                Console.Write("*****{0}*****", Invader.count);

                await Task.Delay(delayMs); // Időzítés
            }
        }
    }
}
/*static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 80);
            Console.SetWindowSize(80, 32);
            Console.CursorVisible = false;
            Enemies e=new Enemies();
            Tank t = new Tank(e);
            t.Draw();
            
            Console.ReadKey();
            while (Enemies.list.Count<40)
            {var c=Console.ReadKey(true).Key;
                t.GetInput(c);
                Console.SetCursorPosition(50, 30);
                Console.Write("*****{0}*****", Invader.count);
            }
            e._timer.Dispose();
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}*/
