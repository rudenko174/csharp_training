using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class TelephoneData
    {
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string fax = "";

        public TelephoneData()
        {}

        public TelephoneData(string home, string mobile, string work, string fax)
        {
            this.home = home;
            this.mobile = mobile;
            this.work = work;
            this.fax = fax;
        }

        public string Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }

        public string Work
        {
            get
            {
                return work;
            }
            set
            {
                work = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }        
    }
}