using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void Test13()
        {
            Animals[] animal = new Animals[2];
            animal[0] = new Fox();
            animal[1] = new Wolf();
            foreach (Animals i in animal)
            {
                Assert.Equal("Неизвестное", i.Name);
                Assert.Equal(2, i.Age);
                Assert.Equal("Прозрачный", i.Color);

            }
        }
    }
}