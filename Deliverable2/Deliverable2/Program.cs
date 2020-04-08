using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to be encoded");
            string input = Console.ReadLine().ToUpper();
            for(int i =0;i<input.Length;i++)
            {
                char letter = input[i];
                char c = letter;
                int ascii = c;
                Console.Write(ascii + "-");
                
                

                   
                
                
            }
            

    

        }
    }
}
