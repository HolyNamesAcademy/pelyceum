﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pelyceum
{
    class College
    {
        public string name;
        //public string loc;
        //public string mail;
        //public string phone;
        //public string site;
        //list? majors;
        public int avtuit;
        //list? scholarships
        //list? deadlines
        //public Boolean comapp;


        public College(string entname, int entuit)
        {
            name = entname;
            avtuit = entuit;
        }

        public void makeCollege(string entname, int entuit)
        {
            College newCollege = new College(entname, entuit);
            collegeList.Add(entname, newCollege);
        }

        public void switchTuit(string college, int newtuit)
        {
            collegeList[college].avtuit = newtuit;
        }

        public string showCollege(string key)
        {
            //print college[key].name
            //print college[key].avtuit
        }

        
        
        //editing methods
        //search function
        //match function


        IDictionary<string, College> collegeList = new Dictionary<string, College>();
        //majors, scholarships, emails, phones, etc.
        //list of majors - arraylist?
        //create a search function
    }
}
