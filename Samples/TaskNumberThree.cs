using System.Linq;

namespace Samples
{
    public static class TaskNumberThree
    {
        public static int NotContains(int[] array)
        {
            int i = 0;
            foreach (var item in array)
            {
                i++;
                if (!array.Contains(i))
                {
                    break;
                }
            }

            if (array.Last() == i)
            {
                i++;
            }

            return i;
        }
    }
}