using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDome.Operator.元素运算符
{
    /// <summary>
    /// Single、SingleOrDefault
    /// </summary>
    public class SingleOperator
    {
        /*
         * 和First、FirstOrDeafult几乎等价，但是在多于一个匹配的时候会抛出异常，通俗来讲，就是在一个序列中如果有多个匹配的元素，则不能使用Single或SingleOrDefault。
         * TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         * TSource Single<TSource>(this IEnumerable<TSource> source);
         * TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source);
         * TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         *
         *
         */

        /// <summary>
        /// Single
        /// </summary>
        public static void Dome1()
        {
            int[] numbers = { 1, 1, 2, 3, 4 };

            try
            {
                numbers.Single();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Single 错误：" + ex.Message);
            }
        }
        /// <summary>
        /// SingleOrDefault
        /// </summary>
        public static void Dome2()
        {
            int[] numbers = { 1, 2, 3, 4 };

            try
            {
                int single = numbers.SingleOrDefault(f => f == 1);
                Console.WriteLine("SingleOrDefault："+single);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SingleOrDefault 错误：" + ex.Message);
            }
        }

    }
}
