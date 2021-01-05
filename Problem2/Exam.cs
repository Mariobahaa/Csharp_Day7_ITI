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

        //public QuestionList Questions { get; }

        public Dictionary<Question, AnswerList> getModel()
        {
            
            return modelAnswer;
        }
        public Subject Subject { get; set; }
        abstract public void showExam();

        public decimal Correct() {
            decimal mark = 0;
            foreach(var item in modelAnswer )
            {
                if(item.Value.Equals(item.Key.ChosenAnswers))
                {
                    mark += item.Key.Marks;
                }
            }
            return mark;
        }

        public Exam(DateTime t, int n, QuestionList q, List<AnswerList> a, Subject s)
        {
            Time = t;
            numOfQuestions = n;
            //Questions = new QuestionList();
            for(int i=0;i<n;i++)
            {
                //Questions.Add(q[i]);
                modelAnswer[q[i]] = a[i]; 
            }
    
            Subject = s;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder("", 500);
            s.Append($"Subject: {Subject.ToString()}\t\ttime: {Time.ToString()}");
            int i=1;
            foreach( var item in modelAnswer)
            {
                s.Append($"Question { i}:\n {item.Key.ToString()}\n\n");
                i++;
                for (int j = 1; j <= item.Key.Choices.Answers.Count; j++)
                    s.Append($"{j}. {item.Key.Choices.Answers[j-1]}\n");
            }
            return s.ToString();
        }

    }
}
