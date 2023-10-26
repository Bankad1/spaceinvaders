using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaderso
{
    /*public  class Invader:IDisposable
    {
        Caracter[] caracter;
        public int X { get; set; }
        public int Y { get; set; }
        public static int count;
        private bool disposedValue;

        public Invader(Caracter[] caracter, int x, int y)
        {
            this.caracter = caracter;
            X = x;
            Y = y;
            //count++;
           
        }
        ~Invader()
            {
            this.caracter = null;
            count++;
        }
        public void Draw()
        {

            foreach (var item in caracter)
            {
                item.Draw(X, Y);
            }
        }

        public void CClear()
        {

            foreach (var item in caracter)
            {
                item.Cclear(X, Y);
            }
        }
        public static void Move(object o)
        {
            (o as Invader).CClear();
            (o as Invader).Y++;
            (o as Invader).Draw();
           
        }
        public void Move()
        {
            this.CClear();
            this.Y++;
            this.Draw();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    count++;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Invader()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

         public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}*/
    public class Invader : IDisposable
    {
        private Caracter[] caracter;
        public int X { get; set; }
        public int Y { get; set; }
        public static int count;

        public Invader(Caracter[] caracter, int x, int y)
        {
            this.caracter = caracter;
            X = x;
            Y = y;
            count++; 
        }

        public void Draw()
        {
            foreach (var item in caracter)
            {
                item.Draw(X, Y);
            }
        }

        public void CClear()
        {
            foreach (var item in caracter)
            {
                item.Cclear(X, Y);
            }
        }

        public static void Move(object o)
        {
            (o as Invader).CClear();
            (o as Invader).Y++;
            (o as Invader).Draw();
        }

        public void Move()
        {
            this.CClear();
            this.Y++;
            this.Draw();
        }

        public void Dispose()
        {
           
        }
    }
}
