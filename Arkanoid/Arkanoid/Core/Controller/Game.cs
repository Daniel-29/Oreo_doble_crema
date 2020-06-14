using System.Data;

namespace Arkanoid.Core.Controller
{
    public class Game
    {
        private Model.Game new_game;

        private int id_game;
        private int id_player;
        private int score;
        private string duration;
    
        public Game()
        {
            this.new_game = new Model.Game();
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

        public bool startGame()
        {
            new_game.IdPlayer = id_player;
            if (new_game.insertGame())
            {
                id_game = new_game.IdGame;
                return true;
            }
            return false;
        }

        public bool endGame()
        {
            new_game.Score = score;
            new_game.Duration = duration;
            new_game.IdGame = IdGame;
            return new_game.updateGame();
        }

        public DataTable viewTopPlayers()
        {
            return new_game.selectTopPlayers();
        }
    }
}