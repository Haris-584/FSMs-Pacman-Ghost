using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Class1 c = new Class1();
            Console.WriteLine("Enter email");
            string inputemail = Console.ReadLine();
          
           //verify email
           Console.WriteLine("Email is " +c.emailverification(inputemail));
            
            //verify password
            Console.WriteLine("Enter password");
            string inputpassword = Console.ReadLine();

        
            Console.WriteLine("Password is " + c.passwordverification(inputpassword));
            
           Console.ReadLine();
           Environment.Exit(0);


        }

      
    }
}
