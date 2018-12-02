using System;

namespace CourseApp
{
    public class Rabbit
    {
        public void RabbitInfo(string Name, string Pearent1,string Pearent2, string[] Child)
        {
            Console.Write($"Имя {Name} Родители: {Pearent1} и {Pearent2} Дети: ");            
            foreach (var i in Child) {Console.WriteLine(Child[Convert.ToInt32(i)]);}
        }
        public void RabbitInfo(string Name, string Pearent1,string Pearent2) {Console.WriteLine($"Имя {Name} Родители: {Pearent1} и {Pearent2}");}
        public void RabbitInfo(string Name) {Console.WriteLine($"Имя {Name}");}  
        public void RabbitInfo() {Console.WriteLine("eror");}
    }
    
}
