using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaderso
{
    internal class Tank : Invader
    {
        public Tank(Enemies e) : base(new Caracter[6]
                        {
                new Caracter(0,1,'|',ConsoleColor.White),
                new Caracter(1,0,'_',ConsoleColor.White),
                new Caracter(2,0,'|',ConsoleColor.Yellow),
                new Caracter(3,0,'|',ConsoleColor.Yellow),
                new Caracter(4,0,'_',ConsoleColor.White),
                new Caracter(5,1,'|',ConsoleColor.White)
                        }, 20, 26)
        {
            

        }
        public void GetInput(ConsoleKey c)
        {
            switch (c)
            {
                case ConsoleKey.LeftArrow:
                

                    Move(-1,0);
                    break;
               case ConsoleKey.RightArrow:  
                 Move(1,0);
                    break;
                case ConsoleKey.Spacebar:
                    Bullet b = new Bullet(X, Y);
                    break;
            }
            
        }
        public void Move(int dx, int dy)
        {
            this.CClear();
            this.X=this.X+dx;   
            this.Y = this.Y + dy;

            this.Draw();

        }

    }
}
