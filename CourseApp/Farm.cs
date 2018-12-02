using System;
using System.Collections.Generic;

namespace CourseApp
{
  
    public class Farm
    {    
        public string Name;
        public string Pearent1;
        public string Pearent2;
        public string[] Child;
        public  Farm() {}
        public  Farm(string n) {this.Name=n;}
        public  Farm(string n, string p1,string p2) {this.Name=n;this.Pearent1=p1;this.Pearent2=p1;} 
        public  Farm(string n, string p1,string p2, string[] ch) 
        {
            Name=n;
            Pearent1=p1;
            Pearent2=p2;
             foreach (var i in ch){Child[Convert.ToInt32(i)]=ch[Convert.ToInt32(i)];};
        }

            
    }
}