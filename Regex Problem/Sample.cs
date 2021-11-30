﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Problem
{
    class Sample
    {
        static string FnamePattern = "^[A-Z]{1}[a-z]{2,}$";
        static string LnamePattern = "^[A-Z]{1}[a-z]{2,}$";
        static string EmailPattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public void ValidatingFirstName(string input)
        {
            Regex regex = new Regex(FnamePattern);
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
            Regex regex = new Regex(FnamePattern);
        }

        public void ValidatingLastName(string inputLastName)
        {
            Regex regex = new Regex(LnamePattern);
            bool result = regex.IsMatch(inputLastName);
            if (result)
            {
                Console.WriteLine("The Entered LastName is Valid");
            }
            else
            {
                Console.WriteLine("The Entered LastName is Invalid");
            }
        }
        public void Validatingl()
        {
            Regex regex = new Regex(LnamePattern);
        }

        public void ValidatingEmail(string inputMail)
        {
            Regex regex = new Regex(EmailPattern);
            bool res = regex.IsMatch(inputMail);
            if (res)
            {
                Console.WriteLine("The Email is valid");
            }
            else
            {
                Console.WriteLine("The Email is Invalid");
            }
        }
        public void ValidatingE()
        {
            Regex regex = new Regex(EmailPattern);
        }
    }
}
