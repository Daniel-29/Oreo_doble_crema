using System.Data;
using Npgsql;

namespace Arkanoid.Core.Model
{
  public class Game
  {
    //Se declaran las varibales
    private Database db;
    private NpgsqlConnection cn;
    private NpgsqlCommand cmd;
    private NpgsqlDataReader dr;
    private DataTable dt;
    private string sql;

    private int id_game;
    private int id_player;
    private int score;
    private string duration;
    
    //Establecemos la conexion con la base de datos
    public Game()
    {
      db = new Database();
      cn = db.connectDatabase();
    }

    public int IdGame
    {
      get => id_game;
      set => id_game = value;
    }

    public int IdPlayer
    {
      get => id_player;
      set => id_player = value;
    }

    public int Score
    {
      get => score;
      set => score = value;
    }

    public string Duration
    {
      get => duration;
      set => duration = value;
    }

    //Metodo para insertar nueva partida en la base de datos
    public bool insertGame()
    {
      //Se abre la conexion
      cn.Open();
      //Consulta Insertar partida
      sql = "INSERT INTO game (id_player) values (@id_player);";
      cmd = new NpgsqlCommand(sql, cn);
      cmd.Parameters.AddWithValue("id_player", id_player);
      cmd.Prepare();
      //Se ejecuta la consulta
      var result = this.cmd.ExecuteNonQuery();
      //Se cierra la conexion
      cn.Close();
      selectLastId();
      return result == 1;
    }

    //Metodo para modificar una partida
    public bool updateGame()
    {
      //Se abre la conexion
      cn.Open();
      //Consulta para modificar puntaje y duracion de una partida
      sql = "UPDATE game SET score = @score, duration = @duration, game_time = CURRENT_TIME, game_date = CURRENT_DATE WHERE id_player = @id_player;";
      cmd = new NpgsqlCommand(sql, cn);
      cmd.Parameters.AddWithValue("score", score);
      cmd.Parameters.AddWithValue("duration", duration);
      cmd.Parameters.AddWithValue("id_player", id_player);
      cmd.Prepare();
      //Se ejecuta la consulta
      var result = cmd.ExecuteNonQuery();
      //Se cierra la conexion
      cn.Close();
      return result == 1;
    }

    //Metodo para obtener el top 10 de jugadores
    public DataTable selectTopPlayers()
    {
      //Se abre la conexion
      cn.Open();
      //Consulta para seleccionar solo los 10 jugadores con el mejor puntaje
      sql = "SELECT p.nickname, p.lifes, g.score, g.duration, g.game_date, to_char(g.game_time, 'HH12:MI:SS') AS game_time FROM game g INNER JOIN player p ON p.id_player = g.id_player ORDER BY g.score DESC LIMIT 10;";
      cmd = new NpgsqlCommand(sql, cn);
      dt = new DataTable();
      //Se ejecuta la consulta
      dt.Load(cmd.ExecuteReader());
      //Se cierra la conexion
      cn.Close();
      return dt;
    }

    //Metodo para obtener el ultimo id insertado
    private void selectLastId()
    {
      //Se abre la conexion
      cn.Open();
      //Consulta para seleccionar el id del ultimo juego insertado 
      sql = "SELECT g.id_game FROM game g ORDER BY g.id_game DESC LIMIT 1;";
      cmd = new NpgsqlCommand(this.sql, this.cn);
      //Se ejecuta la consulta
      dr = cmd.ExecuteReader();
      while (dr.Read())
      {
        id_game = dr.GetInt32(0);
      }
      //Se cierra la conexion
      cn.Close();
    }
  }
}