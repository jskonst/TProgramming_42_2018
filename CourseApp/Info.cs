using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Info
    {
    public void PetInfo(string name, string pearent1, string pearent2, List<string> child)
        {
            Console.Write($"Кролик {name}, Родители: {pearent1} и {pearent2}, Дети: ");
            foreach(var i in child)
            {
                Console.WriteLine($"{i} ");
            }
        }

    public void PetInfo(string name, string pearent1, string pearent2)
        {
        Console.WriteLine($"Кролик {name}, Родители: {pearent1} и {pearent2},  Детей нет");
        }

    public void PetInfo(string name)
        {
        Console.WriteLine($"Кролик {name}, Родители: ??? и ???, Дети нет");
        }

    public void PetInfo(string name, List<string> child)
        {
        Console.Write($"Кролик {name}, Родители: ??? и ???, Дети: ");
        foreach(var i in child)
            {
            Console.WriteLine($"{i} ");
            }
        }
    }
}