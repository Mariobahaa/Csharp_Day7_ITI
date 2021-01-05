using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class ChooseAllQuestion : Question
    {
        
        public ChooseAllQuestion(String hd, decimal mrks,  AnswerList inans, AnswerList crct , AnswerList choices) : base(hd, mrks,crct, choices)
        {
            Choices = (AnswerList)inans.Clone();

        }

        public override void Solve()
        {
            Console.WriteLine("Choose All that Apply:");
            Console.WriteLine(Head.ToString());
            Console.WriteLine("");
            Console.WriteLine(Choices.ToString());

           
            int x = 0;
            bool valid = true;
            do
            {
                String str;
                str = Console.ReadLine();
                String[] Choice = str?.Split();
                if (Choice.Length > Choices.Answers.Count) valid = false;
                else
                {
                    for (int i = 0; i < Choice.Length && valid; i++)
                    { 
                        valid = int.TryParse(Console.ReadLine(), out x); 
                        if(x <= 0 || x>= Choices.Answers.Count)
                        {
                            valid = false;
                        }
                        else { ChosenAnswers.addAnswer(Choices.Answers[x - 1]); }
                    }

                  
                }
            } while (!valid);

            Answered = true;


        }
    }
}
