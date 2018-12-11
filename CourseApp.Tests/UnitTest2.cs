using System;
using Xunit;
using CourseApp;
using System.Collections.Generic;
using System.Collections;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            var krosh = new InfoRabbit();
            var N ="momo";
            krosh.RabbitInfo(N);
            Assert.Equal("momo",N);
        }
        [Fact]
        public void Test2()
        {
            var krosh = new InfoRabbit();
            var N ="momo";
            var P1 = "mu";
            var P2 = "nu";
            krosh.RabbitInfo(N);
            Assert.Equal("momo",N);
            Assert.Equal("mu",P1);
            Assert.Equal("nu",P2);
        }
        [Fact]
        public void Test3()
        {
            var krosh = new InfoRabbit();
            var N ="momo";
            var P1 = "mu";
            var P2 = "nu";
            List<string> ch=new List<string> {"Mura","Gura","Fedya"}; 
            krosh.RabbitInfo(N,P1,P2,ch);
            Assert.Equal("momo",N);
            Assert.Equal("mu",P1);
            Assert.Equal("nu",P2);
            Assert.Equal("Mura",ch[0]);
            Assert.Equal("Gura",ch[1]);
            Assert.Equal("Fedya",ch[2]);
        }
        [Fact]
        public void Test4()
        {
            Menu ferma = new Menu();
            ferma.Name = "Boo";
            Assert.Equal("Boo",ferma.Name);
        } [Fact]    
        public void Test5()
        {
            Menu ferma = new Menu();
            ferma.klet.Add("Boo");
            Assert.Equal("Boo",ferma.klet[0]);
        }
        public void Test6()
        {
            Menu ferma = new Menu();
            ferma.menu("Stl");
            ferma.Name="Boo";
            ferma.Pearent1="Buu";
            ferma.Pearent2="Buuu";
            Assert.Equal("Boo",ferma.klet[0]);
            Assert.Equal("Buu",ferma.klet[0]);
            Assert.Equal("Buuu",ferma.klet[0]);
        }
    }
}