using System.Linq;

namespace LinqDome.Operator.量词运算符
{
    public class AllOperator
    {
        /*
         * 当序列中的所有元素都满足断言时，All方法就会返回true.
         */
        public static void Dome1()
        {
            int[] numbers = { 1, 3, 10, 11 };
            //元素是否全部大于10
            bool flag = numbers.All(a => a > 0);
            System.Console.WriteLine("元素是否全部大于0：" + flag);
            //元素是否全部大于5
            bool flag2 = numbers.All(a => a > 5);
            System.Console.WriteLine("元素是否全部大于5：" + flag2);
        }
    }
}