using OOApp.Model;

namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher alice = new Teacher();
            Teacher bob = new();                       // >= C# 9
            var costas = new Teacher();                // syntactic sugar

            Teacher anna = new Teacher()                        // Object Initializer - Needs default constractor + setters or 'init'
            {
                Id = 1,
                Firstname = "Anna",
                Lastname = "Giannoutsou"
            };

            anna.Firstname = "Georgia";         // Works as setter
            Console.WriteLine(anna.Firstname);  // Works as getter

            Teacher andreas = new Teacher( 2, "Andreas", "Androutsos", SchoolType.KEK);     //Overload constractor - Needs all fields
        }
    }
}
