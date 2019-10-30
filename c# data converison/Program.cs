using System;

namespace c__data_conversation
{
    class Program
    {
        static void Main(string[] args)
        {
            // convert bool to string
            bool boolValue = true;
            string stringValue = Convert.ToString(boolValue);
            Console.WriteLine(boolValue);

            // string to list of chars (arrays)
            string someString = "abcdfghght";
            var charsList = someString.ToCharArray();
            Console.WriteLine("Original string: {0}", someString);
            Console.WriteLine("Character array: ");
            for (int ctr = 0; ctr < charsList.Length; ctr++)
                Console.WriteLine("     {0}: {1}", ctr, charsList[ctr]);

            // 

        }
    }
}
