using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Worker
    {
        private string name;
        public string Name { get { return name; } }
     

        public Worker(string name)
        {
            this.name = name;
           
        }
    }
}
