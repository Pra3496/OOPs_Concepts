﻿namespace OOPs_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassName className= new ClassName();
            className.printName();
            className.printType("Pranav");
            

            //default constructor
            Constructor ctor = new Constructor();
            //Parameteriezed constructor
            Constructor pctor = new Constructor("Pranav",25,'M');
            

            
        }
    }
}