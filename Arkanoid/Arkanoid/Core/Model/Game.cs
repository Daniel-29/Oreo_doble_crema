using System.Data;
using Npgsql;

namespace Arkanoid.Core.Model
{
  public class Game
  {
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

    public bool insertGame()
    {
      cn.Open();
      sql = "INSERT INTO game (id_player) values (@id_player);";
      cmd = new NpgsqlCommand(sql, cn);
      cmd.Parameters.AddWithValue("id_player", id_player);
      cmd.Prepare();
      var result = this.cmd.ExecuteNonQuery();
      cn.Close();
      selectLastId();
      return result == 1;
    }

    public bool updateGame()
    {
      cn.Open();
      sql = "UPDATE game SET score = @score, duration = @duration WHERE id_game = @id_game;";
      cmd = new NpgsqlCommand(sql, cn);
      cmd.Parameters.AddWithValue("score", score);
      cmd.Parameters.AddWithValue("duration", duration);
      cmd.Parameters.AddWithValue("id_game", id_game);
      cmd.Prepare();
      var result = cmd.ExecuteNonQuery();
      cn.Close();
      return result == 1;
    }

    public DataTable selectTopPlayers()
    {
      cn.Open();
      sql = "SELECT p.nickname, p.lifes, g.score, g.duration, g.game_date, to_char(g.game_time, 'HH12:MI:SS') FROM game g INNER JOIN player p ON p.id_player = g.id_player ORDER BY g.score ASC LIMIT 10;";
      cmd = new NpgsqlCommand(sql, cn);
      dt = new DataTable();
      dt.Load(cmd.ExecuteReader());
      cn.Close();
      return dt;
    }

    private void selectLastId()
    {
      cn.Open();
      sql = "SELECT g.id_game FROM game g ORDER BY g.id_game DESC LIMIT 1;";
      cmd = new NpgsqlCommand(this.sql, this.cn);
      dr = cmd.ExecuteReader();
      while (dr.Read())
      {
        id_game = dr.GetInt32(0);
      }
      cn.Close();
    }
  }
}