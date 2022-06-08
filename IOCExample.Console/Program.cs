using System;

namespace IOCExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BLL bll = new BLL(new DAL());
            bll.GetProducts().ForEach(x => Console.WriteLine($"{x.Id} - {x.Name} - {x.Price} - {x.Stock}"));

            Console.WriteLine("\n-------------------------------------------------\n");

            BLL otherBLL = new BLL(new OtherDAL());
            otherBLL.GetProducts().ForEach(x => Console.WriteLine($"{x.Id} - {x.Name} - {x.Price} - {x.Stock}"));


            Console.ReadLine();
        }
    }
}
