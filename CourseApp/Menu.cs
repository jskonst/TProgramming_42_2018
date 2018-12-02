using System;
using System.Collections;

namespace CourseApp
{
    public class Menu
    {
      public void menu()
        { 
        var info = new Rabbit();
        string go;
        string Name;
        string Pearent1;
        string Pearent2;
        ArrayList klet= new ArrayList();

        Console.WriteLine ("Добро пожаловать на кроличью ферму!");
        do {
        go = Console.ReadLine();
        switch (go)
        {
          case "help": 
             help();
             Console.WriteLine("----------");
          break;
          case "Buy": 
             Console.Write("Введите имя купленного кролика: ");
             Name = Console.ReadLine();
             klet.Add(new Farm(Name));
             Console.WriteLine("----------");
          break;
          case "Select": 
             Console.Write ("Введите имя новорожденного кролика: ");
             Name = Console.ReadLine();
             Console.WriteLine("Введите имена родителй кролика: ");
             Pearent1=Console.ReadLine();
             Pearent2=Console.ReadLine();
             klet.Add(new Farm(Name,Pearent1,Pearent2));
               foreach(Farm i in klet)
             {                
                if(Pearent1==i.Name||Pearent2==i.Name){i.Child=i.Child+1;};
                
             }
             Console.WriteLine("----------");
          break;
          case "Art": 
             art();
             Console.WriteLine("----------");
          break;
          case "Info":  int num=1;
             foreach(Farm i in klet)
             {
                Console.Write($"{num++})");
                if (i.Pearent1 == null && i.Child == 0)
                {info.RabbitInfo(i.Name);}
                else if(i.Pearent1 != null && i.Child == 0) 
                {info.RabbitInfo(i.Name,i.Pearent1,i.Pearent2);}
                else if(i.Pearent1 == null && i.Child != 0) 
                {info.RabbitInfo(i.Name,i.Child);}
                else if(i.Pearent1 != null && i.Child != 0) 
                {info.RabbitInfo(i.Name,i.Pearent1,i.Pearent2,i.Child);}
             }
             Console.WriteLine("----------");
          break;
          default: if(go != "Stop") {  
            Console.WriteLine("Такой команды не существует. help - узнать список команд.");}
          break;
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