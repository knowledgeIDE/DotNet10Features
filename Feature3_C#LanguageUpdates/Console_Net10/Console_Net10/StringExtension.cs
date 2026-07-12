namespace Console_Net10;

public static class StringExtension
{
    extension(string strData)
    {
        public bool IsPalindrome()
        {
            return strData == new string(strData.Reverse().ToArray());
        }

        public int WordCount()
        {
            return strData.Split(' ').Length;
        }
    }
}
