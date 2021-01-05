using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class PracticeExam : Exam, ICloneable, IComparable
    {
        bool done = false;

        public override void showExam()
        {
            int i = 1;
            foreach (var item in modelAnswer)
            {
                Console.WriteLine($"Question {i}:");
                Console.WriteLine($"Question { i}:\n { item.Key.ToString()}\n");
                checkDone();
                if (done) Console.WriteLine($"Model Answer: {item.Value.ToString()}");
                Console.WriteLine("");
            }

        }

        internal void checkDone()
        {
            done = true;
            foreach (var item in modelAnswer)
            {
                if (!item.Key.Answered) done = false;
            }
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
            return new FinalExam(this.Time, this.numOfQuestions, q, a, this.Subject);

        }

        public int CompareTo(object obj)
        {
            if (obj is Exam right)
                return this.numOfQuestions - right.numOfQuestions;
            else return 0;
        }

        public PracticeExam(DateTime t, int n, QuestionList q, List<AnswerList> a, Subject s) : base(t, n, q, a, s )
        {
            ;
        }
    }
}
