using System;
using System.Drawing;

namespace Arkanoid.Core.Gameplay
{
    // Esta clase se encargar de controlar los sprites del juego
  public class MapController
  {
      // se cargar las dimensiones del canvas que tendra el juego
    public int[,] map=new int[Settings.MapHeight,Settings.MapWidth];
        public MapController()
        {
        }
        public void AddLine()
        {
            //Este metodo agrega un line de bloques que en el canvas
            Random r = new Random();
            int py = (50 + Settings.RowsBlocks * Settings.HeightBlocks1 + Settings.HeightWallsH1) -
                     Settings.HeightBlocks1;
            for(int i =py; i >= 50; i-=Settings.HeightBlocks1)
            {
                for (int j = Settings.WidthWallsV1; j <= Settings.WidthBlocks1*Settings.ColumnsBlocks; j+=Settings.WidthBlocks1)
                {
                    if (map[i, j] != 0)
                    {
                        map[i+Settings.HeightBlocks1, j] = map[i, j];
                        map[i, j] = 0;
                    }
                }
            }
            for (int j = Settings.WidthWallsV1; j <= Settings.WidthBlocks1*Settings.ColumnsBlocks; j+=Settings.WidthBlocks1)
            {
                int currPlatform = r.Next(1, 6);
                map[50+Settings.HeightWallsH1, j] = currPlatform;
            }
            Settings.RowsBlocks++;
        }
        public void GeneratePlatforms()    
        {
            // En este metodo se calculan las posiciones de los bloques
            Random r = new Random();
            int py = 50+Settings.HeightWallsH1;
           for(int i = 0; i < Settings.RowsBlocks; i++)
            {
                for (int j = Settings.WidthWallsV1; j <= Settings.WidthBlocks1*Settings.ColumnsBlocks; j+=Settings.WidthBlocks1)
                {
                    int currPlatform = r.Next(1, 6);
                    map[py, j] = currPlatform;
                }
                py += Settings.HeightBlocks1;
            }
        }
        public void DrawWalls(Graphics g)
        {
            //En este metodo de calcular las posciones de los muros de horizontales y verticales
            int auxX=Settings.WidthWallsV1, auxY=50;
            for (int k =1; k <= Settings.Hearts; k++)
            {    
                g.DrawImage(Settings.Sprites, new Rectangle(new Point((k-1)*45 , 0 ), new Size( 45, 45)), 424, 330, 56, 50, GraphicsUnit.Pixel);//heart
            }
            for (int i = 0; i < 10; i++)
            {
                g.DrawImage(Settings.Sprites, new Rectangle(new Point(0, auxY), new Size(Settings.WidthWallsV1, Settings.HeightWallsV1)), 595, 0, 100, 198, GraphicsUnit.Pixel);//Horizontal
                g.DrawImage(Settings.Sprites, new Rectangle(new Point(Settings.MapWidth-Settings.WidthWallsV1 , auxY ), new Size( Settings.WidthWallsV1, Settings.HeightWallsV1)), 595, 0, 100, 198, GraphicsUnit.Pixel);//Horizontal
                auxY += Settings.HeightWallsV1;
            }
            for (int j = 0; j < 16; j++)
            {
                g.DrawImage(Settings.Sprites, new Rectangle(new Point(auxX , 50 ), new Size( Settings.WidthWallsH1, Settings.HeightWallsH1)), 2, 0, 200, 99, GraphicsUnit.Pixel);//Vertical
                auxX += Settings.WidthWallsH1;
            }

        }
        public void DrawMap(Graphics g,Player player)
        {
            // En este metodo se asigna los spite al dirferente posicones del mapa
            g.DrawImage(Settings.Sprites, new Rectangle(new Point(player.platformX, player.platformY), new Size(Settings.WidthPlayer1, Settings.HeightPlayer1)), 205, 320, 198, 50, GraphicsUnit.Pixel);
            g.DrawImage(Settings.Sprites, new Rectangle(new Point(player.ballX,player.ballY), new Size(Settings.WidthBall1, Settings.HeightBall1)), 512+(player.AnnimationFrame*56), 327, 56, 62, GraphicsUnit.Pixel);
            for (int i = 0; i < Settings.MapHeight; i++)
            {
                for (int j = 0; j < Settings.MapWidth; j++)
                {
                    if (map[i, j] == 1)
                    {
                        g.DrawImage(Settings.Sprites, new Rectangle(new Point(j , i ), new Size( Settings.WidthBlocks1, Settings.HeightBlocks1)), 198, 0, 198, 98, GraphicsUnit.Pixel);//Verde
                    }else if (map[i, j] == 2)
                    {
                        g.DrawImage(Settings.Sprites, new Rectangle(new Point(j , i ), new Size( Settings.WidthBlocks1, Settings.HeightBlocks1)), 595, 198, 198, 98, GraphicsUnit.Pixel);//Negro
                    }else if (map[i, j] == 3)
                    {  
                        g.DrawImage(Settings.Sprites, new Rectangle(new Point(j , i ), new Size( Settings.WidthBlocks1, Settings.HeightBlocks1)), 0, 298, 198, 98, GraphicsUnit.Pixel);//Amarilo
                    }else if (map[i, j] == 4)
                    {
                        g.DrawImage(Settings.Sprites, new Rectangle(new Point(j , i ),new Size( Settings.WidthBlocks1, Settings.HeightBlocks1)), 0, 200, 197, 98, GraphicsUnit.Pixel);//Azul
                    }else if (map[i, j] == 5)
                    {
                        g.DrawImage(Settings.Sprites, new Rectangle(new Point(j , i ), new Size( Settings.WidthBlocks1, Settings.HeightBlocks1)), 397, 100, 198, 98, GraphicsUnit.Pixel);//Rojo
                    }else if (map[i, j] == 6)
                    {
                        g.DrawImage(Settings.Sprites, new Rectangle(new Point(j , i ),new Size( Settings.WidthBlocks1, Settings.HeightBlocks1)), 397, 200, 198, 98, GraphicsUnit.Pixel);//Azul roto
                    }else if (map[i, j] == 7)
                    {
                        g.DrawImage(Settings.Sprites, new Rectangle(new Point(j , i ),new Size( Settings.WidthBlocks1, Settings.HeightBlocks1)), 198, 200, 198, 98, GraphicsUnit.Pixel);//Rojo roto 
                    }
                   
                }
            }
        }

        public void DrawArea(Graphics g)
        {
            // En este metodo de crear el canvas
            g.DrawRectangle(Pens.Black, new Rectangle(0, 50, Settings.MapWidth , Settings.MapHeight ));
        }
  }
}