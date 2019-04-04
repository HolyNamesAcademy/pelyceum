using System;
using System.Collections.Generic;
using System.Text;

namespace Pelyceum
{
    public class Representative : Profile
    {
        public string college;
        public College emp;

        public Representative(string entname, string entcollege)
        {
            name = entname;
            college = entcollege;
            emp = null;
        }

        public void RepIntro()
        {
            //skip security for now

            //emp = College.search(name);
                if (emp == null)
            {
                //(make college);
            }
            
            //if (college matches from list)
            //contact admin for permissions
            //if given, continue, if not kick back to start
        }

        public void RepEdit()
        {
            //if it exists, edit
            //if not, facilitate creation
            
            //print their college info
            //Name: ble, Email: ble, phone: ble, etc.
            //give them editing rights - name area (name, email, phone, etc.)
        }
        //verification w/ admins
        //if college unrecognized, check spelling & completeness or contact admins
        //give creation ability
    }
}
//StringReader strReader = new StringReader(textReaderText)
//how to differentiate between users - booleans? strings?