using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regularExpression
{
    class Class1
    {
        public bool emailverification(string inputemail)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(inputemail);
            if (match.Success)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        public bool passwordverification(String inputpassword)
        {
            //Regex regex = new Regex(@"^[A-Za-z]{0,1}[a-zA-Z]{0,1}[1|3|5|7|9]{0,1}[!|@|#|$|%|^|&|]+[A-Z]{0,1}[a-z]{0,1}[0-9]{0,1}[!|@|#|$|%|^|&|]{0,1}$");
            //Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[1|3|5|7|9])(?=.*?[#?!@$%^&*-]).{8,}$");
            Regex regex = new Regex(@"^(?=.[A-Z])(?=.\W)(?=.\d)([13579](?![13579])|[A-Z](?![A-Z])|\W|[a-z](?![a-z]))$");
            Match match = regex.Match(inputpassword);
            if (match.Success)
            {
                return (true);
            }
            else
            {
                return (false);
            }
         }
    }
}
