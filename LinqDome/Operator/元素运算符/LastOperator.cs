using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDome.Operator.元素运算符
{
    /// <summary>
    /// Last、LastOrDefault
    /// </summary>
    public class LastOperator
    {
        /*
         * 与first和firstOrDefault相反，Last和LastOrDefault返回序列中的最后一个元素，
         * 同理last在没有匹配到元素的时候也会抛出一个错误，LastOrDefault则返回一个默认值。
         * TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         * TSource Last<TSource>(this IEnumerable<TSource> source);
         * TSource LastOrDefault<TSource>(this IEnumerable<TSource> source);
         * TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         *
         *
         */


        public static void Dome1()
        {
            int[] numbers = { 3, 12, 4, 6, 10 };

            {
                int last = numbers.Last();
                Console.WriteLine("Last :" + last);
            }
            {

                int last = numbers.LastOrDefault(l => l <10);
                Console.WriteLine("LastOrDefault：" + last);
            }
        }
    }
}
