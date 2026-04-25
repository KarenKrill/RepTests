using SomeClassLibrary;

namespace RepTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var id = 13;
            SomeClass someClass = new(id);
            someClass.Print();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World2!");
            Console.WriteLine("Welcome to main branch!");
            var nextId = SomeNativeLibWrap.Sum(id, 15);
            Console.WriteLine($"NextId: {nextId}");
        }
    }
}
