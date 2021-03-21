using System;
using System.Linq;
namespace LinqDome.Operator.集合运算符
{
    /// <summary>
    /// Concat 和 Union
    /// </summary>
    public class ConcatAndUnionOperator
    {
        /*
         * Concat返回第一个序列的所有元素，然后将第二集合的元素都紧跟在第一个结果集合的后面。
         * Union和Concat的效果一样，不同的是会去掉重复元素。
         * IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
         * IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
         */
        /// <summary>
        /// Concat
        /// </summary>
        public static void Dome1()
        {
            int[] numbers = { 1, 2, 3, 4 };

            int[] numbersSecond = { 4, 5, 6, 7 };

            //Concat
            var numbersthrid = numbers.Concat(numbersSecond);
            foreach (var item in numbersthrid)
            {
                System.Console.Write(item+"、");
            }
            //1、2、3、4、4、5、6、7、
        }
        /// <summary>
        /// Union
        /// </summary>
        public static void Dome2()
        {
            System.Console.WriteLine();
            int[] numbers = { 1, 2, 3, 4 };

            int[] numbersSecond = { 4, 5, 6, 7 };

            //Union
            var numbersthrid = numbers.Union(numbersSecond);
            foreach (var item in numbersthrid)
            {
               System.Console.Write(item+"、");
            }
            //1、2、3、4、5、6、7、
        }
    }
}