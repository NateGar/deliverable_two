using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int checksum = 0;
            string input = "";
            string message = "";

            Console.WriteLine("Enter a word to be encoded");
            input = Console.ReadLine().ToUpper();
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                char c = letter;
                int ascii = c;
                checksum = checksum += ascii;
                string allLetters = (ascii - 64).ToString();
                message = message + allLetters + "-";
            }
            { 
                Console.WriteLine("Your encoded message is " + message);
                Console.WriteLine("message checksum is " + checksum);

                   
                
                
            }
            

    

        }
    }
}
