using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Problem
{
    class Sample
    { 
            string pattern = "^[A-Za-z]{2,}$";
            public void ValidatingFirstName(string input)
            {
                Regex regex = new Regex(pattern);

                bool res = regex.IsMatch(input);
                if (res)
                {
                    Console.WriteLine("The Entered Name is Valid");
                }
                else
                {
                    Console.WriteLine("The Entered Name is Invalid");
                }
            }
            public void Validating()
            {
                Regex regex = new Regex(pattern);
            }
        }
    }
