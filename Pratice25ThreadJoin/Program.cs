using System;
using System.Threading;
namespace Pratice25ThreadJoin
{
    class Program
    {
        public static void childthreadcall1()
        {
            try
            {
                Console.WriteLine("Child thread called");
                Thread.Sleep(5000);

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Waking Up");
            }
            catch(ThreadAbortException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Unable to Handle");
            }

        }
        public static void childtheadcall2()
        {
            try
            {
                Console.WriteLine("Child thread called");
                Thread.Sleep(5000);

                for(int i=6; i<=10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Waking Up");
            }
            catch(ThreadAbortException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            finally
            {
                Console.WriteLine("Unable to Handle");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=======Creation of Our Main Thread=========");
            Console.WriteLine("Calling child thread");

            ThreadStart ts = new ThreadStart(childthreadcall1);
            Thread t1 = new Thread(ts);
            t1.Start();
            t1.Join();

            ThreadStart ts1 = new ThreadStart(childtheadcall2);
            Thread t2 = new Thread(ts1);
            t2.Start();
            t2.Join();


        }
    }
}
