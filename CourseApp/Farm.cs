using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Farm
    {    
        public string Name;
        public string Pearent1;
        public string Pearent2;
        public List<string> Child=new List<string>();
        public  Farm() {}
        public  Farm(string n) {this.Name=n;}
        public  Farm(string n, string p1,string p2) {this.Name=n;this.Pearent1=p1;this.Pearent2=p2;} 
    }
}