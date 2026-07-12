namespace Console_Net10;

public static class StringExtension
{
    public static bool IsPalindrome(this string strData)
    {
        return strData == new string(strData.Reverse().ToArray());
    }

    public static int WordCount(this string strData)
    {
        return strData.Split(' ').Length;
    }
}
