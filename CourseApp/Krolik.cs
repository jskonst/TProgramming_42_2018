using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
   public class Krolik : Pet
   {
      public void BuyKrolik()
      {
         Console.Write("Введите имя купленного кролика: ");
         Name = Console.ReadLine();
         Spisok.Add(Name, new NewPet(Vid));
      }

      public void NewKrolik()
      {
         Console.Write("Введите имя новорожденного кролика: ");
         Name = Console.ReadLine();
         Console.WriteLine("Введите имена родителй кролика: ");
         Pearent1 = Console.ReadLine();
         Pearent2 = Console.ReadLine();
         Spisok.Add(Name, new NewPet(Pearent1, Pearent2, "кролик"));
         foreach(string i in Spisok.Keys)
         {
            if(Pearent1 == i )
            {
            Spisok.Add(Pearent1, new NewPet(Name));
            }

            if(Pearent2 == i)
            {
            Spisok.Add(Pearent2, new NewPet(Name));
            }
         }
      }
   }
}