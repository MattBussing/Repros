using System;

namespace Project2
{
    public class SampleClass
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }

        // Constructor
        public SampleClass(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }
    }
}