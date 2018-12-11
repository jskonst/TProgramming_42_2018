using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Farm
    {    
        public List<string> Child=new List<string>();
        public string Name{get;set;}
        public string Pearent1 {get;set;}
        public string Pearent2 {get;set;}
        
        public  Farm() {}
        public  Farm(string n) {this.Name=n;}
        public  Farm(string n, string p1,string p2) 
        {
            this.Name=n;
            this.Pearent1=p1;
            this.Pearent2=p2;
        } 
    }
}