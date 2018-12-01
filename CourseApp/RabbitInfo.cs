using System;

namespace CourseApp
{
    public class Rabbit
    {
        public void RabbitInfo(string Name, string[] Pearent, string[] Child)
        {
            Console.Write($"Имя {Name} Родители: {Pearent[1]} и {Pearent[2]} Дети: ");            
            foreach (var i in Child) {Console.WriteLine(Child[Convert.ToInt32(i)]);}
        }
        public void RabbitInfo(string Name, string[] Pearent) {Console.WriteLine($"Имя {Name} Родители: {Pearent[1]} и {Pearent[2]}");}
        public void RabbitInfo(string Name) {Console.WriteLine($"Имя {Name}");}  
        public void RabbitInfo() {Console.WriteLine("eror");}
    }
    
}
