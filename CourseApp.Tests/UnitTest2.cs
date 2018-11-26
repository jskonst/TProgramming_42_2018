using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            Rabbit krosh = new Rabbit("momo","rad",3);
            var name = krosh.name;
            var color = krosh.color;
            var age = krosh.age;
                
            Assert.Equal("momo",name);
            Assert.Equal("rad",color);
            Assert.Equal(3,age);
        }

        [Fact]
        public void Test2()
        {
            Rabbit krosh = new Rabbit("rar","grin",1);
            var name = krosh.name;
            var color = krosh.color;
            var age = krosh.age;
                
            Assert.Equal("rar",name);
            Assert.Equal("grin",color);
            Assert.Equal(1,age);
        }
        
        [Fact]
        public void Test3()
        {
            Rabbit krosh = new Rabbit("ggwp","blue",9);
            var name = krosh.name;
            var color = krosh.color;
            var age = krosh.age;
                
            Assert.Equal("ggwp",name);
            Assert.Equal("blue",color);
            Assert.Equal(9,age);
       }
        
    }
}