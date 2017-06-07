using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumCollectionManager.Control.Data
{
    public class SqlDbConnection
    {
        public static SqlConnection cn;
        public static SqlConnection getConnection ()
        {
            try
            {
                cn = new SqlConnection("Data Source=FRED-PC;Initial Catalog=MidiaCollectionDb;Persist Security Info=True;User ID=sa;Password=frd2211;Pooling=False");
                //cn.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error {0} ErrorCode {1} LineNumber {2}  Number {3}", ex.Message, ex.ErrorCode, ex.LineNumber, ex.Number);
                foreach (SqlError err in ex.Errors)
                {
                    Console.WriteLine("** Error : {0} LineNumber {1} Number {2}", err.Message, err.LineNumber, err.Number);
                }
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner1 : {0}", ex.InnerException.Message);
                }
            }

            return cn;
        }

        public static SqlConnection getOpenedConnection()
        {
            try
            {
                cn = new SqlConnection("Data Source=FRED-PC;Initial Catalog=MidiaCollectionDb;Persist Security Info=True;User ID=sa;Password=frd2211;Pooling=False");
                cn.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error {0} ErrorCode {1} LineNumber {2}  Number {3}", ex.Message, ex.ErrorCode, ex.LineNumber, ex.Number);
                foreach (SqlError err in ex.Errors)
                {
                    Console.WriteLine("** Error : {0} LineNumber {1} Number {2}", err.Message, err.LineNumber, err.Number);
                }
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner1 : {0}", ex.InnerException.Message);
                }
            }

            return cn;
        }
    }
}
