using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace TestFenox.Persistence
{
    public class Connection
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void OpenConnection()
        {
            try
            {
                Con = new SqlConnection("Data Source=NB-01\\SQLEXPRESS;Initial Catalog=DBFenox;Integrated Security=True;Encrypt=False");
                Con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void CloseConnection()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}