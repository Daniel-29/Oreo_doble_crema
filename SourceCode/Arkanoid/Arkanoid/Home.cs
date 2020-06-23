using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
  public partial class Home : Form
  {
    //Se inicializan los recursos graficos del juego
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
      //Se coloca la propiedad sizemode en tipo strech para mejor visualizacion de la imagen
      BackgroundImageLayout = ImageLayout.Stretch;
      ptb_titulo.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_play.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_record.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_exit.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_back.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_min.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_max.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_close.SizeMode = PictureBoxSizeMode.StretchImage;
      //Se cargan las imagenes principales del diseño
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
      //Se cambia la imagen del boton "Jugar" cuando el puntero se situa sobre el
      ptb_play.Image = imgplayh;
      ptb_play.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    private void ptb_record_MouseEnter(object sender, EventArgs e)
    {
      //Se cambia la imagen del boton "Puntaje" cuando el puntero se situa sobre el
      ptb_record.Image = imgrecordh;
      ptb_record.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_exit_MouseEnter(object sender, EventArgs e)
    {
      //Se cambia la imagen del boton "Salir" cuando el puntero se situa sobre el
      ptb_exit.Image = imgexith;
      ptb_exit.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_play_MouseLeave(object sender, EventArgs e)
    {
      //Se cambia la imagen del boton "Jugar" cuando el puntero deja de estar sobre el
      ptb_play.Image = imgplay;
      ptb_play.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_record_MouseLeave(object sender, EventArgs e)
    {
      //Se cambia la imagen del boton "Puntaje" cuando el puntero deja de estar sobre el
      ptb_record.Image = imgrecord;
      ptb_record.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_exit_MouseLeave(object sender, EventArgs e)
    {
      //Se cambia la imagen del boton "Salir" cuando el puntero deja de estar sobre el
      ptb_exit.Image = imgexit;
      ptb_exit.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    //Metodo para cambiar los user controlls
    private void changeUserControl(UserControl obj){
      //se remueve el user control actual
      tbly_core.Controls.Remove(current);
      current = obj;
      current.Dock = DockStyle.Fill;
      //Se agrega el nuevo user control
      tbly_core.Controls.Add(current, 0, 1);
    }

    private void ptb_play_Click(object sender, EventArgs e)
    {
      //Al dar click sobre el boton "Jugar" se muestra la pantalla del jugador
      changeUserControl(new Player(this));
    }

    private void ptb_record_Click(object sender, EventArgs e)
    {
      //Al dar click sobre el boton "Puntaje" se muestra la pantalla con el Top 10
      changeUserControl(new Record(this));
    }

    private void ptb_exit_Click(object sender, EventArgs e)
    {
      //Al dar click sobre el boton "Salir" se muestra un mensaje de confirmacion y si el usuario acepta salir se cierra el juego
      var question = MessageBox.Show("¿Desea cerrar el juego?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
      if (question == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    private void ptb_back_Click(object sender, EventArgs e)
    {
      //Se muestra el menu al dar click sobre la flecha que apunta a la izquierda en la pantalla
      tbly_core.Controls.Remove(current);
      current = null;
      tbly_core.Controls.Add(tbly_menu, 0, 1);
    }

    private void ptb_close_Click(object sender, EventArgs e)
    {
      //Muestra un mensaje de confirmacion y si el usario apecta se cierra el juego
      var question = MessageBox.Show("¿Desea cerrar el juego?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
      if (question == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    private void ptb_max_Click(object sender, EventArgs e)
    {
      //Se maximiza la pantalla de juego si este esta en vista normal y viceversa
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
      //Se minimiza la pantalla del juego
      WindowState = FormWindowState.Minimized;
    }
  }
}