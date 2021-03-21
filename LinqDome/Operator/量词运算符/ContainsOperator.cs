using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Contains 运算符
/// </summary>
public class ContainsOperator
{

    /*
     * Contains 的功能其实跟Any是差不多的，但是没有Any强大，Contains可以实现相等比较器。
     *bool Contains<TSource>(this IEnumerable<TSource> source, TSource value);
     *bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer);
     */
    /// <summary>
    /// 第一个参数
    /// </summary>
    public static void Dome1()
    {
        int[] numbers = { 1, 2, 3, 4 };
        bool flag = numbers.Contains(1);
        System.Console.WriteLine(flag); //true
    }
    /// <summary>
    /// 第二个参数，实现相等比较器
    /// </summary>
    public static void Dome2()
    {

        Product[] fruits = {
            new Product { Name = "apple", Code = 9 },
            new Product { Name = "orange", Code = 4 },
            new Product { Name = "lemon", Code = 12 }
        };

        Product apple = new Product { Name = "apple", Code = 9 };
        Product kiwi = new Product { Name = "kiwi", Code = 8 };

        ProductComparer prodc = new ProductComparer();

        bool hasApple = fruits.Contains(apple, prodc);
        bool hasKiwi = fruits.Contains(kiwi, prodc);

        Console.WriteLine("Apple? " + hasApple);
        Console.WriteLine("Kiwi? " + hasKiwi);
    }

    public class Product
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }

    // Custom comparer for the Product class
    class ProductComparer : IEqualityComparer<Product>
    {
        // Products are equal if their names and product numbers are equal.
        public bool Equals(Product x, Product y)
        {

            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y))return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.Code == y.Code && x.Name == y.Name;
        }

        // If Equals() returns true for a pair of objects
        // then GetHashCode() must return the same value for these objects.

        public int GetHashCode(Product product)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(product, null))return 0;

            //Get hash code for the Name field if it is not null.
            int hashProductName = product.Name == null ? 0 : product.Name.GetHashCode();

            //Get hash code for the Code field.
            int hashProductCode = product.Code.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName ^ hashProductCode;
        }
    }
}