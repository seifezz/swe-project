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

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO cardinfo (cardnumber,pass,clientname) values ((SELECT cardnumber FROM userinfo WHERE email = :email),:pass,:clientname)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("email", email);
                cmd.Parameters.Add("pass", card.passNum);
                cmd.Parameters.Add("clientname", card.clientName);
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
                    card = new cards(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), dr[2].ToString());
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
        public bool UpdateInfo(string email, dataToBeUpdated newData, UserModel.dataToBeUpdated.cardInfo cardInfo, bool availcredit)
        {
            int r = -1, x = -1;
            bool status = false;
            updateCardNumberInUserInfo(cardInfo.cardId, email);
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn;
            //userinfo
            cmd.CommandText = "UPDATE userinfo SET email= :newEmail,username= :newUserName , phone= :newPhone , password= :newPassword , age= :newAge   WHERE email=:email";
            cmd.Parameters.Add("newEmail", newData.email);
            cmd.Parameters.Add("newUserName", newData.name);
            cmd.Parameters.Add("newPhone", newData.phoneNumber);
            cmd.Parameters.Add("newPassword", newData.password);
            cmd.Parameters.Add("newAge", newData.age);

            cmd.Parameters.Add("email", email);
            //cardinfo

            if (availcredit)
            {
                cmd2.CommandText = "UPDATE cardinfo SET pass=:newPass, clientname=:newClientName WHERE cardnumber =:cardNumber";
                cmd2.Parameters.Add("newPass", cardInfo.passNum);
                cmd2.Parameters.Add("newClientName", cardInfo.clientName);
                cmd2.Parameters.Add("cardNumber", getCardInfoByemail(email).cardId);
                try
                {
                    r = cmd.ExecuteNonQuery();
                    x = cmd2.ExecuteNonQuery();

                }
                catch (Exception err)
                {
                    status = false;
                    throw (err);
                }
                if (r != -1 && x != -1)
                {

                    status = true;

                }
                return status;
            }
            else
            {
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

        }

        ~UserModel()
        {
            conn.Dispose();

        }

    }
    class cards
    {
        public int cardId;
        public int passNum;
        public string clientName;

        public cards(int cardId, int passNum, string clientName)
        {
            this.cardId = cardId;
            this.clientName = clientName;
            this.passNum = passNum;
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
