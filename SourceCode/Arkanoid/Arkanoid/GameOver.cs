using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Arkanoid.Core.Gameplay;

namespace Arkanoid
{
    public partial class GameOver : Form
    {
        string nickname_current;
        public GameOver(string nickname_current)
        {
            InitializeComponent();
            //Se muestra la informacion de la partida que finalizo
            this.nickname_current = nickname_current;
            lbScore.Text = "Puntuacion: "+Settings.Score;
            lbTime.Text = "Tiempo: "+Settings.TiempoJuado1;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            //Se llama al metodo guardar para almacenar la informacion de la partida 
            if (guardar())
            {
                //Si se guarda la informacion se muestra la pantalla de inicio y se esconde esta
                var frm = new Home();
                frm.Show();
                Hide();
            }else{
            
                MessageBox.Show("Ocurrio al guardar la partida.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool guardar()
        {
            var player_current = new Core.Controller.Player();
            player_current.Nickname = nickname_current;
            player_current.Lifes = Settings.HeartsTotal;
            var score_old = player_current.verifyPlayer();
            if (score_old < Settings.Score)
            {
                MessageBox.Show($"Ups {player_current.Nickname}, tu puntaje fue menor al de la vez anterior, seguiremos guardnado el mayor puntaje!");
            }
            else
            {
                if (player_current.IdPlayer != null)
                {
                    var game = new Core.Controller.Game();
                    game.IdPlayer = player_current.IdPlayer;
                    game.Duration = Settings.TiempoJuado1;
                    game.Score = Settings.Score;
                    return game.endGame();
                }
                else
                {
                    player_current.createPlayer();
                    var game = new Core.Controller.Game();
                    game.IdPlayer = player_current.IdPlayer;
                    if (game.startGame())
                    {
                        game.Duration = Settings.TiempoJuado1;
                        game.Score = Settings.Score;
                        return game.endGame();
                    }
                }
            }
            return false;
        }
    }
}