using System;

namespace CourseApp
{
    class Fox
    {
        public string Name { get; set; }
        private int age;
        public string Color { get; set; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }

            }
        }

        public Fox() { Name = ""; Color = "Рыжий"; age = 3; } // 1 конструктор

        public Fox(string n, string m) { Name = n; Color = m; age = 2; } // 2 конструктор

        public Fox(string n, string m, int a) { Name = n; Color = m; age = a; } // 3 конструктор

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name} Цвет: {Color} Возраст: {age}");
        }

        public void Mut()
        {
            Console.WriteLine($"Из-за странного корма все лисы мутировали, покорили мир и сделали людей своими рабами");
        }
        public void fox()
        {
            Console.WriteLine(@"   
                                                                   ,-,
                                                             _.-=;~ /_
                                                          _-~   '     ;.
                                                      _.-~     '   .-~-~`-._
                                                _.--~~:.             --.____88
                              ____.........--~~~. .' .  .        _..-------~~
                     _..--~~~~               .' .'             ,'
                 _.-~                        .       .     ` ,'
               .'                                    :.    ./
             .:     ,/          `                   ::.   ,'
           .:'     ,(            ;.                ::. ,-'
          .'     ./'.`.     . . /:::._______.... _/:.o/
         /     ./'. . .)  . _.,'               `88;?88|
       ,'  . .,/'._,-~ /_.o8P'                  88P ?8b
    _,'' . .,/',-~    d888P'                    88'  88|
 _.'~  . .,:oP'        ?88b              _..--- 88.--'8b.--..__
:     ...' 88o __,------.88o ...__..._.=~- .    `~~   `~~      ~-._ Seal _.
`.;;;:='    ~~            ~~~                ~-    -       -   -");
        }
    }
}