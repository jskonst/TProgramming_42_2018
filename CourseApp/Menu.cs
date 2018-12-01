using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseApp
{
    public class Menu
    {
        public void menu()
        { 
        var info = new Rabbit();
       // var farm = new Farm();
       List<Farm> farm= new List<Farm>();
        string go;
        Console.WriteLine ("Добро пожаловать на кроличью ферму!");
        do {
        go = Console.ReadLine();
        switch (go)
          {
          case "help":
            help();
          break;
          case "Buy":
          Console.WriteLine ("Введите имя нового кролика");
          string Name = Console.ReadLine();
          farm.Add(new Farm(Name));
          break;
          case "Select":
          // Скоро будет
          break;
          case "Art":
          art();
          break;
          case "Info":  
          foreach (var i in farm)
            {
                info.RabbitInfo(i.Name);
            }
          break;
          default:
            Console.WriteLine("Такой команды не существует. help - узнать список команд.");
          break; // Поправить вывод при стопе проги
          }} 
          while (go != "Stop");      
        }

       static void help() 
        {
           Console.WriteLine(@"
           Команды:
            Stop - закончить программу;
            Art - вывести рисунок кроликов;
            Buy - купить нового кролика;
            Select - выростить нового кролика;
            Info - узнать ситуацию по кроликам
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

