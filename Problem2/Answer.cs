using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Answer
    {
        public String Body { get;  }

        public Answer(String ans)
        {
            Body = ans;
        }

        public override string ToString()
        {
            return Body;
        }

        public override bool Equals(object obj)
        {
            Answer ans = obj as Answer;
            if (ans == null) return false;
            if (ans?.GetHashCode() == this?.GetHashCode()) return true;
            if (ans?.Body == Body) return true;
            return false;
        }
    }
}
