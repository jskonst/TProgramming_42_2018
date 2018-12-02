using System;

namespace CourseApp
{
    public class Rabbit
    {
        public void RabbitInfo(string Name, string Pearent1,string Pearent2, int Child) {Console.Write($"Кролик {Name}, Родители: {Pearent1} и {Pearent2}, Детей: {Child}");}
        public void RabbitInfo(string Name, string Pearent1,string Pearent2) {Console.WriteLine($"Кролик {Name}, Родители: {Pearent1} и {Pearent2},  Детей нет");}
        public void RabbitInfo(string Name) {Console.WriteLine($"Кролик {Name}, Родители: ??? и ???, Детей нет");}  
        public void RabbitInfo(string Name, int Child) {Console.WriteLine($"Кролик {Name}, Родители: ??? и ???, Детей: {Child}");}
    }
}