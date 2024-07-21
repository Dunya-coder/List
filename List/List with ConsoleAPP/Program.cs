using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_with_ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Fibonacci(0, 1, 20);
            IterationThrought(result);
        }
        static List<int> Fibonacci(int first,int second,int requaredIndex)
        {
            var result = new List<int>();
            result.Add(first);
            result.Add(second);
            for(int i=0;i<requaredIndex;i++)
            {
                var prePrevious = result[result.Count - 2];//0 -index
                var previous = result[result.Count-1];//previous-oldingisi,Result listning result,
                                                      //uzunligidan -1 qilib saqlanvotti
                result.Add(prePrevious + previous);                                     


            }
            return result;
        }
        static void IterationThrought(List<int>listToBeIterated)//iteratsiya qilinayotgan list
        {
            foreach(var element in listToBeIterated)
            {
                Console.WriteLine(element);
            }
        }
    }
}
