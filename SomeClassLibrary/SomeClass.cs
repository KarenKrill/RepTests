namespace SomeClassLibrary
{
    public class SomeClass
    {
        public int Id { get; set; }
        public SomeClass(int id)
        {
            Id = id;
        }
        public void Print()
        {
            Console.WriteLine($"SomeObject with id {Id}");
        }
        public void Print2() { }
    }
}
