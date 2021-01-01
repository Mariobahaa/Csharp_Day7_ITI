using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Problem2
{
    class FinalExam : Exam, ICloneable, IComparable
    {
        

        public override void showExam()
        {
            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.WriteLine($"Question {i+1}:");
                Console.WriteLine($"{questions[i].Head} ({questions[i].Marks} marks)");
               
                Console.WriteLine("");
            }

        }

        public object Clone()
        {
            QuestionList q = new QuestionList();
            for (int i = 0; i < this.numOfQuestions; i++) q.Add(questions[i]);
            return new FinalExam(this.Time, this.numOfQuestions, q, this.Subject);
            
        }

        public int CompareTo(object obj)
        {
            if (obj is Exam right)
                return this.numOfQuestions - right.numOfQuestions;
            else return 0;
        }

        public FinalExam(float t, int n, QuestionList q, Subject s) : base(t, n, q, s)
        {
            ;
        }


    }
}
