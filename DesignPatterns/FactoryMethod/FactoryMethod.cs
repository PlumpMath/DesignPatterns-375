using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//工厂方法模式有多个工厂，每个工厂生产一种产品
//具体产品的创建推迟到子类中，此时工厂类不再负责所有产品的创建，而只是给出具体工厂必须实现的接口
//每当有新产品时，只需要增加产品类和对应的工厂，两个类，不需要修改工厂接口。符合开闭原则（可扩展，不可修改）
namespace FactoryMethod
{

    public interface Product
    {
        void print();
    }

    public interface Factory
    {
        Product CreateProduct();
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

    public class Product1Factory : Factory
    {
        public Product CreateProduct()
        {
            return new Product1();
        }
    }

    public class Product2Factory : Factory
    {
        public Product CreateProduct()
        {
            return new Product2();
        }
    }

    public class Main
    {
        void Execete()
        {
            var product1 = new Product1Factory();
            product1.CreateProduct();

            var product2 = new Product2Factory();
            product2.CreateProduct();
        }
    }

}
