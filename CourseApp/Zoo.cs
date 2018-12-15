using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class Zoo
    {
        public Info PInfo = new Info();
        public ArrayList Klet = new ArrayList();
        public List<string> Child = new List<string>();

        public string Name {get; set; }

        public string Pearent1 {get; set; }

        public string Pearent2 {get; set; }
    }
}