using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class ChooseOneQuestion : Question
    {
        //private Answer ChosenAnswer { get; set; }

        public ChooseOneQuestion(String hd, decimal mrks, AnswerList inans) : base(hd, mrks)
        {
            Choices = (AnswerList)inans.Clone();
        }

        public override void Solve()
        {
            Console.WriteLine("Choose One Answer:");
            Console.WriteLine(Head.ToString());
            Console.WriteLine("");
            Console.WriteLine(Choices.ToString());

            int x = 0;
            bool parsed;
            do
            {
                parsed = int.TryParse(Console.ReadLine(), out x);
            } while (!parsed && (x >= 1 || x <= Choices.Answers.Count));

            ChosenAnswers.addAnswer(Choices.Answers[x - 1]);
        }
    }
}
