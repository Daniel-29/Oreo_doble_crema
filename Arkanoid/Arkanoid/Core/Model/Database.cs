using Npgsql;

namespace Arkanoid.Core.Model
{
  public class Database
  {
    private NpgsqlConnection cn;
    private string str_connect;
    private string host;
    private string port;
    private string user_id;
    private string password;
    private string database;

    public Database()
    {
      this.host = "localhost";
      this.user_id = "postgres";
      this.port = "5432";
      this.password = "password";
      this.database = "arkanoid_db";
    }

    public NpgsqlConnection connectDatabase()
    {
      this.str_connect = $"Server={this.host};Port={this.port}; User Id={this.user_id}; Password={this.password}; Database={this.database}";
      cn = new NpgsqlConnection(this.str_connect);
      return cn;
    }
    
  }
}