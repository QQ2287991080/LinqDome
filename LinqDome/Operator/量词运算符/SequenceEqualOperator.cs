using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqDome.Operator.量词运算符
{
    public class SequenceEqualOperator
    {
        /*
         * SequenceEqual 运算符比较两个序列。当两个序列都含有相同元素，并且顺序相等，返回true。
         * SequenceEqual 运算符的第二个参数支持相等比较器。
         * bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
         * bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
         */

        /// <summary>
        /// 一个参数
        /// </summary>
        public static void Dome1()
        {
            Pet pet1 = new Pet { Name = "Turbo", Age = 2 };
            Pet pet2 = new Pet { Name = "Peanut", Age = 8 };

            // Create two lists of pets.
            List<Pet> pets1 = new List<Pet> { pet1, pet2 };
            List<Pet> pets2 = new List<Pet> { pet1, pet2 };

            bool equal = pets1.SequenceEqual(pets2);

            Console.WriteLine(
                "The lists {0} equal.",
                equal ? "are" : "are not");
        }
        /// <summary>
        /// 两个参数,(实现相等比较器)
        /// </summary>
        public static void Dome2()
        {
            ProductA[] storeA = {
                new ProductA { Name = "apple", Code = 9 },
                new ProductA { Name = "orange", Code = 4 }
            };
            ProductA[] storeB = {
                new ProductA { Name = "apple", Code = 9 },
                new ProductA { Name = "orange", Code = 4 }
            };

            bool equalAB = storeA.SequenceEqual(storeB);
            Console.WriteLine("Equal? " + equalAB);
        }
    }
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class ProductA : IEquatable<ProductA>
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public bool Equals(ProductA other)
        {
            if (other is null)
                return false;

            return this.Name == other.Name && this.Code == other.Code;
        }
        public override bool Equals(object obj) => Equals(obj as ProductA);
        public override int GetHashCode() => (Name, Code).GetHashCode();
    }
}