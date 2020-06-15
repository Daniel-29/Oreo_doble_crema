using System;
using System.Deployment.Application;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Core.Gameplay;

namespace Arkanoid
{
  public partial class Player : UserControl
  {
    private Form frm;
    private const string path = "../../Resources/";
    private Image title = new Bitmap(path+"nickname.png");
    private Image continuar = new Bitmap(path+"btn_continuar.png");
    private Image continuarh = new Bitmap(path+"btn_continuar_hover.png");
    public Player(Form frm)
    {
      this.frm = frm;
      InitializeComponent();
      ptb_title.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_title.Image = title;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_continuar.Image = continuar;
    }

    private void ptb_continuar_Click(object sender, EventArgs e)
    {
      if (!txt_nickname.Text.Equals(""))
      {
        Settings.Hearts = Convert.ToInt32(n_vidas.Text);
        Settings.HeartsTotal = Convert.ToInt32(n_vidas.Text);
        var game = new Game(txt_nickname.Text);
        game.Show();
        frm.Hide();
      }
      else
      {
        MessageBox.Show("Debe ingresar el Nickname.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void ptb_continuar_MouseEnter(object sender, EventArgs e)
    {
      ptb_continuar.Image = continuarh;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_continuar_MouseLeave(object sender, EventArgs e)
    {
      ptb_continuar.Image = continuar;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
    }
  }
}