using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace flight_project
{
    class AdminModel
    {
        OracleDataAdapter adapter = new OracleDataAdapter();
        OracleCommandBuilder builder;
        DataSet ds;
        string constr = "Data Source=orcl; User Id=scott;Password=tiger;";
        string cmdstr = "";
        public int getlastid()
        {

            cmdstr = "select max(FLIGHTID) from FLIGHTINFO";
            adapter.SelectCommand = new OracleCommand(cmdstr, new OracleConnection(constr));
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0].ToString() != "")
            {
                return (Convert.ToInt32(dataTable.Rows[0][0]));
            }
            else
            {
                return 0;
            }
        }
        public bool InsertFlight(string dest, string leaving, float discount, int noofseats, char classtype, float price, string date)
        {
            cmdstr = "INSERT INTO FLIGHTINFO (FLIGHTID,DESTINATION,LEAVING,DISCOUNT,NUMBEROFSEAT,CLASSTYPE,FLIGHTPRICE,FLIGHTDATE) VALUES " +
                "(:value1,:value2,:value3,:value4,:value5,:value6,:value7,TO_DATE(:value8, 'DD/MM/YYYY'))";
            OracleConnection conn = new OracleConnection(constr);
            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand(cmdstr, conn);
                command.Parameters.Add(":value1", getlastid() + 1);
                command.Parameters.Add(":value2", dest);
                command.Parameters.Add(":value3", leaving);
                command.Parameters.Add(":value4", discount);
                command.Parameters.Add(":value5", noofseats);
                command.Parameters.Add(":value6", classtype);
                command.Parameters.Add(":value7", price);
                command.Parameters.Add(":value8", date);
                int rowsInserted = command.ExecuteNonQuery();
                if (rowsInserted > 0)
                {
                    MessageBox.Show("Data inserted successfully!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Data insertion failed!");
                    return false;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
