using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Info
    {
    public void PetInfo(string name, string pearent1, string pearent2, List<string> child, string vid)
        {
            Console.Write($"{vid} {name}, Родители: {pearent1} и {pearent2}, Дети: ");
            foreach(var i in child)
            {
                Console.WriteLine($"{i} ");
            }
        }

    public void PetInfo(string name, string pearent1, string pearent2, string vid)
        {
        Console.WriteLine($"{vid} {name}, Родители: {pearent1} и {pearent2},  Детей нет");
        }

    public void PetInfo(string name, string vid)
        {
        Console.WriteLine($"{vid} {name}, Родители: ??? и ???, Дети нет");
        }

    public void PetInfo(string name, List<string> child, string vid)
        {
        Console.Write($"{vid} {name}, Родители: ??? и ???, Дети: ");
        foreach(var i in child)
            {
            Console.WriteLine($"{i} ");
            }
        }
    }
}