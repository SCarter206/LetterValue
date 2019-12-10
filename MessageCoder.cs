using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetValues
{
    class MessageCoder
    {
        //letter listed, @ provides 0 index value
        List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f',
                'g','h','i','j','k','l','m','n','o','p','q','r','s',
                't','u','v','w','x','y','z' };


        public void CodedMessage()
        {
            //list of numbers created to create letter values
            List<int> value = new List<int>();
            for (int i = 1; i <= alphabet.Count; i++)
            {
                value.Add(i);
            }
            
            Console.WriteLine("input message here: ");
            string x = Console.ReadLine();
            //string codeMessage;
            try
            {
                foreach (char letter in x)
                {
                    foreach (char alphaletter in alphabet)
                    {
                        if (letter == alphaletter)
                            Console.WriteLine(value[alphaletter]);
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("we have an issue");
                throw;
            }
            
                
        }

       
    }
}
