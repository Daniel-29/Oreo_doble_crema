namespace Arkanoid.Core.Gameplay
{
  // En esta clase de se controla las posiciones del la plataforma del jugador , las posiciones de las pelota y las frame de animaciones
  public class Player
  {
    public int platformX;
    public int platformY;
    public int ballX;
    public int ballY;
    public int dirX = 0;
    public int dirY = 0;

    public int AnnimationFrame = 0; // max =3;
  }
}