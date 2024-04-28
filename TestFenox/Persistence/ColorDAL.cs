using Microsoft.Data.SqlClient;
using TestFenox.Models;
using TestFenox.Persistence;

public class ColorDAL : Connection
{
    public void Save(Color color)
    {
        try
        {
            OpenConnection();
            Cmd = new SqlCommand("insert into Color (DescriptionColor, StatusColor) values(@v1, @v2)", Con);

            Cmd.Parameters.AddWithValue("@v1", color.DescriptionColor);
            Cmd.Parameters.AddWithValue("@v2", color.StatusColor);

            Cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao gravar os dados de Cor: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }

    public void Update(Color color)
    {
        try
        {
            OpenConnection();
            Cmd = new SqlCommand("update Color set DescriptionColor=@v1, StatusColor=@v2 where IdFuel=@v3", Con);

            Cmd.Parameters.AddWithValue("@v1", color.DescriptionColor);
            Cmd.Parameters.AddWithValue("@v2", color.StatusColor);
            Cmd.Parameters.AddWithValue("@v3", color.IdColor);

            Cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao atualizar os dados de Cor: " + ex.Message);
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
            Cmd = new SqlCommand("delete from Fuel where IdColor=@v1", Con);

            Cmd.Parameters.AddWithValue("@v1", code);

            Cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao apagar os dados de Cor: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }

    public Color SelectFuel(int code)
    {
        try
        {
            OpenConnection();
            Cmd = new SqlCommand("Select * from Fuel where IdColor=@v1", Con);
            Cmd.Parameters.AddWithValue("@v1", code);

            Color color = null;
            if (Dr.Read())
            {
                color = new Color();
                color.IdColor = Convert.ToInt32(Dr["IdColor"]);
                color.DescriptionColor = Convert.ToString(Dr["DescriptionColor"]);
                color.StatusColor = Convert.ToInt32(Dr["StatusColor"]);
            }
            return color;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao selecionar a Cor: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }

    public List<Color> ListColor()
    {
        try
        {
            OpenConnection();
            Cmd = new SqlCommand("Select * from Color", Con);
            Dr = Cmd.ExecuteReader();

            List<Color> listColor = new List<Color>();
            while (Dr.Read())
            {
                Color color= new Color();
                color.IdColor = Convert.ToInt32(Dr["IdColor"]);
                color.DescriptionColor = Convert.ToString(Dr["DescriptionColor"]);
                color.StatusColor = Convert.ToInt32(Dr["StatusColor"]);

                listColor.Add(color);
            }

            return listColor;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao listar os dados de Cor: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }
}
