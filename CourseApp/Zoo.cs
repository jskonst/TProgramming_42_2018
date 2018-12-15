using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class Zoo
    {
        public ArrayList Klet = new ArrayList();
        public List<string> Child = new List<string>();

        public string Vid {get; set; }

        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                foreach(NewPet i in Klet)
                {
                    if(i.Name == Name)
                    {
                        Console.Write("Такое имя уже существует, введите другое имя:");
                        Name = Console.ReadLine();
                    }
                }
            }
        }

        public string Pearent1 {get; set; }

        public string Pearent2 {get; set; }
    }
}