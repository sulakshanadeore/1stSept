using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLibrary
{
 public   class User
    {


        private string _userid;

        public string UserID
        {
            get
            {
                return _userid;
            }
            set {
                _userid = value;
            }
        }

        //Auto--automatic implemented property
        public string Password { get; set; }



        //if property only has a get or a private set along with a public get then
        // it is called as read only property, the value cannot be set for such a property
        //only allowing user to read the value of the Security question property
        private string _ques= "Enter your fav color";
        public string SecurityQuestion {
            get { return _ques; }

            
        }

        //user to enter a value for the answer but not telling him the
        //security answer so no get is written, it is a write only property
        public string SecurityAnswer
        {
            
            set
            {
                if (value=="Red")
                {
                    Console.WriteLine("Your password was abc@123");
                }
                else
                {
                    Console.WriteLine("pls check your security answer once again");
                }
            }
        }

        public bool ValidateUser()
        {
            bool status = false;
            if (UserID=="abc" && Password=="abc@123")
            {
                status = true;
            }
            return status;

        }

    }
}
