using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 입력 : ");
            var input = int.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다!");
            }
            if (input % 2 == 1)
            {
                Console.WriteLine("홀수 입니다!");
            }
        }
    }
}
