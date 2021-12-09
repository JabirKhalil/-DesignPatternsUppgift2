using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class EmailClient
    {
        void Run()
        {
            var emailServer = new Email();
            emailServer.AddObs(this);
            
        }
        public void Update(string x)
        {
            Console.WriteLine(x);
        }
    }
}
