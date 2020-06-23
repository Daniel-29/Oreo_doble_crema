using System;
using System.Windows.Forms;
using Arkanoid.Core.Controller;
using Arkanoid.Core.Gameplay;

namespace Arkanoid
{
    public partial class Game : Form
    {
        MapController map;
        Core.Gameplay.Player player;
        string nickname_current;
        private bool StartBall = false;
        Random r = new Random();
        private int seg=0, min=0, hor=0;
        public Game(string nickname_current)
        {
            InitializeComponent();
            this.nickname_current = nickname_current;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width.ToString());
            int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height.ToString());
            Settings.MapWidth = screenWidth;
            Settings.MapHeight = screenHeight;
            Settings.WidthBlocks1 = ((Settings.MapWidth - 2 * Settings.WidthWallsV1) / Settings.ColumnsBlocks);
            Settings.HeightWallsV1 = (Settings.MapHeight-50) / 10;
            Settings.WidthWallsH1 = ((Settings.MapWidth - 2 * Settings.WidthWallsV1) / 16);
            GameSettings settings =new GameSettings(true);
            settings.ShowDialog();
            Init();
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if (Settings.Playing && Settings.MousePlay1)
            {  
                if (e.X < (Settings.MapWidth-Settings.WidthWallsV1)-(Settings.WidthPlayer1/2)  && e.X >(Settings.WidthPlayer1/2)+Settings.WidthWallsV1)
                { 
                    player.platformX = (e.X)-(Settings.WidthPlayer1/2);
                }else if ( e.X < (Settings.WidthPlayer1/2)+Settings.WidthWallsV1)
                {
                    player.platformX =  Settings.WidthWallsV1;
                }else if (e.X > (Settings.MapWidth-Settings.WidthWallsV1)-(Settings.WidthPlayer1/2)  )
                {
                    player.platformX = (Settings.MapWidth - Settings.WidthWallsV1) - (Settings.WidthPlayer1);
                }
            }
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            if (Settings.Playing )
            { 
                map.DrawArea(e.Graphics);
                map.DrawWalls(e.Graphics);
                map.DrawMap(e.Graphics,player);
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Playing && Settings.Hearts > 0)
                {


                    if (player.ballY + Settings.HeightBall1 >= Settings.MapHeight)
                    {
                        Settings.Hearts--;
                        StartBall = false;
                        Continue();
                    }

                    ChoqueMuros();
                    ChoquePlayer();
                    ColicionesBallBlocks();
                    lbScore.Text = "Score:" + Settings.Score;
                    if (Settings.Score >= Settings.ChangeScore1)
                    {
                        map.AddLine();
                        Settings.SpeedBall++;
                        Settings.ChangeScore1 += Settings.ChangeScore2;
                    }

                    if (StartBall)
                    {
                        player.ballX += player.dirX * Settings.SpeedBall;
                        player.ballY += player.dirY * Settings.SpeedBall;
                        if (player.AnnimationFrame < 3)
                            player.AnnimationFrame++;
                        else
                        {
                            player.AnnimationFrame = 0;
                        }
                    }
                    else
                    {
                        player.ballY = player.platformY - Settings.HeightBall1;
                        player.ballX = player.platformX + Settings.WidthPlayer1 / 2 - Settings.WidthBall1 / 2;
                    }

                    Invalidate();
                }
                else
                {
                    throw new NoLifesException("");
                }
            }catch (NoLifesException ex)
            {
                Settings.Playing = false;
                tmrJuego.Stop();
                tmrUpdate.Stop();
                var gameOver = new GameOver(nickname_current);
                gameOver.Show();
                this.Hide();
            }
        }
        
        public void Continue()
        {
            tmrUpdate.Interval = 1;
            player.ballY = player.platformY-Settings.HeightBall1;
            player.ballX =  ( Settings.MapWidth-1)/2;
            player.dirX = (r.Next(1, 3) == 1) ? 1 : -1;
            player.dirY = -1;
            tmrUpdate.Start();
        }
        public void Init()
        {
            map = new MapController();
            player = new Core.Gameplay.Player();
            tmrUpdate.Interval = 1;
            player.platformX = ( Settings.MapWidth-1)/2;
            player.platformY = (Settings.MapHeight-Settings.HeightPlayer1);
            player.ballY = player.platformY-Settings.HeightBall1;
            player.ballX =  ( Settings.MapWidth-1)/2;
            player.dirX = (r.Next(1, 3) == 1) ? 1 : -1;
            player.dirY = -1;
            map.GeneratePlatforms();
            tmrUpdate.Start();    
        }
         private void ChoqueMuros()
        {
            if (player.ballY <= 50 + Settings.HeightWallsH1)
            {
                player.dirX =(player.dirX==1)?1:-1;
                player.dirY = 1;
            }else if (player.ballX <= Settings.WidthWallsV1)
            {
                player.dirX = 1;
            }else if (player.ballX >= Settings.MapWidth-Settings.WidthWallsV1-Settings.WidthBall1)
            {
                player.dirX = -1;
            }
        }
        private void ChoquePlayer()
        {
            if (player.ballY + Settings.HeightBall1 >= player.platformY && player.ballX > player.platformX &&
                player.ballX < player.platformX + Settings.WidthPlayer1)
            {
                player.dirX =(player.dirX==1)?1:-1;
                player.dirY = -1;
            }
        }
        private bool hitbox(int pY,int pX)
        {
            bool choque = false;
            if (player.ballY >= pY  && player.ballY <= pY+Settings.HeightBlocks1 && player.ballX >= pX && player.ballX <= pX + Settings.WidthBlocks1)
            {
                player.dirY = 1;
                choque = true;
            }else if (player.ballY+Settings.HeightBall1 >= pY  && player.ballY+Settings.HeightBall1 <= pY+Settings.HeightBlocks1 && player.ballX+Settings.WidthBall1 >= pX && player.ballX +Settings.WidthBall1<= pX + Settings.WidthBlocks1)
            {
                player.dirY = -1;
                choque = true;
            }
            else if (player.ballY >= pY  && player.ballY<= pY+Settings.HeightBlocks1 && player.ballX+Settings.WidthBall1 >= pX && player.ballX +Settings.WidthBall1<= pX + Settings.WidthBlocks1)
            {
                player.dirY = 1;
                choque = true;
            }
            else if (player.ballY+Settings.HeightBall1 >= pY  && player.ballY+Settings.HeightBall1 <= pY+Settings.HeightBlocks1 && player.ballX >= pX && player.ballX <= pX + Settings.WidthBlocks1)
            {
                player.dirY = -1;
                choque = true;
            }
            return choque;
        }
        private void ColicionesBallBlocks()
        {
            int py = (50 + Settings.RowsBlocks * Settings.HeightBlocks1 + Settings.HeightWallsH1) -
                     Settings.HeightBlocks1;
            for(int i =py; i >= 50; i-=Settings.HeightBlocks1)
            {
                for (int j = Settings.WidthWallsV1; j <= Settings.WidthBlocks1*Settings.ColumnsBlocks; j+=Settings.WidthBlocks1)
                {
                    if (map.map[i, j] != 0)
                    {
                        if ((i + Settings.HeightBlocks1) >= player.platformY)
                        {
                            Settings.Hearts = 0;
                        }
                        if (hitbox(i, j) )
                        {
                            if (map.map[i, j] == 4 || map.map[i, j] == 5)
                            {
                                map.map[i, j] += 2;
                            }
                            else
                            {
                                Settings.Score += map.map[i, j]*10;
                                player.dirX =(player.dirX==1)?1:-1;
                                map.map[i, j] = 0;
                            }
                          
                        }
                    }
                }
             }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape && Settings.Playing)
                {
                    Settings.Playing = false;
                    tmrUpdate.Stop();
                    tmrJuego.Stop();
                    GameSettings settings = new GameSettings(false);
                    settings.ShowDialog();
                    tmrUpdate.Start();
                    tmrJuego.Start();
                }
                else if (e.KeyCode == Keys.Space && Settings.Playing)
                {
                    StartBall = true;
                    tmrJuego.Start();
                }
                else
                {
                    throw new WrongKeyException("Presiona Space para jugar o Escape para pausar el juego");
                }
            } catch (WrongKeyException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tmrJuego_Tick(object sender, EventArgs e)
        {
            seg++;    
            string segundos = seg.ToString(); 
            string minutos = min.ToString(); 
            string horas = hor.ToString(); 
            if (seg == 60) { 
                min += 1; 
                seg = 0; 
            } if (min == 60) { 
                hor += 1; 
                min = 0; 
            } 
            if (seg < 10) {segundos = "0" + seg.ToString();} 
            if (min < 10) { minutos = "0" + min.ToString();}
            if (hor < 10) { horas = "0" + hor.ToString();}

            lbTiming.Text = ""+horas + ":" + minutos + ":" + segundos;
            Settings.TiempoJuado1 = lbTiming.Text;
        }
    }
}