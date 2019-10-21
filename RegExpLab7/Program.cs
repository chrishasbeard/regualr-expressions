using System;
using System.Text.RegularExpressions;

namespace RegExpLab7
{
    class Program
    {
        static string output = string.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me  about yourself! Enter one of the options below");
            Console.WriteLine("1) phone number ###-###-#### \n2) Name (capitcalized first letter of the first and last name) \n3) Email \n4) Birthdate(dd/mm/yyyy)");
            string input = Console.ReadLine();  
            switch (input)
            {
                case "1":
                    Console.Write("Please give me a phone #: ");
                    input = Console.ReadLine();
                    NumCheck(input);
                    break;
                case "2":
                    Console.Write("Please give me a name with the first letters capitalized.");
                    input = Console.ReadLine();
                    NameCheck(input);
                    break;
                case "3":
                    Console.Write("What is your email?");
                    input = Console.ReadLine();
                    MailCheck(input);
                    break;
                case "4":
                    Console.Write("Please give me your birthdate.");
                    input = Console.ReadLine();
                    AgeCheck(input);
                    break;
            }
            Console.WriteLine(output);
            
           // NumCheck(input);
            //MailCheck(input);
            //NameCheck(input);
            //AgeCheck(input);
            //Console.Write(output);
        }

        public static string NumCheck(string input)
        {
            if (Regex.IsMatch(input, @"\d{3}-\d{3}-\d{4}"))
            {
                output = "Yay! a whole phone#? I never got one of those before!!";
            }
            else
            {
                output =  "Oh no! that was an invalid phone #";
            }
            return output;
        }

        public static string MailCheck(string input)
        {
            if (Regex.IsMatch(input, @"^[A-Za-z0-9]{5,30}[@][a-zA-Z0-9]{5,10}[.][A-Za-z0-9]{2,3}"))
            {
                output = "Nice email, Don't send me to the spam folder! :)";
            }
            else
            {
                output = "That email is invalid and will not let me sign in on your Netflix. . . ";
            }
            return output;
        }

        public static string NameCheck(string input)
        {
            if (Regex.IsMatch(input, @"[^a-z\s][a-z]{1,30}"))
            {
                output = "Wow, that name sounds so exotic!";
            }
            else
            {
                output = "Please enter a real name, silly.";
            }
            return output;
        }

        public static string AgeCheck(string input)
        {
            if (Regex.IsMatch(input, @"\d{2}[/]\d{2}[/]\d{4}"))
            {
                output = "you aged like fine wine!";
            }
            else
            {
                output = "You either formatted wrong, or don't grasp the concept of time";
            }
            return output;
        }
    }
}
