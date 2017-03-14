using System;
using System.Collections.Generic;

namespace Bridge._01_Example_Printing_Before.Manuscripts
{
    public class Book : IManuscript
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Chapters { get; set; }

        public void Print() {
            Console.WriteLine($"'{Title}' by {Author}");
            Console.WriteLine($" -> {Description}");
            Console.WriteLine($" -> {String.Join(", ", Chapters)}");
        }
    }
}
