using System;
using System.Collections.Generic;
using System.Text;

namespace Pelyceum
{
    public class Representative : Profile
    {
        public string college;

        public Representative(string entname, string entcollege)
        {
            name = entname;
            college = entcollege;
        }

        public void RepEdit()
        {
           //skip security for now

            if (collegeList.ContainsKey(Representative.name))
                {
                //allow edits
                }
            else
                {
                //create

                //collegeList.add(
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