using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerClass
{
    public class Logger
    {
        private string SQLConnection;

        public Logger(string sqlConnect)
        {
            SQLConnection = sqlConnect;
        }

        public void RecordException(Exception ex)
        {
            using (SqlConnection connection = new SqlConnection(SQLConnection))
            {
                connection.Open();
                string Message = String.Empty;
                string InnerException = String.Empty;
                string Source = String.Empty;
                string TargetSite = String.Empty;
                string StackTrace = String.Empty;
                DateTime DateEx = DateTime.Now;
                string ComputerName = Environment.MachineName;

                if (ex.InnerException != null)
                    InnerException = ex.InnerException.Message;

                if (ex.Source != null)
                    Source = ex.Source;

                if (ex.TargetSite != null)
                    TargetSite = ex.TargetSite.Name;

                if (ex.StackTrace != null)
                    StackTrace = ex.StackTrace;


                string SqlQuery = @"insert into dbo.Logs (Message, InnerException, Source, TargetSite, StackTrace, DateEx, ComputerName)
                                    values (@Message, @InnerException, @Source, @TargetSite, @StackTrace, @DateEx, @ComputerName)";

                SqlCommand cmd = new SqlCommand(SqlQuery, connection);

                cmd.Parameters.AddWithValue("@Message", ex.Message.ToString());
                cmd.Parameters.AddWithValue("@InnerException", InnerException);
                cmd.Parameters.AddWithValue("@Source", Source);
                cmd.Parameters.AddWithValue("@TargetSite", TargetSite);
                cmd.Parameters.AddWithValue("@StackTrace", StackTrace);
                cmd.Parameters.AddWithValue("@DateEx", DateEx);
                cmd.Parameters.AddWithValue("@ComputerName", ComputerName);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
