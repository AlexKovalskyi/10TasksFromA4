using PalindromeInText.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeInText
{
    public class PalindromeTester
    {
        private IPalindrome _palindromeChecker;
        private string _content;
        private string _destinationDir;

        public PalindromeTester(IPalindrome palindromeService, string content, string destinationDir)
        {
            
        }

        public void Execute()
        {
            //TODO: use Stopwatch here.
            TestPalindrome(_content, _destinationDir);
        }

        private void TestPalindrome(string content, string destinationDir)
        {
            //TODO: use _palindromeChecker.IsPalindrome(string str)
        }
    }
}
