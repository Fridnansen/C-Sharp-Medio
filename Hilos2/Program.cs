using System;
using System.Threading;

namespace Hilos2
{
    class Program
    {
        const string path = @" F:\Users\Lenovo\Desktop\Hilos\";
        static void Main(string[] args)
        {
           // int max, c = 0;
           // ThreadPool.GetMaxThreads(out max, out c);
           // Console.WriteLine("Hello World!");
           for (int i=0; i<50; i++)
            {
                ThreadPool.QueueUserWorkItem(Create, i);
            }
            while (ThreadPool.PendingWorkItemCout > 0) ;

        }

        static void Create(object data)
        {
            int i = (int)data;
            using (var sw = new StreamWriter(path + i + "txt"))
            {
                sw.WriteLine("Hola soy el hilo" + Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("Hola soy el hilo" + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
