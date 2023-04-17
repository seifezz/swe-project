using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;


namespace flight_project
{
    class Validator
    {
        public static bool validateEmail(string email)
        {

            if(email.Length > 6)
            {
                if (email.Contains("@"))
                {
                    int atPos = email.IndexOf("@");
                    if (atPos > 1 && email.Length - 1 - atPos >= 4)
                    {
                        if(email.Contains("."))
                        {
                            int dotPos = email.IndexOf(".");
                            if(dotPos - atPos > 1)
                            {
                                if(email.Length - 1 - dotPos >= 2)
                                {
                                    return true;

                                }
                            }
                        }
                    }
                }
            }


            return false;
        }

        public static bool validatePassowrd(string password)
        {

            if(password.Length >= 8)
            {

                Regex hasUpperCase = new Regex(@"[A-Z]+");
                Regex hasLowerCase = new Regex(@"[a-z]+");
                Regex hasNumber = new Regex(@"[0-9]+");

                if(hasLowerCase.IsMatch(password) && hasUpperCase.IsMatch(password) && hasNumber.IsMatch(password))
                {
                    return true;
                }


            }

            return false;
        }

        public static bool notEmpty(string[] values)
        {

            foreach(string value in values)
            {
                if(value.Length == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
