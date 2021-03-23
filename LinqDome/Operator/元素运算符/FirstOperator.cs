using System;
using System.Linq;
namespace LinqDome.Operator.元素运算符
{
    
    public class FirstOperator
    {


        /*
         * First和FirstOrDefault 都是返回序列中的第一个元素。但是不同的是First如果没有匹配项，将会抛出一个异常，而FirstOrDefault则会返回一个默认值。
         * TSource First<TSource>(this IEnumerable<TSource> source);
         * TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         * TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source);
         * TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         */
        /// <summary>
        /// first
        /// </summary>
        public static void Dome1()
        {
            int[] numbers = { 1, 3, 2, 9, 10 };
            {
                int first = numbers.First();
                Console.WriteLine("First：" + first);
            }
            {
                Console.WriteLine("根据条件匹配");
                Console.WriteLine("获取大于3的第一个数据");
                int first = numbers.First(f => f > 3);
                Console.WriteLine("First：" + first);
            }
        }


        /// <summary>
        /// First错误
        /// </summary>
        public static void Dome1Err()
        {
            try
            {
                Console.WriteLine("测试First抛出异常");
                int[] numbers = { 1, 3, 2, 9, 10 };
                int first = numbers.First(f => f > 10);

            }
            catch (Exception ex)
            {
                Console.WriteLine("First 异常：" + ex.Message);
            }
        }

        /// <summary>
        /// FirstOrDefault
        /// </summary>
        public static void Dome2()
        {
            int[] numbers = { 1, 3, 2, 9, 10 };
            {
                int first = numbers.FirstOrDefault();
                Console.WriteLine("FirstOrDefault：" + first);
            }
            {
                int first = numbers.FirstOrDefault(f => f > 9);
                Console.WriteLine("FirstOrDefault Filter Element >9：" + first);
            }
            {
                int first = numbers.FirstOrDefault(f => f > 10);
                Console.WriteLine("FirstOrDefault Default ：" + first);
            }
        }
    }
}