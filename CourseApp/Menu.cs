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
         Info pInfo = new Info();
         switch(go)
         {
         case "Buy":
         Console.WriteLine("Введите кого вы хоите купить: кролик/мышь");
         Vid = Console.ReadLine();
         if (Vid == "кролик")
         {
            krosh.BuyKrolik();
         }

         break;
         case "Sel":
         Console.WriteLine("Введите кого вы хоите разводить: кролик/мышь");
         Vid = Console.ReadLine();
         if (Vid == "кролик")
         {
             krosh.NewKrolik();
         }

         break;
         case "Art":
           Art();
         break;
         case "Inf":
         Console.Write("Введите имя животного о котором хотите унать: ");
         Name = Console.ReadLine();
         foreach(string j in Spisok.Keys)
            {
               foreach(NewPet i in Spisok.Values)
               {
               if(j == Name)
               {
               if (i.Pearent1 == null && i.Child.Count == 0)
               {
                  pInfo.PetInfo(j, i.Vid);
               }
               else if(i.Pearent1 != null && i.Child.Count == 0)
               {
                  pInfo.PetInfo(j, i.Pearent1, i.Pearent2, i.Vid);
               }
               else if(i.Pearent1 == null && i.Child.Count != 0)
               {
                  pInfo.PetInfo(j, i.Child, i.Vid);
               }
               else if(i.Pearent1 != null && i.Child.Count != 0)
               {
                  pInfo.PetInfo(j, i.Pearent1, i.Pearent2, i.Child, i.Vid);
               }
               }
            }
            }

         break;
         case "help":
            Help();
         break;
         case "Info":
            foreach(string i in Spisok.Keys)
            {
               foreach (NewPet j in Spisok.Values)
               {
               Console.WriteLine($"{Kol++}){j.Vid} {i}");
               }
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