using static System.Console;

namespace Samples.Test
{
    public class Assert
    {
        public static void AreEqual(string excepted, string actual)
        {
            if (excepted == actual)
            {
                WriteLine(@$"Result: {true}
Excepted: {excepted}
Actual: {actual}  
                ");
            }
            else
            {
                WriteLine(@$"Result: {false}
Excepted: {excepted}
Actual: {actual} 
                ");
            }
        }

        public static void AreEqual(int excepted, int actual)
        {
            AreEqual(excepted.ToString(), actual.ToString());
        }

        public static void AreEqual(bool excepted, bool actual)
        {
            if (excepted == actual)
            {
                WriteLine(@$"Result: {true}
Excepted: {excepted}
Actual: {actual}  
                ");
            }
            else
            {
                WriteLine(@$"Result: {false}
Excepted: {excepted}
Actual: {actual} 
                ");
            }
        }
    }
}