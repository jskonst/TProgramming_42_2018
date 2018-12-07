using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class Menu:Farm
    {
      public  Rabbit info = new Rabbit();
      public  ArrayList klet= new ArrayList();
      public void menu(string go)
        { 
        switch (go)
        {
          case "help": 
             help();
          break;
          case "Buy": 
             Console.Write("Введите имя купленного кролика: ");
             Name = Console.ReadLine();
             klet.Add(new Farm(Name));
          break;
          case "Sel": 
             Console.Write ("Введите имя новорожденного кролика: ");
             Name = Console.ReadLine();
             Console.WriteLine("Введите имена родителй кролика: ");
             Pearent1=Console.ReadLine();
             Pearent2=Console.ReadLine();
             klet.Add(new Farm(Name,Pearent1,Pearent2));
               foreach(Farm i in klet)
             {                
                if(Pearent1==i.Name||Pearent2==i.Name){i.Child.Add(Name);};
             }
          break;
          case "Art": 
             art();
          break;
          case "Info":  int num=1;
             foreach(Farm i in klet)
             {
             Console.WriteLine($"{num++}) {i.Name}");
             }
          break;   
          case "Inf":
             {  
             Console.Write("Введите имя кролика о котором хотите унать: ");
             Name = Console.ReadLine();
             foreach(Farm i in klet)
             {
               if(i.Name==Name)
               {
               if (i.Pearent1 == null && i.Child.Count == 0)
               {info.RabbitInfo(i.Name);}
               else if(i.Pearent1 != null && i.Child.Count == 0) 
               {info.RabbitInfo(i.Name,i.Pearent1,i.Pearent2);}
               else if(i.Pearent1 == null && i.Child.Count != 0) 
               {info.RabbitInfo(i.Name,i.Child);}
               else if(i.Pearent1 != null && i.Child.Count != 0) 
               {info.RabbitInfo(i.Name,i.Pearent1,i.Pearent2,i.Child);} 
               }
             }
             }
          break;
          default: if(go != "Stop") {  
            Console.WriteLine("Такой команды не существует. help - узнать список команд.");}
          break;
        } 
             Console.WriteLine("----------"); 
        }
       static void help() 
        {
           Console.WriteLine(@"
           Команды:
            Stop - закончить программу;
            Art - вывести рисунок кроликов;
            Buy - купить нового кролика;
            Sel - выростить нового кролика;
            Info - узнать имена всех кроликов
            Inf - узнать о конкретном кролике
            ");
        }
        static void art()
        {
            Console.WriteLine(@" 
            ------/)/)------/),/)----(\__/)---(\.(\-----(\(\
            -----(':'=)----(':'=)---(=';'=)---(=':')----(=':')
            --(')('),,)-(')('),,)---(')_(')---(..(')(')-(..(')(')  ");
        }
    }
}