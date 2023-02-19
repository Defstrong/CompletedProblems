
namespace Completed_Problems.MonipulationWhisArrays
{
    static class StringPalidrom
    {
        public static bool PolydromeAvailabilityCheck(this string searchStr)
        {
            searchStr = searchStr.ToLower();
            int startPoint = 0, endPoint = searchStr.Length - 1;
            while (startPoint < endPoint)
            {
                while (!SearchSymbols(searchStr[startPoint]) && startPoint < searchStr.Length-1)
                    startPoint++;
                while (!SearchSymbols(searchStr[endPoint]) && endPoint > 0)
                    endPoint--;

                if (searchStr[startPoint] != searchStr[endPoint] && startPoint < endPoint)
                {
                    return false;
                }
                startPoint++;
                endPoint--;
            }
            return true;
        }
        public static bool SearchSymbols(char symbol)
        {
            if ((symbol >= 'a' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
                return true;
            return false;
        }
    }
}
