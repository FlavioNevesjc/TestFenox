using Microsoft.Data.SqlClient;
using TestFenox.Models;
using TestFenox.Persistence;

namespace TestFenox.Persistence
{
    public class FuelDAL : Connection
    {
        public void Save(Fuel fuel)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("insert into Fuel (DescriptionFuel, StatusFuel) values(@v1, @v2)", Con);

                Cmd.Parameters.AddWithValue("@v1", fuel.DescriptionFuel);
                Cmd.Parameters.AddWithValue("@v2", fuel.StatusFuel);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar os dados de Combustivel: " + ex.Message);
            }
            finally 
            {
                CloseConnection();
            }
        }

        public void Update(Fuel fuel)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("update Fuel set DescriptionFuel=@v1, StatusFuel=@v2 where IdFuel=@v3", Con);

                Cmd.Parameters.AddWithValue("@v1", fuel.DescriptionFuel);
                Cmd.Parameters.AddWithValue("@v2", fuel.StatusFuel);
                Cmd.Parameters.AddWithValue("@v3", fuel.IdFuel);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar os dados de Combustivel: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(int code)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("delete from Fuel where IdFuel=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", code);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao apagar os dados de Combustivel: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public Fuel SelectFuel(int code)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("Select * from Fuel where IdFuel=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", code);
                
                Fuel fuel = null;
                if (Dr.Read())
                {
                    fuel = new Fuel();
                    fuel.IdFuel = Convert.ToInt32(Dr["IdFuel"]);
                    fuel.DescriptionFuel = Convert.ToString(Dr["DescriptionFuel"]);
                    fuel.StatusFuel = Convert.ToInt32(Dr["StatusFuel"]);
                }
                return fuel;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar o Combustivel: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Fuel> ListFuel()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("Select * from Fuel", Con);
                Dr = Cmd.ExecuteReader();

                List<Fuel> listFuel = new List<Fuel>();
                while (Dr.Read())
                {
                    Fuel fuel = new Fuel();
                    fuel.IdFuel = Convert.ToInt32(Dr["IdFuel"]);
                    fuel.DescriptionFuel = Convert.ToString(Dr["DescriptionFuel"]);
                    fuel.StatusFuel = Convert.ToInt32(Dr["StatusFuel"]);

                    listFuel.Add(fuel);
                }
               
                return listFuel;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os dados de Combustivel: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
