using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Xml.Schema;

namespace OctQs
{
    internal class Program
    {
        static void Main()
        {

            int[] num = [0, 1, 2, 2, 1];
            int[] nums = [12, 98, 21, 3, 2];


           
                Console.WriteLine(target(num, nums));
            
            

            Console.ReadKey();
        }
        string longestPalindrome(string s)
        {
            int start = 0;
            int maxlen = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                palindrome(s, i, i, start, maxlen);
                palindrome(s, i, i + 1, start, maxlen);
            }
          void palindrome(string s, int l, int r, int start, int maxlen)
        {
                while (l >= 0 && r <= s.Length - 1 && s[l] == s[r])
                {
                    l--;
                    r++;
                }
                if (r - l - 1 > maxlen)
                {
                    start = l + 1;
                    maxlen = r - l - 1;
                }
            }
            
            return s.Substring(start, maxlen);
        }
    
    

        public static int[] target(int[] nums, int[] index)
        {
            List<int> target = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentIndex = index[i];

                // Insert nums[i] at the specified index in the target array
                target.Insert(currentIndex, nums[i]);
            }

            for (int i = 0; i < target.ToArray().Length; i++)
            {
                Console.WriteLine(target[i]);
            }
                return target.ToArray();
        }

        public static string ToLowerCase(string s)
        {
            char[] chars = s.ToCharArray();
            for(int i=0; i<chars.Length; i++)
            {
                if ((int)chars[i]>=65 && (int)chars[i] <= 90)
                {
                    chars[i] = (char)(chars[i] + 32);
                }
            }
            return new string(chars);
        }

        public static string CapitalizeTitle(string title)
        {
            title= title.ToLower();
            var words = title.Split(' ');
            string ans = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 2)
                {
                    char[] chars = words[i].ToCharArray();
                    chars[0] = char.ToUpper(chars[0]);
                    words[i] = new string(chars);
                }
            }

            ans = string.Join(" ", words);
            return ans;
        }




        public static bool DetectCapitalUse(string word)
        {
            if (word.Length == 0)
                return true;
            int len = word.Length;
            int cnt = 0;
            for (int i = 0; i < len; i++)
            {
                char ch = word[i];
                var ass = (int)ch;
                if (ass > 64 && ass < 91)
                {
                    cnt++;
                }
            }

            if (cnt == len || cnt == 0)
                return true;
            if (cnt == 1 && (int)word[0] > 64 && (int)word[0] < 91)
                return true;
            return false;
        }




        public static void TitleToNumber(string columnTitle)
        {
            // Gets the Title of Excel sheet column and converts it to a column number
            int p = 0;
            double ans = 0;
            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                char c = columnTitle[i];
                int val = (int)c - 65 + 1;
                ans += val * Math.Pow(26, p);
                p++;
            }

            Console.WriteLine(ans);
        }

    }
}