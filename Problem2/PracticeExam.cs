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
            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.WriteLine($"Question {i+1}:");
                Console.WriteLine($"{Questions[i].Head} ({Questions[i].Marks} marks)");
                checkDone();
                if (done) Console.WriteLine($"Model Answer: {modelAnswer[Questions[i]]}");
                Console.WriteLine("");
            }

        }

        internal void checkDone()
        {
            done = true;
            foreach(Question q in Questions)
            {
                if (!q.Answered) done = false;
            }
        }
        public object Clone()
        {
            QuestionList q = new QuestionList();
            for (int i = 0; i < this.numOfQuestions; i++) q.Add(Questions[i]);
            return new PracticeExam(this.Time, this.numOfQuestions, q, this.Subject);

        }

        public int CompareTo(object obj)
        {
            if (obj is Exam right)
                return this.numOfQuestions - right.numOfQuestions;
            else return 0;
        }

        public PracticeExam(DateTime t, int n, QuestionList q, Subject s) : base(t, n,  q,s )
        {
            ;
        }
    }
}
