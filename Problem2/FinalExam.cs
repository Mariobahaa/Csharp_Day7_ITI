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
            Console.WriteLine(this.ToString());

        }

        public object Clone()
        {
            List<AnswerList> a = new List<AnswerList>();
            QuestionList q = new QuestionList();
            foreach (var item in modelAnswer) 
            { 
                q.Add(item.Key);
                a.Add(item.Value);
            }
            return new FinalExam(this.Time, this.numOfQuestions, q,a, this.Subject);
            
        }

        public int CompareTo(object obj)
        {
            if (obj is Exam right)
                return this.numOfQuestions - right.numOfQuestions;
            else return 0;
        }

        public FinalExam(DateTime t, int n, QuestionList q, List<AnswerList> a, Subject s) : base(t, n, q,a, s)
        {
            ;
        }


    }
}
