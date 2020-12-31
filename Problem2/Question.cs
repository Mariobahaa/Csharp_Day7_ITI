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

        protected AnswerList Choices { get; }

        


        public Question(String h, decimal m){
            Head = h;
            Marks = m;
          
        }

        public override string ToString()
        {
            return $"{Head} ({Marks} marks)";
        }

        public abstract void Solve();
    }
}
