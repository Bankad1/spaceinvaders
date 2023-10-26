using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaderso
{
    /// <summary>
    /// Konténerosztály az ellenségek listáját tartalmazza
    /// </summary>
    internal class Enemies
    {
        public static int step_count = 0;
        public static List<Invader> list;
        public Timer _timer;
        public Enemies()
        { 
            list=new List<Invader>();
            Caracter[] c = new Caracter[6]
                        {
                new Caracter(0,0,'(',ConsoleColor.Red),
                new Caracter(1,0,'o',ConsoleColor.Red),
                new Caracter(3,0,'o',ConsoleColor.Red),
                new Caracter(4,0,')',ConsoleColor.Red),
                new Caracter(1,1,'/',ConsoleColor.Red),
                new Caracter(3,1,'\\',ConsoleColor.Red)
                        };

            for (int i = 0; i < 10; i++)
            {
                Invader ii = new Invader(c, i * 8, 2);
                list.Add(ii);
                
            }
            _timer = new Timer(Move, this, 1000, 2000);
        }
        public void Draw()
        {
            Console.SetCursorPosition(0,0);
            Console.Clear();
            foreach (var item in list)
            {
                item.Draw();
            }

        }
        public static void Move(object o)
        {

            if (step_count > 4)
            {
                Console.SetCursorPosition(0, 0);
                Console.Clear();
                Caracter[] c = new Caracter[6]
                        {
                new Caracter(0,0,'(',ConsoleColor.Red),
                new Caracter(1,0,'o',ConsoleColor.Red),
                new Caracter(3,0,'o',ConsoleColor.Red),
                new Caracter(4,0,')',ConsoleColor.Red),
                new Caracter(1,1,'/',ConsoleColor.Red),
                new Caracter(3,1,'\\',ConsoleColor.Red)
                        };

                for (int i = 0; i < 10; i++)
                {
                    Invader ii = new Invader(c, i * 8, 2);
                    Enemies.list.Add(ii);

                }
                step_count = step_count - 4;
                    }
                 step_count++;
            for (int i = 0; i < Enemies.list.Count; i++)
            {


                Enemies.list[i].Move();
            }
           
        }
    }
}
