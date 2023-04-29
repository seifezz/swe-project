using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


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

            string expiredatearr = cardinfo.expiredate.Split(' ')[0];

            string expiredate = Convert.ToDateTime(expiredatearr).ToString("dd-MM-yyyy");

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;

            cmd.CommandText = "Delete from cardinfo WHERE cardnumber =:cardNumber ";
            cmd.Parameters.Add("cardNumber", getCardInfoByemail(email).cardId);

            cmd2.CommandText = "UPDATE userinfo SET cardnumber=:cardnumber WHERE email=:email";
            cmd2.Parameters.Add("cardnumber", cardinfo.cardId);
            cmd2.Parameters.Add("email", email);

            cmd3.CommandText = "INSERT INTO cardinfo (cardnumber,clientname ,expiredate ) values (:cardnumber,:clientname ,TO_DATE(:expiredate, 'DD/MM/YYYY') )";
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Parameters.Add("cardnumber", cardinfo.cardId);
            cmd3.Parameters.Add("clientname", cardinfo.clientName);
            cmd3.Parameters.Add("expiredate", expiredate);

            try
            {

                int x = cmd.ExecuteNonQuery();
                int y = cmd2.ExecuteNonQuery();
                int z = cmd3.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }
        public bool cancelflight(int id)
        {
            int r;
            bool check = false;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Delete from BOOKEDFLIGHT where FLIGHTID= :id";
            cmd.Parameters.Add("id", id);
            //r = cmd.ExecuteNonQuery();
            try
            {
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                check = false;
                throw (err);
            }
            if (r > 0)
            {
                check = true;
                MessageBox.Show("cancelled sucessfully");
            }
            else
            {
                check = false;
                MessageBox.Show("Not Found");
            }
            return check;
        }

        public bool deletecardinfo(string email)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            int cardid = getCardInfoByemail(email).cardId;

            cmd.CommandText = "Delete from cardinfo WHERE cardnumber =:cardNumber ";
            cmd.Parameters.Add("cardNumber", cardid);

            cmd2.CommandText = "UPDATE userinfo SET cardnumber=null WHERE email=:email";
            cmd2.Parameters.Add("email", email);
            try
            {
                int x = cmd.ExecuteNonQuery();
                int y = cmd2.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public DataTable search(string dest, string leave)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SEARCHFLIGHT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("dest", dest);
            cmd.Parameters.Add("leave", leave);
            cmd.Parameters.Add("out", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable datatable = new DataTable();
            if (dr.HasRows)
            {
                datatable.Load(dr);
            }
            else
            {
                MessageBox.Show("There is No Matched Flights");
            }
            dr.Close();
            return datatable;
        }
        public OracleDataReader loadbookdata(string id)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECTBOOKDATA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", id);
            cmd.Parameters.Add("out", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return dr;
            }
            return null;
        }

        public string priceafterdisc(string id)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETPRICEAFTERDISC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", id);
            cmd.Parameters.Add("price", OracleDbType.Double, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            return cmd.Parameters["price"].Value.ToString();
        }
        public int getcount(string flightid)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count from BOOKEDFLIGHT where flightid = :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", flightid);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return Convert.ToInt32(dr[0]);
            }
            else
            {
                return 0;
            }
        }

        public bool checkbook(string flightid, string nid)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from BOOKEDFLIGHT where flightid= :fid and nationalid= :nid";
            cmd.Parameters.Add("id", flightid);
            cmd.Parameters.Add("nid", nid);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return false;
            }
            return true;
        }
        public void Bookflight(string flightid, string nationalid, int noofflights)
        {
            if (checkbook(flightid, nationalid))
            {
                int y = getcount(flightid);
                if (y < noofflights)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into BOOKEDFLIGHT values(:id,:nid,:count)";
                    cmd.Parameters.Add("id", flightid);
                    cmd.Parameters.Add("nid", nationalid);
                    cmd.Parameters.Add("count", y + 1);
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Flight is Booked");
                    }
                }
                else
                {
                    MessageBox.Show("There's no Left Places");
                }
            }
            else
            {
                MessageBox.Show("You Already Booked this trip");
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
