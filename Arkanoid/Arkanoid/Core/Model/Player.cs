using Npgsql;

namespace Arkanoid.Core.Model
{
  public class Player
  {
    //Se declaran las varibales
    private Database db;
    private NpgsqlConnection cn;
    private NpgsqlCommand cmd;
    private NpgsqlDataReader dr;
    private string sql;

    private int id_player;
    private string nickname;
    private int lifes;

    //Establecemos la conexion con la base de datos
    public Player()
    {
      db = new Database();
      cn = db.connectDatabase();
    }

    public int IdPlayer
    {
      get => id_player;
      set => id_player = value;
    }

    public string Nickname
    {
      get => nickname;
      set => nickname = value;
    }

    public int Lifes
    {
      get => lifes;
      set => lifes = value;
    }

    //Metodo para insertar un jugador en la base de datos
    public bool insertPlayer()
    {
      //Se abre la conexion
      cn.Open();
      //Consulta Insert
      sql = "INSERT INTO player (nickname, lifes) values (@nickname, @lifes);";
      cmd = new NpgsqlCommand(sql, cn);
      cmd.Parameters.AddWithValue("nickname", nickname);
      cmd.Parameters.AddWithValue("lifes", lifes);
      cmd.Prepare();
      //Se ejecuta la consulta
      var result = cmd.ExecuteNonQuery();
      //Se cierra la conexion
      cn.Close();
      //Llamando al metodo selectLastId
      selectLastId();
      return result == 1;
    }

    //Metodo para seleccionar el ultimo id insertado
    private void selectLastId()
    {
      //Se abre la conexion
      cn.Open();
      //Consulta que selecciona el ultimo id que se ha insertado en la base de datos
      sql = "SELECT p.id_player FROM player p ORDER BY p.id_player DESC LIMIT 1;";
      cmd = new NpgsqlCommand(sql, cn);
      //Se ejecuta la consulta
      dr = cmd.ExecuteReader();
      while (dr.Read())
      {
        //Se agrega el valor del id a la variable
        id_player = dr.GetInt32(0);
      }
      //Se cierra la conexion
      cn.Close();
    }
  }
}