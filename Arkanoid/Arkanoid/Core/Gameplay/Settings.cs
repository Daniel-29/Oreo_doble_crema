using System.Drawing;

namespace Arkanoid.Core.Gameplay
{
    // En esta clase estan la configuracion del juego.
    public static class Settings
    {
        private static string TiempoJuado;
        private static int hearts=1;
        private static int hearts_total=1;

        private static int score=0;
        private static int ChangeScore=400;
        private static int _ChangeScore=500;
        private static int speedBall=30;
        private static int rowsBlocks=4;
        private static int columnsBlocks=8;
        
        private static int mapWidth;
        private static int mapHeight;
        
        private static int WidthPlayer=200;
        private static int HeightPlayer=50;
        
        private static int WidthBall=40;
        private static int HeightBall=40;
        
        private static int WidthWallsH=100;
        private static int HeightWallsH=40;
        
        private static int WidthWallsV=40;
        private static int HeightWallsV=100;
        
        private static int WidthBlocks=100;
        private static int HeightBlocks=50;
        
        private static bool playing=false;
        private static bool MousePlay=true;
        public static Image Sprites = new Bitmap("../../Resources/sprite.png");
        static Settings()
        {
        }

        public static Image Sprites1
        {
            get => Sprites;
            set => Sprites = value;
        }

        public static string TiempoJuado1
        {
            get => TiempoJuado;
            set => TiempoJuado = value;
        }

        public static int MapWidth
        {
            get => mapWidth;
            set => mapWidth = value;
        }

        public static int MapHeight
        {
            get => mapHeight;
            set => mapHeight = value;
        }

        public static int WidthPlayer1
        {
            get => WidthPlayer;
            set => WidthPlayer = value;
        }

        public static int HeightPlayer1
        {
            get => HeightPlayer;
            set => HeightPlayer = value;
        }

        public static int WidthBlocks1
        {
            get => WidthBlocks;
            set => WidthBlocks = value;
        }

        public static int HeightBlocks1
        {
            get => HeightBlocks;
            set => HeightBlocks = value;
        }

        public static bool Playing
        {
            get => playing;
            set => playing = value;
        }

        public static bool MousePlay1
        {
            get => MousePlay;
            set => MousePlay = value;
        }
        public static int WidthBall1
        {
            get => WidthBall;
            set => WidthBall = value;
        }

        public static int HeightBall1
        {
            get => HeightBall;
            set => HeightBall = value;
        }

        public static int WidthWallsH1
        {
            get => WidthWallsH;
            set => WidthWallsH = value;
        }

        public static int HeightWallsH1
        {
            get => HeightWallsH;
            set => HeightWallsH = value;
        }

        public static int WidthWallsV1
        {
            get => WidthWallsV;
            set => WidthWallsV = value;
        }

        public static int HeightWallsV1
        {
            get => HeightWallsV;
            set => HeightWallsV = value;
        }

        public static int Hearts
        {
            get => hearts;
            set => hearts = value;
        }

        public static int HeartsTotal
        {
            get => hearts_total;
            set => hearts_total = value;
        }

        public static int Score
        {
            get => score;
            set => score = value;
        }

        public static int SpeedBall
        {
            get => speedBall;
            set => speedBall = value;
        }

        public static int RowsBlocks
        {
            get => rowsBlocks;
            set => rowsBlocks = value;
        }

        public static int ColumnsBlocks
        {
            get => columnsBlocks;
            set => columnsBlocks = value;
        }

        public static int ChangeScore1
        {
            get => ChangeScore;
            set => ChangeScore = value;
        }

        public static int ChangeScore2
        {
            get => _ChangeScore;
            set => _ChangeScore = value;
        }
    }
}