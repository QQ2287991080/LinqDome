using System;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDome.Operator.聚合方法
{
    /// <summary>
    /// Aggregate 操作运算符
    /// </summary>
    public class AggregateOperator
    {
        /*
         * Aggregate 用于实现自定义的独特聚合算法，Aggregate无法在Linq to Sql和EF中使用
         * 并且它的功能是根据特定的使用场景确认的。
         * Aggregate 方法有三个重载
         * 
         * TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func);
         * TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func);
         * TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector);
         */

        /// <summary>
        /// Aggregate 一个参数
        /// 无种子的聚合操作
        /// TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func);
        /// 无种子聚合的优势之一就是不要使用特殊重载就可以并行化（System.Threading.Tasks.Parallel）
        /// </summary>
        public static void Dome1()
        {

            int[] numbers = { 2, 3, 4 };
            int sum = numbers.Aggregate((total, n) => total + n);
            //计算方式
            //2+3+4
            System.Console.WriteLine(sum); //9
        }
        /// <summary>
        /// Aggregate 两个参数
        /// 有种子的聚合操作
        /// TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func);
        /// 第一个参数称为种子，它指定累计结果的初始值。第二参数是一个表达式，它累计更新并返回全新元素。
        /// 第三个参数是可选的，它会将累计值映射为最终的结果
        /// </summary>
        public static void Dome2()
        {
            int[] numbers = { 2, 3, 4 };
            int sum = numbers.Aggregate(0, (total, n) => total + n);
            //计算方式 0+2+3+4
            System.Console.WriteLine(sum);
        }
        /// <summary>
        /// 这个重载的第三个参数，类似select的操作
        /// TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector);
        /// </summary>
        public static void Dome3()
        {
            int[] numbers = { 2, 3, 4 };
            var sum = numbers.Aggregate(0, (total, n) => total + n, s => (decimal)s);
            //计算方式 0+2+3+4
            System.Console.WriteLine(sum.GetType().Name); //Decimal
            System.Console.WriteLine(sum); //9
        }
       

    }
}