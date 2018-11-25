using System;

namespace CourseApp
{

    class NewRabbit
    {      
        public void NewRabbitt()
        {
            Rabbit ururu = new Rabbit( InName(), InColor(), InAge()); 
            ururu.RabbitInfo();          
        }

         static string InName ()
         {
             Console.Write("Введите имя: ");
             string Name = Console.ReadLine();
             return Name;
         }

         static int InAge ()
         {
             Console.Write("Введите возраст: ");
             int Age = Convert.ToInt32(Console.ReadLine());
             return Age;
         }

         static string InColor ()
         {
             Console.Write("Введите цвет: ");
             string Color = Console.ReadLine();
             return Color;
         }
         public void art()
        {
            Console.WriteLine(@" 
            ------/)/)-----/),/)----(\__/)----(\.(\-----(\(\
            -----(':'=)----(':'=)---(=';'=)---(=':')----(=':')
            --(')('),,)-(')('),,)---(')_(')---(..(')(')-(..(')(')  ");
        }


    }
}