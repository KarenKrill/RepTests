namespace SomeClassLibrary
{
    public class SomeClass(int id)
    {
        public int Id { get; } = id;

        public void Print()
        {
            Console.WriteLine($"HohohohSomeObject with id {Id}");
        }
        public void Print2() { }
    }
}
