using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.myCalc(2.0, 4.1, 0);
            Assert.Equal(0,res);
        }

        [Fact]
        public void Test2()
        {
            var res = Program.myCalc(0, 0, 0);
            Assert.Equal(0,res);
        }

        [Fact]
        public void Test3()
        {
            var res = Program.myCalc(1, 1, 1);
            Assert.Equal(0,res);
        }
    }
}
