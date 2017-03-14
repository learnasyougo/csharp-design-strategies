using System;
using System.Collections.Generic;
using Bridge._02_Example_Printing_After.Manuscripts.Formatters;

namespace Bridge._01_Example_Printing_After.Manuscripts
{
    public class Book : Manuscript
    {
        public Book(IFormatter formatter) 
            : base(formatter) { }

        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Chapters { get; set; }

        protected override void PrintWithFormat(IFormatter formatter) {            
            Console.WriteLine(formatter.Format("TitleAndAuthor", $"'{Title}' by {Author}"));
            Console.WriteLine(formatter.Format("Description", $" -> {Description}"));
            Console.WriteLine(formatter.Format("Chapters", $" -> {String.Join(", ", Chapters)}"));
        }
    }
}
