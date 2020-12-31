using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Subject
    {
        public String Name{
            get; set;
        }
        public int Id
        {
            get; set;
        }

        public Subject(String name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
