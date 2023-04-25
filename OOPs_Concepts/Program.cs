namespace OOPs_Concepts
{
    public class Program
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


            Interface Myinterface = new Interface();
            Myinterface.WithoutImplementationMethod();



        }
    }
}