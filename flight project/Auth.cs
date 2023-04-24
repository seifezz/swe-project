using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace flight_project
{
    class Auth
    {

        readonly string SALT = "test-salt-for-hashing-password";


        public Auth()
        {

        }

        public bool LogIn(string email, string pass)
        {

            bool isLoged = false;

            UserModel userModel = new UserModel();
            User myUser = userModel.getUserByEmail(email);

            string hashedPass = HashPassword(pass, SALT);

            if (myUser != null)
            {
                if (myUser.password == hashedPass)
                {
                    isLoged = true;

                }
            }

            return isLoged;

        }

        public int SignUp(User user)
        {

            bool validEmail = Validator.validateEmail(user.email);
            bool validPassword = Validator.validatePassowrd(user.password);

            string[] values = { user.name, user.email, user.password, user.age, user.name, user.phoneNumber };
            bool notEmpty = Validator.notEmpty(values);





            if (!validEmail)
            {
                return 1;
            }
            if (!validPassword)
            {
                return 2;
            }
            if (!notEmpty)
            {
                return 3;
            }

            DateTime userBirhtDate = Convert.ToDateTime(user.age);
            TimeSpan userAge = DateTime.Now.Subtract(userBirhtDate);

            if (userAge.TotalDays / 365 < 18)
            {
                return 4;
            }

            string hashedPassword = HashPassword(user.password, SALT);
            user.password = hashedPassword;

            UserModel userModel = new UserModel(user);
            bool creationStatue = userModel.createUser();

            if (creationStatue)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }

        private string HashPassword(string password, string salt)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(password + salt);
            System.Security.Cryptography.SHA256Managed SHA256 = new System.Security.Cryptography.SHA256Managed();
            byte[] hashed = SHA256.ComputeHash(buffer);

            string hashedString = Convert.ToBase64String(hashed);

            return hashedString;

        }

    }


}
