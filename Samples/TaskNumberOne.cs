namespace Samples
{
    public static class TaskNumberOne
    {
        public static bool Palindrome(string text)
        {
            var rev = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                rev = rev + text[i];
            }

            var result = text == rev ? true : false;
            return result;
        }
    }
}