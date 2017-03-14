using System;
using System.Collections.Generic;
using Bridge._02_Example_Printing_After.Manuscripts.Formatters;

namespace Bridge._01_Example_Printing_After.Manuscripts
{
    public class Faq : Manuscript
    {
        public Faq(IFormatter formatter) 
            : base(formatter) { }

        public string Title { get; set; }
        public IList<FaqQuestion> Questions { get; set; }

        public void AddQuestion(FaqQuestion faqQuestion) {
            Questions = Questions ?? new List<FaqQuestion>();
            Questions.Add(faqQuestion);
        }

        protected override void PrintWithFormat(IFormatter formatter) {                      
            Console.WriteLine(formatter.Format("Title", $"FAQ '{Title}':"));
            foreach (var faqQuestion in Questions) {
                Console.WriteLine(formatter.Format("LineBreak", String.Empty));
                Console.WriteLine(formatter.Format("Question", $"Q: {faqQuestion.Question}"));
                Console.WriteLine(formatter.Format("Answer", $"A: {faqQuestion.Answer}"));
            }            
        }
    }
}
