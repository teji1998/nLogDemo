using System;

namespace Nlogprac
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Add add = new Add();
                var result = add.Sum(0, 3);
                Console.WriteLine(result);

            }
        }
    }
}
