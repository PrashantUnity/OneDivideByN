internal class Divider
{
    internal static (List<int>,List<int>) Divide( int Dividend,int Divisor, int decimalLimit)
    {
        if (Dividend == 0) throw new DivideByZeroException("Number Divide By zero");
        var ls = new List<int>();
        var lsDecimal = new List<int>();
        var (num,times) = Dividing(Dividend, Divisor);

        while(lsDecimal.Count<= decimalLimit)
        {
            Dividend = num % Divisor;
            if (times > 0)
            {
                while (times-- > 1) { lsDecimal.Add(0); }
                var nums = num % Divisor;
                if (nums >= 0) { lsDecimal.Add(num / Divisor); }
            }
            else
            {
                ls.Add(num / Divisor);
            }
            if (Dividend == 0) return (ls, lsDecimal);
            (num, times) = Dividing(Dividend, Divisor);
        } 
        return (ls, lsDecimal);
    }
    public static (int,int) Dividing(int n,int d)
    {
        int count = 0;
        while(n<d)
        {
            n = n * 10;
            count++;
        }
        return (n, count);
    }

    public static string FindLongestRepeatingSubstring(string input)
    {
        int n = input.Length;
        string longestSubstring = "";

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int length = j - i;
                if (i + 2 * length <= n)
                {
                    string substring = input.Substring(i, length);
                    string nextSubstring = input.Substring(i + length, length);
                    if (substring.Equals(nextSubstring) && !substring.Equals(longestSubstring))
                    {
                        longestSubstring = substring;
                    }
                }
            }
        }

        return longestSubstring;
    }
}