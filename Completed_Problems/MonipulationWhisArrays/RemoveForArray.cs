
namespace Completed_Problems.MonipulationWhisArrays
{
    static public class RemoveForArray
    {
        public static int Remove(this int[] numbers, int val)
        {
            int ansCount = numbers.Length;
            if(numbers.Length == 0)
            {
                return 0;
            }
            if (numbers[numbers.Length - 1] == val)
            {
                numbers[numbers.Length - 1] = -1;
                ansCount--;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == val)
                    ansCount--;
                if (numbers[i] == val || numbers[i] == -1)
                {
                    int j = i;
                    while ((numbers[j] == val || numbers[j] == -1) && j + 1 < numbers.Length)
                    {
                        j++;
                    }
                    numbers[i] = numbers[j];
                    numbers[j] = -1;
                }
            }
            return ansCount;
        }
    }
}
