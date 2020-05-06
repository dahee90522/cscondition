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

            //현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다");
                }
            }
        }
    }
}
