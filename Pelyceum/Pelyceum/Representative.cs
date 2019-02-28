using System;
using System.Collections.Generic;
using System.Text;

namespace Pelyceum
{
    public class Representative : Profile
    {

        public Representative(string entname, College entcollege)
        {
            name = entname;
            college = entcollege;
        }

        //this goes in view model
        public void RepEdit()
        {
           //skip security for now

            if (collegeList.ContainsKey(Representative.college))
                {
                //allow edits
                }
            else
                {
                    collegeList.makeCollege(Representative.college, int entuit);
                //have them enter tuition
                }

           
            //if (college matches from list)
            //if known, allow editing
            //if not, create

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

    //work sign in function - choose profile???