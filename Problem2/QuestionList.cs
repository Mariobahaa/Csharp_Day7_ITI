using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem2
{

    //class QuestionList<T> : System.Collections.Generic.List<T>
    class QuestionList: List<Question>
    {
        public void Add(Question Q)
        {
            base.Add(Q);
            try
            {
                using (StreamWriter sw = File.AppendText("QuestionLog.txt"))
                {
                    sw.WriteLine(Q.ToString());
                }
                    
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured please Contact your Software Provider.");
            }

        }
    }
}
