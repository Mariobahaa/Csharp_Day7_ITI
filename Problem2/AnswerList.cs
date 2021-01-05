using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class AnswerList : ICloneable
    {
        private List<Answer> answers;

        public List<Answer> Answers{
            get { return answers; }
        }
        public AnswerList()
        {
            answers = new List<Answer>();
        }

        public void addAnswer(Answer ans)
        {
            answers.Add(ans);
        }

        public object Clone()
        {
            AnswerList Choices = new AnswerList();
            for (int i = 0; i < answers?.Count; i++)
            {
                Choices.addAnswer(answers[i]);
            }
            return Choices;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder("", 100);
            for(int i=0;i<answers.Count;i++)
            {
                str.Append($"{i + 1}. {answers[i]}");
            }
            return str.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is AnswerList exam)
            {
                if (exam.Answers.Count != this?.Answers.Count) return false;

                if (this.GetHashCode() == exam?.GetHashCode()) return true;

                for (int i = 0; i < this.Answers.Count; i++)
                {
                    if (exam.Answers[i] != this.Answers[i]) return false;
                }

                return true;
            }
            return false;
        }
    }
}
