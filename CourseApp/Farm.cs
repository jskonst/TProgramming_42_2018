using System;
using System.Collections.Generic;

namespace CourseApp
{
  
    public class Farm
    {    
        public string Name;
        public string[] Pearent=new string[2];
        public string[] Child;
        public  Farm() {}
        public  Farm(string n) {Name=n;}
        public  Farm(string n, string[] p) {Name=n;Pearent[1]=p[1];Pearent[2]=p[2];}
        public  Farm(string n, string[] p, string[] ch) 
        {
            Name=n;Pearent[1]=p[1];
            Pearent[2]=p[2];
             foreach (var i in ch){Child[Convert.ToInt32(i)]=ch[Convert.ToInt32(i)];};
        }

            
    }
}