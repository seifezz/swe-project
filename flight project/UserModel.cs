using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace flight_project
{
    class UserModel
    {

        string connectionString = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        User user;

        public UserModel(User user)
        {
            this.user = user;
            conn = new OracleConnection(connectionString);
            conn.Open();

        }
        public UserModel()
        {
            conn = new OracleConnection(connectionString);
            conn.Open();

        }


        public bool createUser()
        {

            string userBirthDateArr = user.age.Split(' ')[0];

            string userBirthDate = Convert.ToDateTime(userBirthDateArr).ToString("dd-MM-yyyy");

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into userinfo(email, username, phone, nationalid, age, password) values(:email, :username, :phone, :nationalid, TO_DATE(:age, 'DD/MM/YYYY'), :password)";
            cmd.Parameters.Add("email", user.email);
            cmd.Parameters.Add("username", user.name);
            cmd.Parameters.Add("phone", user.phoneNumber);
            cmd.Parameters.Add("nationalid", user.nationalID);
            cmd.Parameters.Add("age", userBirthDate);
            cmd.Parameters.Add("password", user.password);

            int r = -1;
            try
            {
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                return false;
            }

            if (r != -1)
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        public User getUserByEmail(string email)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from userinfo where email = :email";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("email", email);

            OracleDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                return null;
            }

            if (dr.Read())
            {
                user = new User(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                return user;
            }
            else
            {
                user = null;
                return user;
            }

        }

        ~UserModel()
        {
            conn.Dispose();

        }

    }

    class User
    {
        public string name;
        public string email;
        public string phoneNumber;
        public string nationalID;
        public string age;
        public string password;

        public User(string email, string name, string phoneNumber, string nationalID, string age, string password)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.nationalID = nationalID;
            this.age = age;
            this.password = password;
        }
    }
}
