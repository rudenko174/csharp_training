using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class MailData
    {
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";

        public MailData()
        {
        }

        public MailData(string email, string email2, string email3, string homepage)
        {
            this.email = email;
            this.email2 = email2;
            this.email3 = email3;
            this.homepage = homepage;
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }
        }

        public string Email3
        {
            get
            {
                return email3;
            }
            set
            {
                email3 = value;
            }
        }

        public string Homepage
        {
            get
            {
                return homepage;
            }
            set
            {
                homepage = value;
            }
        }
    }

}
