using System;
using System.Collections.Generic;
using System.Linq;

namespace AlphabetValues
{
    class Program
    {

        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<char, int>()
            {
                {'a', 1},
                {'b', 2},
                {'c', 3 },
                {'d', 4 },
                {'e', 5 },
                {'f', 6 },
                {'g', 7 },
                {'h', 8 },
                {'i', 9 },
                {'j', 10 },
                {'k', 11 },
                {'l', 12 },
                {'m', 13 },
                {'n', 14 },
                {'o', 15 },
                {'p', 16 },
                {'q', 17 },
                {'r', 18 },
                {'s', 19 },
                {'t', 20 },
                {'u', 21 },
                {'v', 22 },
                {'w', 23 },
                {'x', 24 },
                {'y', 25 },
                {'z', 26 }

            };

            myDictionary.ToList().ForEach(x => Console.WriteLine("{0}{1}", x.Key, x.Value));

            Console.WriteLine("enter message here: ");
            string message = Console.ReadLine();
            MessageCoder messageCoder = new MessageCoder();
            messageCoder.CodedMessage(myDictionary, message);
