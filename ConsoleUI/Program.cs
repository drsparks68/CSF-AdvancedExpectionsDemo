using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                SimpleMethod();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }


            Console.ReadLine();
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the simple method.");
        }
    }
}
