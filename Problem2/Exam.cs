using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    abstract class Exam 
    {
        protected Dictionary<Question,AnswerList> modelAnswer = new Dictionary<Question, AnswerList>();
        public DateTime Time { get; }

        public int numOfQuestions { get; }

        public QuestionList Questions { get; }

        public Subject Subject { get; set; }
        abstract public void showExam();

        public decimal Correct() {
            decimal mark = 0;
            foreach(var item in modelAnswer )
            {
                if(item.Value == item.Key.ChosenAnswers)
                {
                    mark += item.Key.Marks;
                }
            }
            return mark;
        }

        public Exam(DateTime t, int n, QuestionList q,  Subject s)
        {
            Time = t;
            numOfQuestions = n;
            Questions = new QuestionList();
            for(int i=0;i<n;i++)
            {
                Questions.Add(q[i]);
                modelAnswer[q[i]] = q[i].CorrectAnswer; 
            }
    
            Subject = s;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder("", 500);
            for (int i = 0; i < numOfQuestions; i++)
            {
                s.Append($"Question { i + 1}:\n {Questions[i].Head} ({Questions[i].Marks} marks)\n");
            }
            return s.ToString();
        }
    }
}
