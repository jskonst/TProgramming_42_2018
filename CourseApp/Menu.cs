using System;
using System.Collections;

namespace CourseApp
{
    public class Menu
    {
        public void menu()
        { //int j=0;
        var info = new Rabbit();
       // var farm = new Farm();
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
          break;
          case "Buy":
          Console.Write("Введите имя купленного кролика: ");
          Name = Console.ReadLine();
          klet.Add(new Farm(Name));
          break;
          case "Select":
          Console.Write ("Введите имя новорожденного кролика: ");
          Name = Console.ReadLine();
          Console.WriteLine("Введите имена родителй кролика: ");
          Pearent1=Console.ReadLine();
          Pearent2=Console.ReadLine();
          klet.Add(new Farm(Name,Pearent1,Pearent2));
          break;
          case "Art":
          art();
          break;
          case "Info":
          foreach(Farm i in klet)
            {
                if (i.Pearent1 != null)
                {info.RabbitInfo(i.Name,i.Pearent1,i.Pearent2);}
                else {info.RabbitInfo(i.Name);}
            }
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

