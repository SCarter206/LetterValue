using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetValues
{
    class MessageCoder
    {
        public void CodedMessage(Dictionary<char, int> letterAndValuesList, string userMessage)
        {
            List<int> numberList = new List<int>();
            foreach(char letter in userMessage)
            {
                foreach(KeyValuePair<char, int> letters in letterAndValuesList)
                {
                    if (letter == letters.Key)
                    {
                        numberList.Add(letters.Value);
                    }                   
                }
            }

            string numbers = String.Join("", numberList);
            Console.WriteLine(numbers);
        }
       
    }
}
