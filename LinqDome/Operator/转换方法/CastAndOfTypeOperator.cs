using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LinqDome.Operator.转换方法
{
    public static class CastAndOfTypeOperator
    {

        /*
         *Cast 和 OfType都是将非泛型Enumerable转换成泛型的IEnumerable<T>。
         *两者不同的区别在于Cast如果遇到无法处理的元素就会抛出异常，而OfType则是忽略不兼容的元素，继续处理后续元素。
         * IEnumerable<TResult> Cast<TResult>(this IEnumerable source);
         * IEnumerable<TResult> OfType<TResult>(this IEnumerable source);
         *
         */
        /// <summary>
        /// cast
        /// </summary>
        public static void Dome1()
        {

            ArrayList array = new ArrayList();
            array.AddRange(new int[] { 3, 4, 5 });
            var sequence1 = array.Cast<int>();
            foreach (var item in sequence1)
            {
                System.Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 测试不兼容cast不兼容的情况
        /// </summary>
        public static void Dome2()
        {

            // ArrayList array = new ArrayList();
            // array.AddRange(new int[] { 3, 4, 5 });
            // //插入一个string类型的数据，cast就无法转换
            // array.Add("1");
            // var sequence1 = array.Cast<int>();
            // foreach (var item in sequence1)
            // {
            //     System.Console.WriteLine(item);
            // }

            ArrayList array = new ArrayList();
            array.AddRange(new int[] { 3, 4, 5 });
            array.Add("1");
            array.Add(6);
            var sequence1 = array.OfType<int>();
            foreach (var item in sequence1)
            {
                System.Console.WriteLine(item);
            }
        }
        public static IEnumerable<TSource> OfType<TSource>(IEnumerable source)
        {
            foreach (object element in source)
                if (element is TSource)
                    yield return (TSource)element;
        }
        public static IEnumerable<TSource> Cast<TSource>(IEnumerable source)
        {
            foreach (object element in source)
                yield return (TSource)element;
        }
    }
}