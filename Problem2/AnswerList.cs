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
                str.Append($"{i + 1}. {answers[i]}\n");
            }
            return str.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is AnswerList exam)
            {
                if (exam.Answers.Count != this?.Answers.Count) return false;

                //if (this.GetHashCode() == exam?.GetHashCode()) return true;
                int cnt = 0;
                for (int i = 0; i < this.Answers.Count; i++)
                {
                    for (int j = 0; j < exam.Answers.Count; j++)
                        if (exam.Answers[i].Equals(this.Answers[j]))
                            cnt++;
                }

                if (cnt == this?.Answers?.Count)
                return true;
            }
            return false;
        }
    }
}
