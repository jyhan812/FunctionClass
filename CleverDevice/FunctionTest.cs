using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionClass;
using System.Text;

namespace CleverDevice
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        //reverse the order of words of a sentence using Array
        public void TestReverseByArray()
        {
            var tests = new string[][] {
                new string[]{ "abcdefg" , "gfedcba" },
                new string[]{ "my name is joy." , ".yoj si eman ym" },
                new string[]{ "hello world" , "dlrow olleh" }
            };

            var testReverse = new Reverse();

            foreach (var test in tests)
            {
                Assert.AreEqual(test[1], testReverse.ReverseByArray(test[0]));
            }
        }

        [TestMethod]
        //reverse the order of words of a sentence using LINQ
        public void TestReverseByLINQ()
        {
            var tests = new string[][] {
                new string[]{ "abcdefg" , "gfedcba" },
                new string[]{ "my name is joy." , ".yoj si eman ym" },
                new string[]{ "hello world" , "dlrow olleh" }
            };

            var testReverse = new Reverse();

            foreach (var test in tests)
            {
                Assert.AreEqual(test[1], testReverse.ReverseByLINQ(test[0]));
            }
        }

        [TestMethod]
        //reverse the order of words of a sentence manually
        public void TestReverseManually()
        {
            var tests = new string[][] {
                new string[]{ "abcdefg" , "gfedcba" },
                new string[]{ "my name is joy." , ".yoj si eman ym" },
                new string[]{ "hello world" , "dlrow olleh" }
            };

            var testReverse = new Reverse();

            foreach (var test in tests)
            {
                Assert.AreEqual(test[1], testReverse.ReverseManually(test[0]));
            }
        }

        [TestMethod]
        public void TestStackString()
        {
            //push a, push b, push c, pop, push d, push e, pop, push f
            //will return abdf
            string expectedstring = "abdf";

            Stack<string> stack = new Stack<string>(10);            

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Pop();
            stack.Push("d");
            stack.Push("e");
            stack.Pop();
            stack.Push("f");

            string[] stackedData = stack.GetAllStackDatas();

            StringBuilder sb = new StringBuilder();
            foreach (string str in stackedData)
            {
                sb.Append(str);
            }

            Assert.AreEqual(expectedstring, sb.ToString());

        }

        [TestMethod]
        public void TestStackInt()
        {
            //push 1, push 10, push 100, pop, push 100, push 1000, pop, push 10000
            //will return the sum of integers in stack which is 10101 for this test set
            int expectedSumOfInts = 10101;

            Stack<int> stack = new Stack<int>(10);

            stack.Push(1);
            stack.Push(10);
            stack.Pop();
            stack.Push(100);
            stack.Push(1000);
            stack.Pop();
            stack.Push(10000);

            int[] stackedData = stack.GetAllStackDatas();

            int sumOfInts = 0;
            foreach (int i in stackedData)
            {
                sumOfInts = sumOfInts + i;
            }

            Assert.AreEqual(expectedSumOfInts, sumOfInts);

        }

        [TestMethod]
        //returns the total number of elements in the stack
        public void TestStackSize()
        {
            int expectedsize = 5;

            Stack<string> stack = new Stack<string>(10);

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            stack.Pop();
            stack.Pop();
            stack.Push("e");
            stack.Push("f");
            stack.Push("g");

            Assert.AreEqual(expectedsize, stack.Size());
        }

        [TestMethod]
        //takes two character string args and returns a string contans only the characters 
        //found in both strings in alphabetical order using HashSet
        //this is not case sensitive function and remove duplicates
        //test string input: first string, second string, expected output
        public void TestMatchStringsByHashSet()
        {
            var tests = new string[][] {
                new string[]{ "HelloWorld", "lOve", "elo" },
                new string[]{ "Apple" , "Banana", "a" },
                new string[]{ "MyNameIsJoy" , "WhatIsYourName", "aeimnosy" }
            };

            var testFindMatch = new FindMatch();

            foreach (var test in tests)
            {
                Assert.AreEqual(test[2], testFindMatch.MatchStringsByHashSet(test[0], test[1]));
            }
        }

        [TestMethod]
        //takes two character string args and returns a string contans only the characters 
        //found in both strings in alphabetical order using LINQ
        //this is not case sensitive function and remove duplicates
        //test string input: first string, second string, expected output
        public void TestMatchStringsByLINQ()
        {
            var tests = new string[][] {
                new string[]{ "HelloWorld", "lOve", "elo" },
                new string[]{ "Apple" , "Banana", "a" },
                new string[]{ "MyNameIsJoy" , "WhatIsYourName", "aeimnosy" }
            };

            var testFindMatch = new FindMatch();

            foreach (var test in tests)
            {
                Assert.AreEqual(test[2], testFindMatch.MatchStringsByLINQ(test[0], test[1]));
            }
        }

    }
}
