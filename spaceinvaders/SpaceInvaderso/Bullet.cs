using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaderso
{
    internal class Bullet : Caracter
      
    {  
        protected  Timer _timer;
        public Bullet(int x, int y) : base(x, y, '|', ConsoleColor.Green)
        {
            _timer = new Timer(Move, this, 100, 100);
            
        }
        ~Bullet()
        { _timer.Dispose(); }   


        public static void Move(object o)
        {
            if ((o as Bullet).Y < 2)
            {
                (o as Bullet).Cclear(0,0);
                (o as Bullet)._timer.Dispose();
                
            }
            else
            {
                (o as Bullet).Cclear(0, 0);
                (o as Bullet).Y--;

                (o as Bullet).Draw();
                if ((o as Bullet).Collision(o))
                {
                    (o as Bullet).Cclear(0, 0);
                    (o as Bullet)._timer.Dispose();
                }
            }
        }
        public bool Collision(object o)
        {
            bool coll=false;
            int xx= (o as Bullet).X;
            int yy= (o as Bullet).Y;
            Invader i = Enemies.list.Find(c => Math.Abs(xx-c.X) < 2 && c.Y == yy);
            if (i!=null)
            {
                coll = true;
                i.CClear();
               // Invader.count++;
               Enemies.list.Remove(i);
                i.Dispose();
                 
            }
            return coll;
        }

    }
}
