using System;
using System.Linq;
namespace LinqDome.Operator.聚合方法
{
    public class CountAndLongCountOperator
    {
        /*
         * Count和LongCount很简单，就是得到集合元素的长度，Count返回的int类型,LongCount返回的long类型。
         * int Count<TSource>(this IEnumerable<TSource> source);
         * int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         * int LongCount<TSource>(this IEnumerable<TSource> source);
         * int LongCount<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         */

        /// <summary>
        /// 数字数组
        /// </summary>
        /// <value></value>
        static int[] numbers = { 2, 5, 10, 11, 29 };
        /// <summary>
        /// Count
        /// </summary>
        public static void Dome1()
        {
            int count = numbers.Count();
            System.Console.WriteLine(count);//5
            System.Console.WriteLine(count.GetType());//System.Int32
            System.Console.WriteLine("======Count断言====");
            int countFunc=numbers.Count(c=>c>10);
            System.Console.WriteLine(countFunc);//2
        }

        /// <summary>
        /// LongCount
        /// </summary>
        public static void Dome2()
        {
            var count = numbers.LongCount();
            System.Console.WriteLine(count);//5
            System.Console.WriteLine(count.GetType());//System.Int64
            System.Console.WriteLine("======LongCount断言====");
            long countFunc=numbers.LongCount(c=>c>5);
            System.Console.WriteLine(countFunc);//3
            
        }
    }
}