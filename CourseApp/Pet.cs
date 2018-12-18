using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public abstract class Pet
    {
        private Dictionary<string, NewPet> spisok = new Dictionary<string, NewPet>();

        private List<string> child = new List<string>();

        public Dictionary<string, NewPet> Spisok { get => spisok; set => spisok = value; }

        public List<string> Child { get => child; set => child = value; }

        public string Vid {get; set; }

        public string Name {get; set; }

        public string Pearent1 {get; set; }

        public string Pearent2 {get; set; }

        public int Kol {get; set; }
    }
}