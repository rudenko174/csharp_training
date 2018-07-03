using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    public class ContactInfoData
    {
        //General data
        private string firstname;
        private string middlename = "";
        private string lastname = "";
        private string nickname = "";
        private string title = "";
        private string company = "";
        private string address = "";

        //Telefon data
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string fax = "";

        //Mail data
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";

        //BirthDay And Anniversary data
        private string birthday = "-";
        private string birthmonth = "-";
        private string birthyear = "";
        private string anniversaryday = "-";
        private string anniversarymonth = "-";
        private string anniversaryyear = "";

        //Secondary info data
        public string secondaryaddress = "";
        public string phone = "";
        public string notes = "";


        public ContactInfoData(string firstname)
        {
            this.firstname = firstname;
        }


        //General data
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Middlename
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
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

        //Telefon data
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

        //Mail data
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

        //BirthDay And Anniversary data
        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public string Birthmonth
        {
            get
            {
                return birthmonth;
            }
            set
            {
                birthmonth = value;
            }
        }

        public string Birthyear
        {
            get
            {
                return birthyear;
            }
            set
            {
                birthyear = value;
            }
        }

        public string Anniversaryday
        {
            get
            {
                return anniversaryday;
            }
            set
            {
                anniversaryday = value;
            }
        }

        public string Anniversarymonth
        {
            get
            {
                return anniversarymonth;
            }
            set
            {
                anniversarymonth = value;
            }
        }

        public string Anniversaryyear
        {
            get
            {
                return anniversaryyear;
            }
            set
            {
                anniversaryyear = value;
            }
        }

        //Secondary info date
        public string SecondaryAddress
        {
            get
            {
                return secondaryaddress;
            }
            set
            {
                secondaryaddress = value;
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
