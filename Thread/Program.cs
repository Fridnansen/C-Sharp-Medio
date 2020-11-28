using System;
using System.Threading;
namespace Thread
{
    class Program
    {
        public static void Cantinero1Atiende()
            {
            for(int i=0; i < 100; i++)
                {
                Console.WriteLine("Cantinero 1 sirve Cerveza: "+i);
                System.Threading.Thread.Sleep(100);
                }
            
            }

        public static void Cantinero2Atiende()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Cantinero 2 sirve Cerveza: "+i);
                System.Threading.Thread.Sleep(100);
            }

        }

        static void Main(string[] args)
        {
            System.Threading.Thread cantinero1 =
                new System.Threading.Thread(new ThreadStart(Cantinero1Atiende));

            System.Threading.Thread cantinero2 =
                new System.Threading.Thread(new ThreadStart(Cantinero2Atiende));


            cantinero1.Start();
            cantinero2.Start();
        }
    }
}
