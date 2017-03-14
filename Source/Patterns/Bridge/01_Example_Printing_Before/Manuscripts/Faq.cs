using System;
using System.Collections.Generic;

namespace Bridge._01_Example_Printing_Before.Manuscripts
{
    public class Faq : IManuscript
    {
        public string Title { get; set; }
        public IList<FaqQuestion> Questions { get; set; }

        public void AddQuestion(FaqQuestion faqQuestion) {
            Questions = Questions ?? new List<FaqQuestion>();
            Questions.Add(faqQuestion);
        }

        public void Print() {
            Console.WriteLine($"FAQ '{Title}':");
            foreach(var faqQuestion in Questions) {
                Console.WriteLine();
                Console.WriteLine($"Q: {faqQuestion.Question}");
                Console.WriteLine($"A: {faqQuestion.Answer}");                
            }
        }
    }
}
