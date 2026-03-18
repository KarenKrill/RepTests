namespace SomeClassLibrary
{
    public class SomeClass(int id)
    {
        public int Id { get; } = id;

        public void Print()
        {
            Console.WriteLine($"SomeObject with id {Id} xexexe");
        }
        public void Print2() { }
    }
}
