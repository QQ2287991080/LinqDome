using System.Linq;

namespace LinqDome.Operator.量词运算符
{
    public class AnyOperator
    {
        /*
         * 当序列中有一个元素满足条件的时候就会返回true
         * bool Any<TSource>(this IEnumerable<TSource> source);
         * bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
         */

        /// <summary>
        /// 无参数
        /// </summary>
        public static void Dome1()
        {
            int[] numbers = { 1, 2, 3, 4 };
            bool flag = numbers.Any();
            System.Console.WriteLine(flag); //true
            bool any = numbers.Where(w => w > 10).Any();
            System.Console.WriteLine(any); //false
        }
        /// <summary>
        /// 有参数
        /// </summary>
        public static void Dome2()
        {
            int[] numbers = { 1, 2, 3, 4 };
            bool flag = numbers.Any(a=>a==1);
            System.Console.WriteLine(flag); //true
        }

    }
}