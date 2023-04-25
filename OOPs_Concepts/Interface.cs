using System;


namespace OOPs_Concepts
{
    // Interface is like abstract class
    //  We cannot create object for an interface.
    //  the private members are not allowed in the interface
    //  By default interface members are abstract and public
    interface InterfaceType
    {
        void WithoutImplementationMethod();
    }
    public class Interface : InterfaceType
    {
        public void WithoutImplementationMethod()
        {
            Console.WriteLine("Into the WithoutImplementationMethod of Interface.cs");
        }
    }
}
