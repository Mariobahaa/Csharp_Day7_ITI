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
    }
}
