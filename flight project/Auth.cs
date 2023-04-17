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

        //OracleConnection conn;
        //string connectionString = "Data source=orcl;User Id=scott;Password=tiger;";

        public Auth()
        {
            //conn = new OracleConnection(connectionString);
            //conn.Open();
        }

        public bool LogIn(string email, string pass)
        {

            bool isLoged = false;

            UserModel userModel = new UserModel();
            User myUser = userModel.getUserByEmail(email);


            if (myUser != null)
            {
                if (myUser.password == pass)
                {
                    isLoged = true;

                }
            }

            return isLoged;

        }
    
        public int SignUp(User user) {

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

            UserModel userModel = new UserModel(user);
            bool creationStatue = userModel.createUser();

            if(creationStatue)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }
    
    }

    
}
