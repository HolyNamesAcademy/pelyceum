using System;
using System.Collections.Generic;
using System.Text;

namespace Pelyceum
{
    public class College
    {
        public string name;
        public string loc;
        public string mail;
        public string phone;
        public string site;
        //list? majors;
        public int avtuit;
        //list? scholarships
        //list? deadlines
        public Boolean comapp;


        public College(string entname, string location)
        {
            name = entname;
            loc = location;
        }



        IDictionary<string, College> collegeList = new Dictionary<string, College>();
        //majors, scholarships, emails, phones, etc.
        //list of majors - arraylist?
        //create a search function
    }
}
