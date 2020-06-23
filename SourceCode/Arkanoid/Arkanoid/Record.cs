using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
  public partial class Record : UserControl
  {
    //Se crean las variables a utilizar y se inicializan
    private Form frm;
    private const string path = "../../Resources/";
    private Image title = new Bitmap(path+"top10.png");
    
    public Record(Form frm)
    {
      //Se muestra el top 10 de los jugadores
      this.frm = frm;
      InitializeComponent();
      ptb_title.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_title.Image = title;
      cargar();
    }

    //Metodo para cargar el top 10 de jugadores
    public void cargar()
    {
      var gm = new Core.Controller.Game();
      dgv_records.DataSource = gm.viewTopPlayers();
    }
    
  }
}