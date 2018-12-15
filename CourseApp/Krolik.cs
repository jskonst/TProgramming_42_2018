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
   }
}