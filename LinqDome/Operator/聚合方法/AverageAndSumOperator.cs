using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace LinqDome.Operator.聚合方法
{
    public class AverageAndSumOperator
    {
        /*
         *Sum和Average对类型的要求比较严格。它们的定义严格指定了每一种数值类型(int、long、float、double、decimal以及它们相应的可空类型)。
         *但是Average限制更多，它的返回类型只能是decimal、float、double
         *ps:Average会将输入值隐式向上转换以避免经度丢失。
         *double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector);
         *double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector);
         *decimal? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector);
         *float Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector);
         *double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector);
         *float? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector);
         *double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector);
         *double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector);
         *decimal Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector);
         *double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector);
         *float? Average(this IEnumerable<float?> source);
         *decimal Average(this IEnumerable<decimal> source);
         *double Average(this IEnumerable<int> source);
         *double Average(this IEnumerable<long> source);
         *double Average(this IEnumerable<double> source);
         *double? Average(this IEnumerable<double?> source);
         *double? Average(this IEnumerable<int?> source);
         *double? Average(this IEnumerable<long?> source);
         *decimal? Average(this IEnumerable<decimal?> source);
         *Sum 我们求和常用的方法。
         *float Average(this IEnumerable<float> source);
         *float Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector);
         *int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector);
         *long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector);
         *decimal? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector);
         *double Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector);
         *int? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector);
         *long? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector);
         *float? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector);
         *double? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector);
         *decimal Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector);
         *double? Sum(this IEnumerable<double?> source);
         *float? Sum(this IEnumerable<float?> source);
         *decimal Sum(this IEnumerable<decimal> source);
         *double Sum(this IEnumerable<double> source);
         *int Sum(this IEnumerable<int> source);
         *float Sum(this IEnumerable<float> source);
         *decimal? Sum(this IEnumerable<decimal?> source);
         *int? Sum(this IEnumerable<int?> source);
         *long? Sum(this IEnumerable<long?> source);
         *long Sum(this IEnumerable<long> source);

         */

        /// <summary>
        /// 无参数
        /// </summary>
        public static void Dome1()
        {
            int[] numbers = { 3, 4 };
            double avg = numbers.Average();
            //int avg=numbers.Average();//编译不通过
            System.Console.WriteLine(avg);
        }
        /// <summary>
        /// 有参数
        /// </summary>
        public static void Dome2()
        {
            int[] numbers = { 3, 4 };
            decimal avg = numbers.Average(a => (decimal)a);
            System.Console.WriteLine(avg);
        }

        /// <summary>
        /// 无参数
        /// </summary>
        public static void Dome_Sum_1()
        {
            int[] numbers = { 3, 4 };
            int sum = numbers.Sum();
            System.Console.WriteLine(sum);
        }
        /// <summary>
        /// 有参数
        /// </summary>
        public static void Dome_Sum_2()
        {
            List<Product> list = new List<Product>()
            {
                new Product { Name = "洗衣机", Count = 10 },
                new Product { Name = "空调", Count = 5 },
                new Product { Name = "油烟机", Count = 7 }
            };
            //产品总数
            int sum = list.Sum(s => s.Count);
            System.Console.WriteLine(sum);
        }
        /// <summary>
        /// 求平方根
        /// </summary>
        public static void Dome4()
        {
            int[] numbers = { 2, 3, 4 };
            Math.Sqrt(numbers.Average(a => a * a));
        }
        /// <summary>
        /// 标准差
        /// </summary>
        public static void Dome5()
        {
            int[] numbers = { 2, 3, 4 };
            double mean = numbers.Average(a => a * a);
            double sdev = Math.Sqrt(numbers.Average(n =>
            {
                double dif = n - mean;
                return dif * dif;
            }));
            System.Console.WriteLine(sdev);
        }

        class Product
        {

            public int Count { get; set; }
            public string Name { get; set; }
        }
    }
}