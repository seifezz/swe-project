using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace flight_project
{
    class UserModel
    {

        string connectionString = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        User user;
        cards card;

        public UserModel(User user)
        {
            this.user = user;
            conn = new OracleConnection(connectionString);
            conn.Open();

        }
        public UserModel(cards card)
        {
            this.card = card;
            conn = new OracleConnection(connectionString);
            conn.Open();
        }
        public UserModel()
        {
            conn = new OracleConnection(connectionString);
            conn.Open();

        }

        public struct dataToBeUpdated
        {
            //card info 
            public struct cardInfo
            {
                public int cardId;
                public int passNum;
                public string clientName;
                public string expiredate;
            };
            //user info
            public string name;
            public string email;
            public string phoneNumber;
            public string age;
            public string password;



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
            catch (Exception)
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
            catch (Exception)
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
        //done
        public bool updateCardNumberInUserInfo(int cardId, string email)
        {

            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE userinfo  SET cardnumber = :cardnumber WHERE email=:email";
            command.Parameters.Add("cardnumber", cardId);
            command.Parameters.Add("email", email);

            int r = -1;

            try
            {
                r = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw (err);
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
        //done
        public bool createCardInfo(cards card, string email)
        {

            if (updateCardNumberInUserInfo(card.cardId, email))
            {
                string expiredatearr = card.expirydate.Split(' ')[0];

                string expiredate = Convert.ToDateTime(expiredatearr).ToString("dd-MM-yyyy");

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //(SELECT cardnumber FROM userinfo WHERE email = :email)
                cmd.CommandText = "INSERT INTO cardinfo (cardnumber,clientname ,expiredate ) values ((SELECT cardnumber FROM userinfo WHERE email = :email),:clientname ,TO_DATE(:expiredate, 'DD/MM/YYYY') )";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.Add("email", email);
                cmd.Parameters.Add("clientname", card.clientName);
                cmd.Parameters.Add("expiredate", expiredate);
                int r = -1;

                try
                {
                    r = cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    throw (err);
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
            else
            {
                return false;
            }

        }
        //done
        public cards getCardInfoByemail(string email)
        {
            OracleCommand cardInfoQuery = new OracleCommand();
            cardInfoQuery.Connection = conn;
            cardInfoQuery.CommandText = "SELECT * FROM cardinfo WHERE cardnumber = (SELECT cardnumber FROM userinfo WHERE email = :email)";
            cardInfoQuery.CommandType = System.Data.CommandType.Text;
            cardInfoQuery.Parameters.Add("email", email);

            OracleDataReader dr;

            try
            {
                dr = cardInfoQuery.ExecuteReader();

            }
            catch
            {

                return null;
            }

            if (dr.HasRows)
            {
                if (dr.Read())

                {
                    card = new cards(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString());
                    return card;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public bool UpdateInfo(string email, dataToBeUpdated newData)
        {

            string userBirthDateArr = newData.age.Split(' ')[0];

            string userBirthDate = Convert.ToDateTime(userBirthDateArr).ToString("dd-MM-yyyy");


            int r = -1;
            bool status = false;
            //updateCardNumberInUserInfo(cardInfo.cardId, email);
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn;
            //userinfo

            cmd.CommandText = "UPDATE userinfo SET email= :newEmail,username= :newUserName , phone= :newPhone , age=TO_DATE(:age, 'DD/MM/YYYY')   WHERE email=:email";
            cmd.Parameters.Add("newEmail", newData.email);
            cmd.Parameters.Add("newUserName", newData.name);
            cmd.Parameters.Add("newPhone", newData.phoneNumber);
            cmd.Parameters.Add("newAge", userBirthDate);

            cmd.Parameters.Add("email", email);

            try
            {
                r = cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                status = false;
                throw (err);
            }
            if (r != -1)
            {
                status = true;
            }
            return status;


        }

        public bool Updatepassword(string email, string newpassword)
        {




            int r = -1;
            bool status = false;

            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn;


            cmd.CommandText = "UPDATE userinfo SET password=:newpassword    WHERE email=:email";

            cmd.Parameters.Add("newPassword", newpassword);

            cmd.Parameters.Add("email", email);

            try
            {
                r = cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                status = false;
                throw (err);
            }
            if (r != -1)
            {
                status = true;
            }
            return status;


        }


        public bool updatecardinfo(string email, UserModel.dataToBeUpdated.cardInfo cardinfo)
        {

            //  updateCardNumberInUserInfo(cardinfo.cardId, email);

            string expiredatearr = cardinfo.expiredate.Split(' ')[0];

            string expiredate = Convert.ToDateTime(expiredatearr).ToString("dd-MM-yyyy");

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            cmd2.CommandText = "UPDATE cardinfo SET expiredate=TO_DATE(:age, 'DD/MM/YYYY') , clientname=:newClientName  WHERE cardnumber =:cardNumber";
            cmd2.Parameters.Add("expiredate", expiredate);
            cmd2.Parameters.Add("newClientName", cardinfo.clientName);
            cmd2.Parameters.Add("cardNumber", getCardInfoByemail(email).cardId);



            try
            {
                int x = cmd2.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        ~UserModel()
        {
            conn.Dispose();

        }

    }
    class cards
    {
        public int cardId;
        public string clientName;
        public string expirydate;

        public cards(int cardId, string clientName, string expirydate)
        {
            this.cardId = cardId;
            this.clientName = clientName;
            this.expirydate = expirydate;
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
