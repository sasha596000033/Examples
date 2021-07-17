namespace Samples
{
    public static class TaskNumberFive
    {
        public static int FindStep(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                if (n == 2)
                {
                    return 2;
                }
                else
                {
                    return FindStep(n - 2) +
                           FindStep(n - 1);
                }
            }
        }
    }
}