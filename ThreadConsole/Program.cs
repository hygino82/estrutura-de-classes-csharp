using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;//finaliza as thread secundárias
            t.Start();
            t.Join();//tarefa secundária termina antes de começar a primária

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal #" + (i + 1));
                Thread.Sleep(500);//pausa em ms
            }

            Console.ReadKey();
        }

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada #" + (i + 1));
                Thread.Sleep(1000);
            }
        }
    }
}
