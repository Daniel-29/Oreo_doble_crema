using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
  public partial class Home : Form
  {
    private UserControl current;
    private TableLayoutPanel menu;
    private const string path = "../../Resources/";
    private Image background = new Bitmap(path+"menu_principal.png");
    private Image back = new Bitmap(path+"back.png");
    private Image min = new Bitmap(path+"min.png");
    private Image max = new Bitmap(path+"max.png");
    private Image close = new Bitmap(path+"close.png");
    private Image title = new Bitmap(path+"Arkanoidlogo.png");
    private Image imgplay = new Bitmap(path+"btn_jugar.png");
    private Image imgplayh = new Bitmap(path+"btn_jugar_hover.png");
    private Image imgrecord = new Bitmap(path+"btn_puntaje.png");
    private Image imgrecordh = new Bitmap(path+"btn_puntaje_hover.png");
    private Image imgexit = new Bitmap(path+"btn_salir.png");
    private Image imgexith = new Bitmap(path+"btn_salir_hover.png");
    public Home()
    {
      InitializeComponent();
      menu = tbly_menu;
      BackgroundImageLayout = ImageLayout.Stretch;
      ptb_titulo.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_play.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_record.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_exit.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_back.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_min.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_max.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_close.SizeMode = PictureBoxSizeMode.StretchImage;
      BackgroundImage = background;
      ptb_titulo.Image = title;
      ptb_play.Image = imgplay;
      ptb_record.Image = imgrecord;
      ptb_exit.Image = imgexit;
      ptb_back.Image = back;
      ptb_min.Image = min;
      ptb_max.Image = max;
      ptb_close.Image = close; 
    }

    private void ptb_play_MouseEnter(object sender, EventArgs e)
    {
      ptb_play.Image = imgplayh;
      ptb_play.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_record_MouseEnter(object sender, EventArgs e)
    {
      ptb_record.Image = imgrecordh;
      ptb_record.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_exit_MouseEnter(object sender, EventArgs e)
    {
      ptb_exit.Image = imgexith;
      ptb_exit.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_play_MouseLeave(object sender, EventArgs e)
    {
      ptb_play.Image = imgplay;
      ptb_play.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_record_MouseLeave(object sender, EventArgs e)
    {
      ptb_record.Image = imgrecord;
      ptb_record.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_exit_MouseLeave(object sender, EventArgs e)
    {
      ptb_exit.Image = imgexit;
      ptb_exit.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    
    private void changeUserControl(UserControl obj){
      tbly_core.Controls.Remove(current);
      current = obj;
      current.Dock = DockStyle.Fill;
      tbly_core.Controls.Add(current, 0, 1);
    }

    private void ptb_play_Click(object sender, EventArgs e)
    {
      changeUserControl(new Player(this));
    }

    private void ptb_record_Click(object sender, EventArgs e)
    {
      changeUserControl(new Record(this));
    }

    private void ptb_exit_Click(object sender, EventArgs e)
    {
      var question = MessageBox.Show("¿Desea cerrar el juego?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
      if (question == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    private void ptb_back_Click(object sender, EventArgs e)
    {
      tbly_core.Controls.Remove(current);
      current = null;
      tbly_core.Controls.Add(tbly_menu, 0, 1);
    }

    private void ptb_close_Click(object sender, EventArgs e)
    {
      var question = MessageBox.Show("¿Desea cerrar el juego?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
      if (question == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    private void ptb_max_Click(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Maximized)
      {
        WindowState = FormWindowState.Normal;
      }
      else
      {
        WindowState = FormWindowState.Maximized;
      }
    }

    private void ptb_min_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }
  }
}