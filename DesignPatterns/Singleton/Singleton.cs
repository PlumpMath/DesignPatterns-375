using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton currentInstance;
        private Singleton() { }

        public static Singleton CreateInstance()
        {
            if (currentInstance == null)
            {
                currentInstance = new Singleton();
            }

            return currentInstance;
        }
    }

    // above sample is not considering mutiple threads scenarios
    public class MultipleThreadsSingleton
    {
        private static MultipleThreadsSingleton currentInstance;
        private MultipleThreadsSingleton() { }
        private static object locker = new object();
        public static MultipleThreadsSingleton CreateInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            if (currentInstance == null)
            {
                lock (locker)
                {
                    if (currentInstance == null)
                    {
                        currentInstance = new MultipleThreadsSingleton();
                    }
                }
            }   

            return currentInstance;
        }
    }


    public class Main
    {
        public void Execute()
        {
            var a = Singleton.CreateInstance();
            var b = MultipleThreadsSingleton.CreateInstance();
        }
    }
}
