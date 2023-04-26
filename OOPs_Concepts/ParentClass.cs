using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    public class BaseClass
    {
        public string name;
        public void BaseClassMethod()
        {
            Console.WriteLine("This is a base class");
        }

        public virtual void BaseClassVirtualMethod()
        {
            Console.WriteLine("This is my method for parent class");
        }
    }

    public class ChildClass : BaseClass
    {
        public ChildClass()
        {
            Console.WriteLine("This is my Parent class");

        }
        public void ChildClassMethod()
        {
            Console.WriteLine("This is my method for parent class");
        }

        public override void BaseClassVirtualMethod()
        {
            Console.WriteLine("This is a Child class overrided");
        }



    }

    
}
