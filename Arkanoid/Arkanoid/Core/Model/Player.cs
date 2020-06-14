using Npgsql;

namespace Arkanoid.Core.Model
{
    public class Player
    {
        private Database db;
        private NpgsqlConnection cn;
        private NpgsqlCommand cmd;
        private NpgsqlDataReader dr;
        private string sql;

        private int id_player;
        private string nickname;
        private int lifes;

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

        public bool insertPlayer()
        {
            cn.Open();
            sql = "INSERT INTO player (nickname, lifes) values (@nickname, @lifes);";
            cmd = new NpgsqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("nickname", nickname);
            cmd.Parameters.AddWithValue("lifes", lifes);
            cmd.Prepare();
            var result = cmd.ExecuteNonQuery();
            cn.Close();
            selectLastId();
            return result == 1;
        }

        private void selectLastId()
        {
            cn.Open();
            sql = "SELECT p.id_player FROM player p ORDER BY p.id_player DESC LIMIT 1;";
            cmd = new NpgsqlCommand(sql, cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_player = dr.GetInt32(0);
            }
            cn.Close();
        }
    }
}