using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace MunicipalLibrary.Options.Data
{
    public class OracleDB
    {
        OracleConnection con = new OracleConnection(ConfigurationManager
            .ConnectionStrings["con"].ConnectionString);

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public OracleConnection GetConnection()
        {
            return con;
        }
    }
}
