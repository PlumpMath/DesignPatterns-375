using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//抽象工厂模式有多个工厂，每个工厂可以生产多种产品
//可以新增工厂， 例如以下例子可以新增一个操作系统OSX。
//易于交换工厂。
//但是如果新加一个产品，因为需要更改工厂接口，不符合开闭原则（可扩展，不可修改）。
namespace AbstractFactory
{
    public interface Button
    {
        
    }

    public interface TextBox
    {
       
    }

    public interface Factory
    {
        Button CreateButton();
        TextBox CreateTextBox();
    }

    public class UnixButton : Button
    {
        public UnixButton()
        {
            Console.WriteLine("UnixButton is created");
        }
    }

    public class UnixTextBox : TextBox
    {
        public UnixTextBox()
        {
            Console.WriteLine("UnixTextBox is created");
        }
    }

    public class WindowsButton : Button
    {
        public WindowsButton()
        {
            Console.WriteLine("WindowsButton is created");
        }
    }

    public class WindowsTextBox : TextBox
    {
        public WindowsTextBox()
        {
            Console.WriteLine("WindowsTextBox is created");
        }
    }

    public class UnixFactory :Factory
    {
        public Button CreateButton()
        {
            return new UnixButton();
        }

        public TextBox CreateTextBox()
        {
            return new UnixTextBox();
        }
    }

    public class WindowsFactory : Factory
    {
        public Button CreateButton()
        {
            return new WindowsButton();
        }

        public TextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }

    class Main
    {
        void Execute()
        {
            var unix = new UnixFactory();
            unix.CreateButton();
            unix.CreateTextBox();


            var windows = new WindowsFactory();
            windows.CreateButton();
            windows.CreateTextBox();

        }
    }
}
