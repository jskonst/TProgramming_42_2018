using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
   public class Menu : Pet
    {
      public void MenuPets(string go)
      {
         Krolik krosh = new Krolik();
         Cavy cavy = new Cavy();
         switch(go)
         {
         case "Buy":
         Console.WriteLine("Введите кого вы хоите купить: rabbit/cavy");
         Vid = Console.ReadLine();
         if (Vid == "rabbit")
         {
            krosh.BuyPet();
         }
         else if (Vid == "Cavy")
         {
            cavy.BuyPet();
         }

         break;
         case "Sel":
         Console.WriteLine("Введите кого вы хоите разводить: rabbit/cavy");
         Vid = Console.ReadLine();
         if (Vid == "rabbit")
         {
            krosh.NewPet();
         }
         else if (Vid == "Cavy")
         {
            cavy.NewPet();
         }

         break;
         case "Art":
           Art();
         break;
         case "Inf":
      {
      {
         Console.Write("Введите имя животного о котором хотите унать: ");
         Name = Console.ReadLine();
         NewPet rrr = Spisok[Name];
         PetInfo(rrr, Name);
      }
      }

         break;
         case "help":
            Help();
         break;
         case "Info": int kol = 1;
            foreach(KeyValuePair<string, NewPet> i in Spisok)
            {
               Console.WriteLine(kol++ + ") " + i.Value.Vid + " " + i.Key);
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

      private void PetInfo(NewPet i, string name)
        {
            Console.Write($"{i.Vid}) {name}");
            if (i.Pearent1 != null || i.Pearent2 != null)
            {
               Console.Write($", Родители: {i.Pearent1} и {i.Pearent2}");
            }

            if (Child != null)
            {
               Console.Write($", Дети: ");
               foreach(var j in Child)
               {
                Console.WriteLine($"{j} ");
               }
            }
        }
    }
}