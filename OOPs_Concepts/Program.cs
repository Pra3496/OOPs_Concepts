namespace OOPs_Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nClasses and Methods  Example");

            ClassName className= new ClassName();
            className.printName();
            className.printType("Pranav");



            Console.WriteLine("\nConstructor Example");
            //default constructor
            Constructor ctor = new Constructor();
            //Parameteriezed constructor
            Constructor pctor = new Constructor("Pranav",25,'M');

            Console.WriteLine("\nInterface  Example");
            Interface Myinterface = new Interface();
            Myinterface.WithoutImplementationMethod();

            Console.WriteLine("\n Enums Example");
            Console.WriteLine("EnumTypes : " + Project.FIFTH);
            Console.WriteLine("EnumTypes : " + (int)Project.FIFTH);

            Console.WriteLine("\n Inheritance Example");
            //ChildClass parentClass= new ChildClass();

            //parentClass.ChildClassMethod();

            // parentClass.BaseClassMethod();

            //parentClass.BaseClassMethod();

            BaseClass parentClass= new BaseClass();
            parentClass.BaseClassVirtualMethod();
            Console.ReadKey();

        }
    }
}