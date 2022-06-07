using System;

namespace IOCExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BLL bll = new BLL();

            bll.GetProducts().ForEach(x => Console.WriteLine($"{x.Id} - {x.Name} - {x.Price} - {x.Stock}"));


            Console.ReadLine();
        }
    }
}
