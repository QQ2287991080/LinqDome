using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LinqDome.Operator.元素运算符;
using LinqDome.Operator.聚合方法;
using LinqDome.Operator.转换方法;
using LinqDome.Operator.量词运算符;
using LinqDome.Operator.集合运算符;

namespace LinqDome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //开始
            {
                //简单例子
                //Dome8_1();
            }
            //查询 运算符链
            {
                //Dome8_2();
            }
            //
            {
                //Demo8_3();
            }
            //延迟执行
            {
                // Demo8_4 ();
                ///重复执行
                //Demo8_4_1();
                //变量捕获
                //Demo8_4_2();
            }
            //AggregateOperator 
            {
                // AggregateOperator.Dome1();
                // AggregateOperator.Dome2();
                // AggregateOperator.Dome3();
            }
            //AllOperator
            {
                //AllOperator.Dome1();
            }
            //SequenceEqualOperator
            {

                // SequenceEqualOperator.Dome1();
                // SequenceEqualOperator.Dome2();
            }
            //AnyOperator
            {
                // AnyOperator.Dome1();
                // AnyOperator.Dome2();
            }
            //Contains
            {
                // ContainsOperator.Dome1();
                // ContainsOperator.Dome2();
            }
            //AverageAndSumOperator
            {
                // AverageAndSumOperator.Dome1();
                // AverageAndSumOperator.Dome2();

                // AverageAndSumOperator.Dome_Sum_1();
                // AverageAndSumOperator.Dome_Sum_2();
            }
            //CastAndOfTypeOperator
            {
                //CastAndOfTypeOperator.Dome1();
                // CastAndOfTypeOperator.Dome2();
            }
            //ConcatAndUnionOperator
            {
                // ConcatAndUnionOperator.Dome1();
                // ConcatAndUnionOperator.Dome2();
            }
            //CountAndLongCountOperator
            {
                // CountAndLongCountOperator.Dome1();
                // CountAndLongCountOperator.Dome2();
            }
            //DefaultIfEmptyOperator
            {

                //DefaultIfEmptyOperator.Dome1();
                //DefaultIfEmptyOperator.Dome2();
            }
            //FirstOperator
            {
            //    FirstOperator.Dome1();
            //    FirstOperator.Dome2();
            //    FirstOperator.Dome1Err();
            }
            //LastOperator
            {
                //LastOperator.Dome1();
            }
            //SingleOperator
            {
                //SingleOperator.Dome1();
                //SingleOperator.Dome2();
            }
            //ElementAtOperator
            {
                ElementAtOperator.Dome1();
                ElementAtOperator.Dome2();
            }
            System.Console.WriteLine();
            Console.ReadKey();
        }
        static void Dome8_1()
        {
            string[] names = {
                "Tom",
                "Dick",
                "Harry"
            };
            var filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);
            foreach (string n in filteredNames)
            {
                Console.WriteLine(n);
            }
            {

            }
            /*
             *Dick
             *Harry
             */
        }
        /// <summary>
        /// 查询运算符链
        /// </summary>
        static void Dome8_2()
        {
            string[] names = {
                "Tom",
                "Dick",
                "Harry",
                "Mary",
                "Jay"
            };
            IEnumerable<string> query = names
                .Where(w => w.Contains("a"))
                .OrderBy(a => a.Length)
                .Select(s => s.ToUpper());
            foreach (var item in query)
            {
                System.Console.WriteLine(item);
            }
            /*
             *JAY
             *MARY
             *HARRY
             */
        }
        /// <summary>
        /// 查询表达式
        /// </summary>
        static void Demo8_3()
        {
            //用查询表达式的方式重写dome8_2
            string[] names = {
                "Tom",
                "Dick",
                "Harry",
                "Mary",
                "Jay"
            };
            IEnumerable<string> query =
                from n in names
            where n.Contains("a")
            orderby n.Length
            select n.ToUpper();
            foreach (string name in query)
            {
                System.Console.WriteLine(name);
            }

        }
        /// <summary>
        /// 延迟执行
        /// </summary>
        static void Demo8_4()
        {
            //初始化集合
            var numbers = new List<int>
            {
                1
            };
            //映射新集合
            IEnumerable<int> query = numbers.Select(n => n * 10);
            /*
             * 按照正常的逻辑来说，代码执行到这里到这query中的元素应该是10，
             * 但是 延迟执行的特性，使得枚举时才会执行select运算符的内容。
             */
            //添加一个元素
            numbers.Add(2);

            foreach (int n in query)
                Console.Write(n + "|"); // 10|20|
        }

        /// <summary>
        /// 重复执行的坑
        /// </summary>
        static void Demo8_4_1()
        {
            var numbers = new List<int>() { 1, 2 };
            IEnumerable<int> query = numbers.Select(n => n * 10);
            foreach (int n in query)Console.Write(n + "|"); // 10|20|
            numbers.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("query clear");
            foreach (int n in query)Console.Write(n + "|"); // <nothing>
        }

        /// <summary>
        /// 捕获变量的坑
        /// </summary>
        static void Demo8_4_2()
        {
            var numbers = new List<int>() { 1, 2 };
            int factor = 10;
            var query = numbers.Select(s => s * factor);
            factor = 20;
            foreach (var item in query)
            {
                System.Console.WriteLine(item);
            }
            //20,40
        }
    }
}