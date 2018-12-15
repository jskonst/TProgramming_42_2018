using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
   public class Krolik : Zoo
   {
      public void BuyKrolik()
      {
         Console.Write("Введите имя купленного кролика: ");
         Name = Console.ReadLine();
         Klet.Add(new NewPet(Name));
      }

      public void NewKrolik()
      {
         Console.Write("Введите имя новорожденного кролика: ");
         Name = Console.ReadLine();
         Console.WriteLine("Введите имена родителй кролика: ");
         Pearent1 = Console.ReadLine();
         Pearent2 = Console.ReadLine();
         Klet.Add(new NewPet(Name, Pearent1, Pearent2));
         foreach(NewPet i in Klet)
         {
            if(Pearent1 == i.Name || Pearent2 == i.Name)
            {
            i.Child.Add(Name);
            }
         }
      }

      public void RebbitInfo()
      {
         Console.Write("Введите имя кролика о котором хотите унать: ");
         Name = Console.ReadLine();
         foreach(NewPet i in Klet)
            {
               if(i.Name == Name)
               {
               if (i.Pearent1 == null && i.Child.Count == 0)
               {
                  PInfo.PetInfo(i.Name);
               }
               else if(i.Pearent1 != null && i.Child.Count == 0)
               {
                  PInfo.PetInfo(i.Name, i.Pearent1, i.Pearent2);
               }
               else if(i.Pearent1 == null && i.Child.Count != 0)
               {
                  PInfo.PetInfo(i.Name, i.Child);
               }
               else if(i.Pearent1 != null && i.Child.Count != 0)
               {
                  PInfo.PetInfo(i.Name, i.Pearent1, i.Pearent2, i.Child);
               }
               }
            }
      }
   }
}