using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class TrueFalseQuestion: Question
    {
        //private Answer ChosenAnswer { get; set; }

        public TrueFalseQuestion(String hd, decimal mrks): base(hd, mrks,new AnswerList())
        {

            Choices.addAnswer(new Answer("True"));
            Choices.addAnswer(new Answer("False"));
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

        public override int Type()
        {
            return 1;
        }

        /*public override void Solve()
        {
            Console.WriteLine("Choose True or False:");
            Console.WriteLine(Head.ToString());
            Console.WriteLine("");
            Console.WriteLine(Choices.ToString());

            int x =0;
            bool parsed;
            do
            {
                parsed = int.TryParse(Console.ReadLine(), out x);
            } while (!parsed && (x!=1 || x!=2));

            if(ChosenAnswers.Answers.Count == 0) 
            ChosenAnswers.addAnswer(Choices.Answers[x-1]);
            Answered= true;
        }*/
    }
}
