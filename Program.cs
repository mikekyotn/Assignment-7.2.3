namespace Assignment_7._2._3
{
    //Given two string s and t, return true if t is an anagram of s, false otherwise
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            string test1s = "anagram";
            string test1t = "nagaram";
            string test2s = "rat";
            string test2t = "car";

            Console.WriteLine(IsAnagram(test1s, test1t));
            Console.WriteLine(IsAnagram(test2s, test2t));

            Console.ReadKey();
        }

        //Use a dictionary<char, int> to count number of chars in s. 
        //Compare t to dictionary and decrement counter
        //return false if a letter is not found in dictionary
        //return false if not all values are 0 after checking t
        static bool IsAnagram (string s, string t)
        {
            Dictionary<char, int> countChars = new Dictionary<char, int>();
            
            foreach(char c in s)
            {
                if (countChars.ContainsKey(c))
                    countChars[c]++;
                else
                    countChars.Add(c, 1);
            }
            foreach(char c in t)
            {
                if (countChars.ContainsKey(c))
                    countChars[c]--;
                else
                    return false;
            }
            foreach (KeyValuePair<char, int> pair in countChars)
                if (pair.Value != 0) return false;

            return true;
        }


    }
}
