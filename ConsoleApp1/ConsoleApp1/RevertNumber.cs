using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RevertNumber
    {
        public RevertNumber()
        {

        }

        public int RevertNum(int n)
        {
            long result = 0;
            while(n != 0)
            {
                result = result * 10 + n % 10;
                n = n / 10;
            }
            if(result > int.MaxValue)
            {
                return 0;
            }
            else
                return (int)result;
        }

        public void OutPutResult()
        {
            int input = 12345;
            Console.WriteLine("The number to revert is: {0}",input);
            Console.WriteLine("The revert result is: {0}",RevertNum (input));
            Console.ReadKey();
        }
    }
}
