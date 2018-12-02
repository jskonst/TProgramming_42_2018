using System;

namespace CourseApp
{
    public class Farm
    {    
        public string Name;
        public string Pearent1;
        public string Pearent2;
        public int Child;
        public  Farm() {}
        public  Farm(string n) {this.Name=n;}
        public  Farm(string n, string p1,string p2) {this.Name=n;this.Pearent1=p1;this.Pearent2=p2;} 
        public  Farm(string n, string p1,string p2, int ch) 
        {
            this.Name=n;
            this.Pearent1=p1;
            this.Pearent2=p2;
            this.Child=ch;
        }
    }
}