using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class SecondaryInfoData
    {
        public string address = "";
        public string phone = "";
        public string notes = "";

        public SecondaryInfoData()
        { }

        public SecondaryInfoData(string address, string phone, string notes)
        {
            this.address = address;
            this.phone = phone;
            this.notes = notes;
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

    }
}
