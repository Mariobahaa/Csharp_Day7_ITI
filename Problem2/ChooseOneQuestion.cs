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
        //Override to String (abstract)
        public ChooseOneQuestion(String hd, decimal mrks, AnswerList inans, AnswerList choices) 
        : base(hd, mrks,choices)
        {
            Choices = (AnswerList)inans.Clone();
        }

        public void Solve(int ansNum)
        {
            if (ansNum >= 0 && ansNum < Choices.Answers.Count)
            {
                if (ChosenAnswers.Answers.Count == 0)
                    ChosenAnswers.addAnswer(Choices.Answers[ansNum - 1]);
                Answered = true;
            }
        }

        /*public override void Solve()
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
            Answered = true;
        }*/
    }
}
