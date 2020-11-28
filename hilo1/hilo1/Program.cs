using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace hilo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                Barman oBarman = new Barman();
                Task<bool> TBool = oBarman.CalientaSnack();

                oBarman.HacerContel();

                bool boolResult = await TBool;

            }).GetAwaiter().GetResult();



        }

        public class Barman
        {
            public async Task<bool> CalientaSnack()
            {
                Console.WriteLine("Mete el Snack al Horno");

                HttpClient client = new HttpClient();

                await client.GetAsync("http://hdelcon.net");

                //Thread.Sleep(5000);

                Console.WriteLine("Saca el Snack al Horno");

                return true;

            }


            public void HacerContel()
            {
                Console.WriteLine("Comienza de hacer Coctel");

                Thread.Sleep(5000);

                Console.WriteLine("Termina de hacer Coctel");

            }

        }
    }
}
    
