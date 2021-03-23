using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDome.Operator.元素运算符
{
    /// <summary>
    /// 
    /// </summary>
    public class ElementAtOperator
    {

        /*
         * ElementAt 和ElementAtOrDefault 会返回序列中的第n个元素。ElementAt会抛出异常！
         * ps：在输入序列恰好实现了IList<T>的情况下，会直接调用IList<T>的索引器，否则它将枚举n次。
         * TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index);
         * TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index);
         * 
         */
        /// <summary>
        /// ElementAt
        /// </summary>
        public static void Dome1()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int one = numbers.ElementAt(0);
            Console.WriteLine("One " + one);
            try
            {
                int rangeErr = numbers.ElementAt(5);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ElementAt Err " + ex.Message);
            }
        }

        /// <summary>
        /// ElementAtOrDefault
        /// </summary>
        public static void Dome2()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int one = numbers.ElementAtOrDefault(0);
            Console.WriteLine("One "+one);
            int range = numbers.ElementAtOrDefault(5);
            Console.WriteLine("Range " + range);

        }
    }
}
