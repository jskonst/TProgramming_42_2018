using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class NewPet : Zoo
    {
        public NewPet(string n)
        {
        this.Name = n;
        }

        public NewPet(string n, string p1, string p2)
        {
        this.Name = n;
        this.Pearent1 = p1;
        this.Pearent2 = p2;
        }
    }
}