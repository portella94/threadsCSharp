using System;
using System.Threading;

namespace trunk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread principal iniciada");
            Thread.CurrentThread.Name = "Principal - ";

            Thread t1 = new Thread(new ThreadStart(run));
            //CarregarDados(t1)
            t1.Name = "Secundária - ";
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread atual  - " + Thread.CurrentThread.Name + i);
                Thread.Sleep(1000);

            }
            Console.WriteLine("Thread Principal terminada");
            Console.ReadLine();
            Printer.print();

        }

        public static void run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread Atual - " + Thread.CurrentThread.Name + i);

                Thread.Sleep(1000);
            }
        }

        public void CarregarDados(Thread aThread)
        {
            //this.Cursor = Cursors.WaitCursor;
            //this.Show();
            try
            {
                aThread.Start();

                while (aThread.IsAlive)
                {
                    //TODO: fazer algo em paralelo enquanto thread existe como uma barra de progresso
                }

                //this.Cursor = Cursors.Default;
                //this.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro: \n\r \n\r" + ex.Message);
                throw ex;
            }
        }
    }

    
}
