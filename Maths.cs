using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLibrary
{
   public class Maths
    {
        int _fno;
        public int Fno
        {
           private get
            {
                return _fno;
            }
            set
            {
                _fno = value;
            }
        }

        int _sno;
        public int Sno
        {
            private get
            {
                return _sno;
            }
            set
            {
                _sno = value;
            }
        }


        private int _answer;

        public int Answer
        {
            get {

                _answer = Fno + Sno;
                return _answer;
            }
            private set { _answer = value; }
        }






    }
}
