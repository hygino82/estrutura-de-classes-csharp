using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsoles
{
    class Program

    {
        static void Main(String[] args)
        {
            #region Task parte1
            //Task t1 = new Task(Tarefa);
            // t1.Start();

            //Task t2 = Task.Run(Tarefa);
            //Task.Run(Tarefa);//podemos executar sem criar o objeto
            //    Task.Factory.StartNew(Tarefa);
            //    Task.Run(() => {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            Console.WriteLine("Tarefa função anônima do task #" + i);
            //        }
            //    });

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa principal do task #" + i);
            //    }
            //    Console.ReadKey();

            //}
            //private static void Tarefa()
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa do task #" + i);
            //    }
            //}
            #endregion

            //Task[] tasks =
            //{
            //    Task.Factory.StartNew(()=>{
            //        Console.WriteLine("Tarefa #1");
            //    }),

            //    //new Task(Tarefa),

            //    Task.Factory.StartNew(()=>{
            //         Console.WriteLine("Tarefa #2");
            //    }),

            //    Task.Factory.StartNew(()=>{
            //         Console.WriteLine("Tarefa #3");
            //    })

            //};

            //Task.WaitAll(tasks);//´precisa terminar as tarefas para seguir a execução do programa

            Task t1 = Task.Run(() =>
            {
                Console.WriteLine("Comando #1");
            });

            Task t2 = Task.Run(() =>
            {
                Console.WriteLine("Comando #2");
            });

            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Comando #3");
            });


            Task.WaitAll(t1, t2, t3);
            Console.WriteLine("Tarefa Principal");
            Console.ReadKey();

        }
        static void Tarefa()
        {
            Console.WriteLine("Tarefa #4");
        }
    }

}