using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace LinqDome.Operator.元素运算符
{
    public class DefaultIfEmptyOperator
    {
        /*
         * 当序列没有任何元素得时候，返回一个单元素序列，且元素值为default（TSource）——泛型类型得默认值。
         * ps: default（TSource）对于引用类型元素为null，对于bool类型为false，而数值类型为零。
         * IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source, TSource defaultValue);
         * IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source);
         */

        /// <summary>
        /// 有参数
        /// </summary>
        public static void Dome1()
        {
            {
                int[] numbers = { 1, 45, 12 };
                foreach (var item in numbers.DefaultIfEmpty(1))
                {
                    //集合不为空，不会打印1
                    System.Console.WriteLine(item);
                }
            }
            System.Console.WriteLine("==========置空==========");
            {
                int[] numbers2 = { };
                foreach (var item in numbers2.DefaultIfEmpty(1))
                {
                    System.Console.WriteLine(item);//1
                }
            }
        }

        /// <summary>
        /// 无参数
        /// </summary>
        public static void Dome2()
        {
            {
                int[] numbers = { 9, 19, 29 };
                foreach (var item in numbers.DefaultIfEmpty())
                {
                    System.Console.WriteLine(item);
                }
            }
            System.Console.WriteLine("==========置空==========");
            {
                int[] numbers2 = { };
                foreach (var item in numbers2.DefaultIfEmpty())
                {
                    System.Console.WriteLine(item);//默认0
                }
            }
        }
    }
}