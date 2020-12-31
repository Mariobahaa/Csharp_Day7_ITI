using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    abstract class Exam 
    {
        public float Time { get; }

        public int numOfQuestions { get; }

        protected Question[] questions;

        public Subject Subject { get; set; }
        abstract public void showExam();

 

        public Exam(float t, int n, Question[] q, Subject s)
        {
            Time = t;
            numOfQuestions = n;
            questions = new Question[n];
            for(int i=0;i<n;i++)
            {
                questions[i] = q[i];
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
