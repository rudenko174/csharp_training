using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    public class BirthDayAndAnniversaryData
    {
        private string birthday = "";
        private string birthmonth = "";
        private string birthyear = "";
        private string anniversaryday = "";
        private string anniversarymonth = "";
        private string anniversaryyear = "";


        public BirthDayAndAnniversaryData()
        {
        }

        public BirthDayAndAnniversaryData(string birthday, string birthmonth, string birthyear, string anniversaryday, string anniversarymonth, string anniversaryyear)
        {
            this.birthday = birthday;
            this.birthmonth = birthmonth;
            this.birthyear = birthyear;
            this.anniversaryday = anniversaryday;
            this.anniversarymonth = anniversarymonth;
            this.anniversaryyear = anniversaryyear;
        }

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

   

    }
}
