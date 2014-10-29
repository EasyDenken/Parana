using System;
using System.Collections.Generic;
using System.Text;

namespace RioParanaOBJ
{
    public class EMails
    {
        private string email1;
        private string email2;
        private string email3;
        private string email4;

        public EMails()
        {

        }
        public EMails(string _email1)
        {
            email1 = _email1;
        }
        public EMails(string _email1, string _email2)
        {
            email1 = _email1;
            email2 = _email2;
        }
        public EMails(string _email1, string _email2, string _email3)
        {
            email1 = _email1;
            email2 = _email2;
            email3 = _email3;
        }

        public EMails(string _email1, string _email2, string _email3, string _email4)
        {
            email1 = _email1;
            email2 = _email2;
            email3 = _email3;
            email4 = _email4;
        }

        public string EMail1
        {
            get { return email1; }
            set { email1 = value; }
        }

        public string EMail2
        {
            get { return email2; }
            set { email2 = value; }
        }

        public string EMail3
        {
            get { return email3; }
            set { email3 = value; }
        }

        public string EMail4
        {
            get { return email4; }
            set { email4 = value; }
        }
    }
}
