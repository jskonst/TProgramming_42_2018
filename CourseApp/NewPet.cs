using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class NewPet : Pet
    {
        public NewPet(string v)
        {
        this.Vid = v;
        }

        public NewPet(string p1, string p2, string v)
        {
        this.Pearent1 = p1;
        this.Pearent2 = p2;
        this.Vid = v;
        }

        public NewPet(string child, string v)
        {
        this.Child.Add(child);
        this.Vid = v;
        }
    }
}