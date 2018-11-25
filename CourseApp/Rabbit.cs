using System;

namespace CourseApp
{
    public class Rabbit
    {
        
        public string name;
        public string color;
        public int age;

        public Rabbit(string n,string c, int ag)
        {           
           name = n;
           color = c;
           age = ag;
        }
        

        public void RabbitInfo()
        {        
            Console.WriteLine($"Имя: {name} Цвет: {color}  Возраст: {age}");
        } 
    }
    
}
