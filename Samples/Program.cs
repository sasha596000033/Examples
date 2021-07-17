using System;
using System.Linq;
using Samples.Test;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //One
            Assert.AreEqual(true, TaskNumberOne.Palindrome("ana"));

            //Two
            Assert.AreEqual(2, TaskNumberTwo.MinSplit(100));
            
            //Three
            int[] arr = {10, 20, 30, 40};
            Assert.AreEqual(1, TaskNumberThree.NotContains(arr));
            
            //Four
            Assert.AreEqual(false, TaskNumberFour.IsProperly("())"));
            
            //Five
            Assert.AreEqual(89, TaskNumberFive.FindStep(10));
        }
    }
}