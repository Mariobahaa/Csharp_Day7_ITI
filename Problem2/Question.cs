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

        protected AnswerList Choices { get; set; }

        public AnswerList ChosenAnswers { get; set; }

        public AnswerList CorrectAnswer { get;  }

        public Question(String h, decimal m, AnswerList crct){
            Head = h;
            Marks = m;
            CorrectAnswer = (AnswerList) crct.Clone();
        }

        public override string ToString()
        {
            return $"{Head} ({Marks} marks)";
        }

        public abstract void Solve();
    }
}
