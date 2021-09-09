using System;
using System.IO;

namespace FileHandlingLib
{
    public class UserFileCreation
    {
        public bool Create(string path)
        {
            bool status = false;
            FileStream fs=File.Create(path);
            if (fs!=null)
            {
                status = true;
            }
            return status;


        }



    }
}
