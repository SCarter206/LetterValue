using System;
using System.Collections.Generic;

namespace AlphabetValues
{
    class Program
    {

        static void Main(string[] args)
        {
            //letter listed, @ provides 0 index value
            List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f',
                'g','h','i','j','k','l','m','n','o','p','q','r','s',
                't','u','v','w','x','y','z' };

            //list of numbers created to create letter values
            List<int> value = new List<int>();
            for (int i = 1; i <= alphabet.Count; i++)
                value.Add(i);

            try
            {
                for (var i = 0; i <= alphabet.Count; i++)
                    Console.WriteLine(alphabet[i] + ":" + value[i]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("end of list");
            }

            MessageCoder messageCoder = new MessageCoder();
            messageCoder.CodedMessage();


            
            
        }
