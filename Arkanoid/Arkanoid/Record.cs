using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
  public partial class Record : UserControl
  {
    private Form frm;
    private const string path = "../../Resources/";
    private Image title = new Bitmap(path+"top10.png");
    public Record(Form frm)
    {
      this.frm = frm;
      InitializeComponent();
      ptb_title.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_title.Image = title;
      cargar();
    }

    public void cargar()
    {
      var gm = new Core.Controller.Game();
      dgv_records.DataSource = gm.viewTopPlayers();
    }
    
  }
}