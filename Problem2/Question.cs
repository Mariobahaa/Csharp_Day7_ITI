using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem2
{
    abstract class Question 
    {
        public String Head { get; set; }

        public decimal Marks { get; set; } 

        public bool Answered { get; set; } = false;

        public AnswerList Choices { get; set; }

        public AnswerList ChosenAnswers { get; set; }

        //public AnswerList CorrectAnswer { get;  }//

        public Question(String h, decimal m, AnswerList choices){
            Head = h;
            Marks = m;
            //CorrectAnswer = (AnswerList) crct.Clone();
            ChosenAnswers = new AnswerList();
            Choices = (AnswerList)choices.Clone();
        }

        public override string ToString()
        {
            return $"{Head} ({Marks} marks)\n";
        }

        public override bool Equals(object obj)
        {
            Question question = obj as Question;
            if (question == null) return false;
            //if (question?.GetHashCode() == this?.GetHashCode()) return true;
            if (question?.Head == Head) return true;
            return false;

        }

        public abstract int Type();

        public void Solve(int ansNum)
        {
            if (ansNum > 0 && ansNum <= Choices.Answers.Count)
            {
                if (ChosenAnswers.Answers.Count == 0)
                    ChosenAnswers.addAnswer(Choices.Answers[ansNum - 1]);
                else if (ChosenAnswers.Answers.Count > 0 && this.Type() == 3 
                    && ChosenAnswers.Answers.Count<Choices.Answers.Count)
                {
                    ChosenAnswers.addAnswer(Choices.Answers[ansNum - 1]);
                }
                Answered = true;
            }
        }
    }
}
