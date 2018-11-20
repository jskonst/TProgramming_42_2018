using Xunit;
using System;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            Fox one = new Fox();
            var name = one.Name;
            var age = one.Age;
            var color = one.Color;
            Assert.Equal("Первая", name);
            Assert.Equal(3, age);
            Assert.Equal("Рыжая", color);
        }
        [Fact]
        public void Test2()
        {
            Fox two = new Fox("Вторая","Чёрная");
            var name = two.Name;
            var age = two.Age;
            var color = two.Color;
            Assert.Equal("Вторая", name);
            Assert.Equal(3, age);
            Assert.Equal("Чёрная", color);
        }
        [Fact]
        public void Test3()
        {
            Fox three = new Fox("Третья", "Белая",3);
            var name = three.Name;
            var age = three.Age;
            var color = three.Color;
            Assert.Equal("Третья", name);
            Assert.Equal(3, age);
            Assert.Equal("Белая", color);
        }
    }
}
