using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (OracleConnection cn = new OracleConnection(Environment.GetEnvironmentVariable("pimsdev_conn_str")))
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "WO_to_LIMS_Wrapper";
                cmd.Parameters.Add("pnWOID", OracleDbType.Int16).Value = 300451;
                cmd.Parameters.Add("psUser", OracleDbType.Char).Value = "XYZ";
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}
