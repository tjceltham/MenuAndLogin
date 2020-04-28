using System;

namespace MenuAndLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            //Place top level Menu in Main 

            do
            {
                Console.WriteLine("Isogram and Palindrome Checker\n");
                Console.WriteLine("1 -Register");
                Console.WriteLine("2 -Login");
                Console.WriteLine("3 -Exit Application");
                response = Console.ReadLine();
                if (response == "1")
                {
                    RegisterPrompt();
                }
                if (response == "2")
                {
                    LoginPrompt();
                }

            } while (response != "3");
        }

        static void RegisterPrompt()
        {
            // ask user for username and password via Console ReadLine

            // call register method completed last week
        }

        static void LoginPrompt()
        {
            // get usernameame and password from user
            string user="", pass="";
            if (authenticate(user, pass) == true)
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid Credentials returning to login screen");
            }

        }

        static void register(string username, string password)
        {

        }

        static bool authenticate(string username, string password)
        {
            bool valid = true;



            return valid;
        }

        static void MainMenu()
        {
            string response = "";
           

            do
            {
                
                Console.WriteLine("1 -Palindrome Checker");
                Console.WriteLine("2 -Isogram Checker");
                Console.WriteLine("3 -Exit Application");
                response = Console.ReadLine();
                if (response == "1")
                { 
                    CheckPalindrome();
                }
                if (response == "2")
                {
                    CheckIsogram();
                }

            } while (response != "3");
        }

        static void CheckPalindrome()
        {

            // this function prompts the user for a word 
            // it them calls isPalindrome to check if the word is a Palindrome
            // Using this design allows us to re-use isPalindrome in other projects and makes
            // our code readable/maintainable and easy to test
            
            string word = "";
            Console.WriteLine("Palindrome Checker");

            Console.WriteLine("Type in a word that you would like to check is a Palindrome");
            word = Console.ReadLine();
            if(isPalindrome(word)==true)  // why could this line just be if(isPalindrome(word))?
            {
                Console.WriteLine("{0} is a Palindrome", word);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome,word",word);
            }

        }
        static void CheckIsogram()
        {
            // this function should prompt the user for a word 
            // it should then check top see if the word is an isogram
            // an Isogram is a word that does not have more than 1 instance of any particular letter in it
            // You should call the method isIsogram(string word) 
            Console.WriteLine("Isogram Checker");
        }

        static bool isIsogram(string word)
        {
            bool iso = false;
            // this function should check to see if the string in word is a isogram
            // it should return true if the string is an isogram and false
            // if the string is not an isodrome
            // Extension - this function should not count upper and lower cases letters seperately

            return iso;
        }

        static bool isPalindrome(string word)
        {
            bool palin = false;
            // this function should check to see if the string in word is a palindrome
            // it should return true if the string is a palindrome and false
            // if the string is not a palindrome
            //Extension - this code should be case insenitive i.e. Otto is a palindrome



            return palin;

        }
    }
}
