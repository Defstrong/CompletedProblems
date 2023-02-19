
namespace Completed_Problems.MonipulationWhisArrays
{
    static class SearchPolidromArrayOnlyForSymbolAAndB
    {
        public static int CountDeletePolidrom(this string s)
        {
            if (s.Length == 0)
                return 0;
            int startPoint = 0;
            int endPoint = s.Length - 1;
            while (startPoint < endPoint)
            {
                if (s[startPoint] == s[endPoint])
                {
                    startPoint += 1;
                    endPoint -= 1;
                }
                else
                    return 2;
            }
            return 1;
        }
    }
}
