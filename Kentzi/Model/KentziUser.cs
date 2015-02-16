using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{
    public class KentziUser
    {

        private String mobileNumber;
        private String email;
        private String firstName;
        private String lastName;

        public KentziUser(String mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }

        public String MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

    }
}