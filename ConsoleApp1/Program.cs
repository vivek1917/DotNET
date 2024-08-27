namespace ConsoleApp1
{

    abstract class Shape{
        String Shape_Name { get; set;}

        public abstract void GetArea();

    }

    class Circle : Shape
    {
        public override void GetArea()
        {
            System.Console.WriteLine("Hello World");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Circle co = new Circle();
            co.GetArea();
        }
    }
}