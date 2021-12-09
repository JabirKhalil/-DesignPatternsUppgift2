using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class Email
    {
       
        public List<EmailClient> Ob { get; set; }

        public Email()
        {
            Ob = new();
        }
        public void Notification()
        {
            foreach(var item in Ob)
            {
                item.Update("This is the email");
            }
        }

        public void AddObs(EmailClient emailClient)
        {
            Ob.Add(emailClient);            
        }

        public void DeleteObs(EmailClient emailClient)
        {
            Ob.Remove(emailClient);            
        }
       
        public void Check()
        {
            
            while (DateTime.Now.Minute%2 != 0)
            {
          
            }

            Notification();
        }
// när det är en jämnt minut
// returnera strängen "This is the email"
    }
}