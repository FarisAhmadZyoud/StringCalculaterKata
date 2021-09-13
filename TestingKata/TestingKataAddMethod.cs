using TestingOfAddMethod;
using System;
using Xunit;

namespace TestingKata
{
    public class TestingKataAddMethod
    {
        private readonly Katatest _Kata; 

        public TestingKataAddMethod()
        {
            _Kata = new Katatest(); 


        }
        [Fact]
        public void CheckreturnedValue()
        {

           var res1=  _Kata.add("");

            Assert.Equal(0, res1); 



        }
        [Fact]
        public void CheckreturnedValueoftownumbers()
        {

         
            var res2 = _Kata.add("1,3");

            Assert.Equal(4, res2);
        }
        [Fact]
        public void CheckreturnedValueofonenumber()
        {

        
            var res3 = _Kata.add("1");

            Assert.Equal(1, res3);
        }

        [Fact]
        public void CheckaddingAlotofNumber()
        {

        
            var res4 = _Kata.add("3,7,4,6,5,5");

            Assert.Equal(30, res4);

        }

        [Fact]
        public void CheckNewLineinestring()
        {

            var res4 = _Kata.add("1\n,4,5");

            Assert.Equal(10, res4);

        }
        [Fact]
        public void CheckDiffrentdeilemeter()
        {

            var res5 = _Kata.add("1\n;4;5;9,7");

            Assert.Equal(26, res5);

        }
        [Fact]
        public void CheckNegativenumberAdding()
        {

            var res6= _Kata.add("-1,-5");

            Assert.Equal(-4, res6);

        }



        [Fact]
        public void IgnoreBigNumbers()
        {

            var res4 = _Kata.add("3,7,4,6,5,5,2,8,10,1000,450");

            Assert.Equal(500, res4);

        }

    }
}
