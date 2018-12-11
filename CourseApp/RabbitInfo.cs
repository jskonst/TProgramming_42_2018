using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class InfoRabbit
    {
        public void RabbitInfo(string Name, string Pearent1,string Pearent2, List<string> Child) 
        {
            Console.Write($"Кролик {Name}, Родители: {Pearent1} и {Pearent2}, Дети: ");
            foreach(var i in Child)
            {
                Console.WriteLine($"{i} ");
            }
        }
        public void RabbitInfo(string Name, string Pearent1,string Pearent2)
        {
            Console.WriteLine($"Кролик {Name}, Родители: {Pearent1} и {Pearent2},  Детей нет");
        }
        public void RabbitInfo(string Name) 
        {
            Console.WriteLine($"Кролик {Name}, Родители: ??? и ???, Дети нет");
        }  
        public void RabbitInfo(string Name, List<string> Child) 
        {
            Console.Write($"Кролик {Name}, Родители: ??? и ???, Дети: ");
            foreach(var i in Child)
            {
                Console.WriteLine($"{i} ");
            } 
        }
    }
}