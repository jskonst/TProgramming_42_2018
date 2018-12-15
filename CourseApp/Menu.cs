using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
   public class Menu : Zoo
    {
    public void MenuZoo(string go)
      {
         switch (go)
         {
         case "Buy":

         break;
         case "Sel":

         break;
         case "Art":
           Art();
         break;
         case "Inf":

         break;
         case "help":
            Help();
         break;
         case "Info": int num = 1;
            foreach(NewPet i in Klet)
            {
            Console.WriteLine($"{num++}) {i.Name}");
            }

         break;
         default: if(go != "Stop")
            {
            Console.WriteLine("Такой команды не существует. help - узнать список команд.");
            }

         break;
         }

         Console.WriteLine("----------");
      }

    private static void Help()
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

    private static void Art()
        {
            Console.WriteLine(@" 
            ------/)/)------/),/)----(\__/)---(\.(\-----(\(\
            -----(':'=)----(':'=)---(=';'=)---(=':')----(=':')
            --(')('),,)-(')('),,)---(')_(')---(..(')(')-(..(')(')  ");
        }
    }
}