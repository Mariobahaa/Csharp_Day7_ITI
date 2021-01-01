using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    abstract class Exam 
    {
        protected Dictionary<Question,AnswerList> ModelAnswer;
        public DateTime Time { get; }

        public int numOfQuestions { get; }

        protected QuestionList questions;

        public Subject Subject { get; set; }
        abstract public void showExam();

 

        public Exam(DateTime t, int n, QuestionList q, Subject s)
        {
            Time = t;
            numOfQuestions = n;
            questions = new QuestionList();
            for(int i=0;i<n;i++)
            {
                questions.Add(q[i]);
            }
            Subject = s;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder("", 500);
            for (int i = 0; i < numOfQuestions; i++)
            {
                s.Append($"Question { i + 1}:\n {questions[i].Head} ({questions[i].Marks} marks)\n");
            }
            return s.ToString();
        }
    }
}
