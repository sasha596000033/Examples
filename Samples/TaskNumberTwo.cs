namespace Samples
{
    public static class TaskNumberTwo
    {
        public static int MinSplit(int amount) 
        {
            int x = amount / 50;
            int y = amount % 50;
            if(y % 50 == 0)
            {
                return x; 
            }
    
            int x2 = y / 20;
            int y2 = y % 20;
            if(y2 % 20 == 0)
            {
                return x + x2;
            }
    
            int x3 = y2 / 10;
            int y3 = y2 % 10;
            if(y3 % 10 == 0)
            {
                return x + x2 + x3;
            }
            int x4 = y3 / 5;
            int y4 = y3 % 5;
            if(y4 % 5 == 0)
            {
                return x + x2 + x3 + x4;
            }
    
            int x5 = y4 / 1;
            return x + x2 + x3 + x4 + x5;
        }
    }
}