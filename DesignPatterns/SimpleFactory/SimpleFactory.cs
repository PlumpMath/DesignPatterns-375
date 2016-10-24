using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 简单工厂模式只有一个工厂， 工厂可以生产多种产品。
// 所以当产品很多的时候，工厂类变的复杂。
//但是如果新加一个产品，因为需要更改工厂类（新加一个case），不符合开闭原则（可扩展，不可修改）。
namespace SimpleFactory
{
    public interface Product
    {
        void print();
    }

    public class Product1 : Product
    {
        public void print()
        {
            Console.WriteLine("this is product1");
        }
    }

    public class Product2 : Product
    {
        public void print()
        {
            Console.WriteLine("this is product2");
        }
    }

    public class Factory
    {
        public static Product CreateProduct(string type)
        {
            if (type == "product1")
            {
                return new Product1();
            }

            if (type == "product2")
            {
                return new Product2();
            }

            return new Product1();
        }
    }

    public class Main
    {
        void Execete()
        {
            var footballlInstance = Factory.CreateProduct("product1");
        }
    }

     
}
